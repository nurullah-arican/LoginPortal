# User Management UI - LoginPortal

This project is a user management interface designed to handle basic operations like user login, registration, and password reset. Users can configure their own databases by editing the connection settings in the configuration file, making it adaptable to various environments.

## Features

- **User Login**: Allows users to log in with their credentials.
- **User Registration**: Enables new users to register with unique credentials.
- **Password Reset**: Provides a password reset feature if users forget their login credentials.
- **"Remember Me" Functionality**: Saves username for quicker login in future sessions if the option is selected.
- **Database Flexibility**: Supports user-specific database configuration through the App.config file.

## Installation

1. **Clone the Repository**:
   ```bash
   git clone https://github.com/yourusername/yourprojectname.git
   ```

2. **Open in Visual Studio**:
   Open the solution file (.sln) in Visual Studio.

3. **Database Configuration**:
   Update the connection string in the `App.config` file to point to your own database. Replace `User ID` and `Password` with your database credentials.

   ```xml
   <connectionStrings>
       <add name="UserDatabase"
            connectionString="Data Source=localhost;Initial Catalog=UserManagement;User ID=YourUserID;Password=YourPassword;"
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```

4. **Build and Run**:
   Build the project and run it in Visual Studio to start the application.

## Usage

- **Logging In**: Enter your username and password to log in. If you are an admin, you will see a message welcoming you to the admin dashboard.
- **Remember Me**: Selecting "Remember Me" will store your username for future sessions.
- **Registering**: Click the "Sign Up" button and fill in the required fields to create a new account.
- **Reset Password**: Use the "Forget Password" link to reset your password if you've forgotten it.

## Configuration Details

### App.config File

The `App.config` file holds the connection string that allows you to configure your database. Adjust this file with your own `DataSource`, `InitialCatalog`, `User ID`, and `Password` as needed. 

Example connection string:

```xml
<connectionStrings>
    <add name="UserDatabase"
         connectionString="Data Source=localhost;Initial Catalog=UserManagement;User ID=YourUserID;Password=YourPassword;"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

## Requirements

- **.NET Framework**: This application requires .NET Framework version (specify version here).
- **SQL Server**: A SQL Server database with a `UserManagement` table structure is expected for this application to function properly.

## Troubleshooting

- **NullReferenceException**: Ensure the `App.config` file contains the correct connection string.
- **Database Connection Issues**: Confirm that the SQL Server instance is accessible and that the `User ID` and `Password` provided in the `App.config` file are correct.

## Contributing

Feel free to fork this repository, make improvements, and submit pull requests. Any contributions to enhance functionality or address bugs are welcome.

## License

This project is licensed under the MIT License.
