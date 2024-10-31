using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserManagementUI.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserManagementUI
{
    public class LoginService
    {
        #region ACTIONS

        // Event handlers for login, registration, and password reset result notifications
        public event Action<UserInputStatus, string> LoginActionResultHandler;
        public event Action<UserInputStatus> RegisterActionResultHandler;
        public event Action<UserInputStatus> ResetPasswordResultHandler;

        #endregion
      
        private static LoginService _instance;

        private readonly string connectionString;

        private LoginService()
        {
            // Fetch connection string from App.config
            connectionString = ConfigurationManager.ConnectionStrings["UserManagementUI.Properties.Settings.UserManagementConnectionString"].ConnectionString;
        }

        public static LoginService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new LoginService();
            }
            return _instance;
        }
   
        public void ProcessStateTransition(LoginState currentState, string userName, string passWord, string newPassword = "0", bool checkedState = false)
        {
            switch (currentState)
            {
                case LoginState.LOGIN:
                    ProcessLogin(userName, passWord, checkedState);
                    break;
                case LoginState.RESET_PASSWORD:
                    ProcessPasswordChange(userName, passWord, newPassword);
                    break;
                case LoginState.REGISTER:
                    ProcessUserRegistration(userName, passWord);
                    break;
                default:
                    break;
            }
        }

        // Generates a cryptographic salt for password hashing
        private string GenerateSalt()
        {
            byte[] saltBytes = new byte[16];
            using (var rng = new System.Security.Cryptography.RNGCryptoServiceProvider())
            {
                rng.GetBytes(saltBytes);
            }
            return Convert.ToBase64String(saltBytes);
        }

        // Hashes the password with a provided salt using SHA-256
        private string HashPassword(string password, string salt)
        {
            using (var sha256 = System.Security.Cryptography.SHA256.Create())
            {
                string saltedPassword = password + salt;
                byte[] bytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(saltedPassword));
                return BitConverter.ToString(bytes).Replace("-", "").ToLower();
            }
        }

        
        private void ProcessLogin(string userName, string passWord, bool checkedState)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=UserManagement;Integrated Security=True;";

            // SQL query to retrieve the stored hash and salt for the given username
            string query = "SELECT PasswordHash, Salt FROM UserTable WHERE UserName = @userName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userName", userName);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Retrieves stored hash and salt
                    string storedHash = reader["PasswordHash"].ToString();
                    string storedSalt = reader["Salt"].ToString();
                    string providedPasswordHash = HashPassword(passWord, storedSalt);

                    
                    if (storedHash == providedPasswordHash)
                    {
                        LoginActionResultHandler?.Invoke(UserInputStatus.PROCESS_COMPLETED, userName);

                        // Saves username for "Remember Me" feature if checkedState is true
                        if (checkedState == true)
                        {
                            Settings.Default.RememberMeUserName = userName;
                            Settings.Default.Save();
                        }
                    }
                    else
                    {
                        // Password mismatch
                        LoginActionResultHandler?.Invoke(UserInputStatus.PROCESS_NOT_COMPLETED, userName);
                    }
                }
                else
                {
                    // User not found in the database
                    LoginActionResultHandler?.Invoke(UserInputStatus.PROCESS_NOT_COMPLETED, userName);
                }

                connection.Close();
            }
        }

        
        private void ProcessPasswordChange(string userName, string passWord, string newPassword)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=UserManagement;Integrated Security=True;";

            // SQL query to retrieve the current hash and salt for password verification
            string query = "SELECT PasswordHash, Salt FROM UserTable WHERE UserName = @userName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userName", userName);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Verifies the current password
                    string storedHash = reader["PasswordHash"].ToString();
                    string storedSalt = reader["Salt"].ToString();
                    string providedPasswordHash = HashPassword(passWord, storedSalt);

                    if (storedHash == providedPasswordHash)
                    {
                        // Password matches, proceed to update the password
                        reader.Close();  // Close reader before executing an update query

                        string newSalt = GenerateSalt();
                        string newHashedPassword = HashPassword(newPassword.ToString(), newSalt);
                        string updateQuery = "UPDATE UserTable SET PasswordHash = @newPasswordHash, Salt = @newSalt WHERE UserName = @userName";

                        SqlCommand updateCommand = new SqlCommand(updateQuery, connection);
                        {
                            updateCommand.Parameters.AddWithValue("@newPasswordHash", newHashedPassword);
                            updateCommand.Parameters.AddWithValue("@newSalt", newSalt);
                            updateCommand.Parameters.AddWithValue("@userName", userName);

                            updateCommand.ExecuteNonQuery();  // Update the password and salt
                        }

                        ResetPasswordResultHandler?.Invoke(UserInputStatus.PROCESS_COMPLETED);
                    }
                    else
                    {
                        // Incorrect current password
                        ResetPasswordResultHandler?.Invoke(UserInputStatus.PROCESS_NOT_COMPLETED);
                    }
                }
                else
                {
                    // User not found
                    ResetPasswordResultHandler?.Invoke(UserInputStatus.PROCESS_NOT_COMPLETED);
                }

                connection.Close();
            }
        }

        private void ProcessUserRegistration(string userName, string passWord)
        {
            string connectionString = "Data Source=localhost;Initial Catalog=UserManagement;Integrated Security=True;";

            // SQL query to check if the username already exists
            string query = "SELECT COUNT(*) FROM UserTable WHERE UserName = @userName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@userName", userName);

                connection.Open();
                int userExists = (int)command.ExecuteScalar();

                if (userExists == 0)
                {
                    // Username is available; create and store new user record
                    string salt = GenerateSalt();
                    string passwordHash = HashPassword(passWord, salt);
                    DateTime creationDate = DateTime.Now;
                    string role = userName == "admin" ? "admin" : "user"; // Sets role based on username

                    // Insert new user record into the database
                    string insertQuery = "INSERT INTO UserTable (UserName, PasswordHash, Salt, Role, CreationDate) VALUES (@userName, @passwordHash, @salt, @role, @creationDate)";

                    SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                    {
                        insertCommand.Parameters.AddWithValue("@userName", userName);
                        insertCommand.Parameters.AddWithValue("@passwordHash", passwordHash);
                        insertCommand.Parameters.AddWithValue("@salt", salt);
                        insertCommand.Parameters.AddWithValue("@role", role);
                        insertCommand.Parameters.AddWithValue("@creationDate", creationDate);
                        insertCommand.ExecuteNonQuery();
                    }

                    RegisterActionResultHandler?.Invoke(UserInputStatus.PROCESS_COMPLETED);
                }
                else
                {
                    // Username is taken
                    RegisterActionResultHandler?.Invoke(UserInputStatus.PROCESS_NOT_COMPLETED);
                }

                connection.Close();
            }
        }

    }
}
