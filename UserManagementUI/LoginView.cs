using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserManagementUI.Properties;
using static UserManagementUI.ResetPasswordView;

namespace UserManagementUI
{

    public partial class LoginView : UserControl
    {
        #region ENUM

        public enum StatusMessageType
        {
            UserName,
            Password
        }

        #endregion

        public event Action<LoginState> UpdatePanelAction;

        public LoginView()
        {
            InitializeComponent();

            LoginService loginService = LoginService.GetInstance();
            loginService.LoginActionResultHandler += LoginService_LoginActionResultHandler;

            #region PROPERTIES

            // Buttons
            button_SignIn.Enabled = false;
            button_SignUp.Enabled = true;

            // Textboxes
            textBox_UserName.MaxLength = 15;
            textBox_Password.PasswordChar = '*';
            textBox_Password.MaxLength = 12;
            textBox_Password.Enabled = false;

            // Labels
            linkLabel_ForgetPassword.Parent = pictureBox_BackGround;
            linkLabel_ForgetPassword.BackColor = Color.Transparent;

            label_Password.Parent = pictureBox_BackGround;
            label_Password.BackColor = Color.Transparent;

            label_UserName.Parent = pictureBox_BackGround;
            label_UserName.BackColor = Color.Transparent;

            // Checkboxes
            checkBox_RememberMe.Parent = pictureBox_BackGround;
            checkBox_RememberMe.BackColor = Color.Transparent;

            #endregion

            #region EVENT_DEFINITIONS

            // Buttons
            button_SignIn.Click += Button_SignIn_Click;
            button_SignUp.Click += Button_SignUp_Click;
            button_ShowHidePass.Click += Button_ShowHidePass_Click;

            // Textboxes
            textBox_UserName.GotFocus += TextBox_UserName_GotFocus;
            textBox_Password.GotFocus += TextBox_Password_GotFocus;
            textBox_UserName.TextChanged += TextBox_UserName_TextChanged;
            textBox_Password.KeyPress += TextBox_Password_KeyPress;
            textBox_Password.TextChanged += TextBox_Password_TextChanged;

            // Labels
            linkLabel_ForgetPassword.Click += LinkLabel_ForgetPassword_Click;
            linkLabel_ForgetPassword.MouseEnter += LinkLabel_ForgetPassword_MouseEnter;
            linkLabel_ForgetPassword.MouseLeave += LinkLabel_ForgetPassword_MouseLeave;

            // Load
            this.Load += LoginView_Load;

            #endregion

        }

        #region INTERNAL_FUNCTIONS

        public static Color GetColor(UserInputStatus userInputStatus)
        {
            return userInputStatus == UserInputStatus.PROCESS_COMPLETED ? Color.Turquoise : Color.LightSalmon;
        }

        public void UpdateLoginState(LoginState loginState, string userName = "", string passWord = "0", bool checkedState = false)
        {
            LoginService loginService = LoginService.GetInstance();
            loginService.ProcessStateTransition(loginState, userName, passWord, "0", checkedState);
        }

        public string GetStatusMessage(StatusMessageType statusMessageType)
        {
            switch (statusMessageType)
            {
                case StatusMessageType.UserName:
                    return "Up to 15 characters allowed, any type.";
                case StatusMessageType.Password:
                    return "Only 8-12 digits are allowed.";
                default:
                    return "Unknown status!";
            }
        }

        public void UpdateStripStatus(StatusMessageType statusMessageType)
        {
            toolStripStatus.BackColor = Color.Wheat;
            toolStripStatusLabel.Text = GetStatusMessage(statusMessageType);
        }

        #endregion

        #region EVENTS

        private void LoginService_LoginActionResultHandler(UserInputStatus userInputStatus, string userName)
        {
            toolStripStatus.BackColor = GetColor(userInputStatus);
            if (userInputStatus == UserInputStatus.PROCESS_COMPLETED)
            {
                toolStripStatusLabel.Text = userName == "admin" ? "Welcome back, admin! Time to take charge!" : "Welcome back, " + userName + "! Ready for another great session?";
            }
            else
            {
                toolStripStatusLabel.Text = "Login failed! Please check your credentials and try again.";
            }
        }

        private void LoginView_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Settings.Default.RememberMeUserName))
            {
                textBox_UserName.Text = Settings.Default.RememberMeUserName;
                checkBox_RememberMe.Checked = true;
            }
        }

        private void LinkLabel_ForgetPassword_MouseLeave(object sender, EventArgs e)
        {
            linkLabel_ForgetPassword.LinkColor = SystemColors.ControlText;
        }

        private void LinkLabel_ForgetPassword_MouseEnter(object sender, EventArgs e)
        {
            linkLabel_ForgetPassword.LinkColor = SystemColors.HotTrack;
        }

        private void Button_ShowHidePass_Click(object sender, EventArgs e)
        {
            textBox_Password.PasswordChar = textBox_Password.PasswordChar == '*' ? '\0' : '*';
            button_ShowHidePass.BackgroundImage = textBox_Password.PasswordChar == '*' ? Resources.show : Resources.hide;
        }

        private void TextBox_Password_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.Password);
        }

        private void TextBox_UserName_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.UserName);
        }

        private void LinkLabel_ForgetPassword_Click(object sender, EventArgs e)
        {
            UpdatePanelAction?.Invoke(LoginState.RESET_PASSWORD);
        }

        private void TextBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }      
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            button_SignIn.Enabled = (textBox_Password.TextLength >= 8 && textBox_Password.TextLength <= 12) ? true : false;
        }

        private void TextBox_UserName_TextChanged(object sender, EventArgs e)
        {
            textBox_Password.Enabled = string.IsNullOrEmpty(textBox_UserName.Text) == true ? false : true;
        }

        private void Button_SignUp_Click(object sender, EventArgs e)
        {
            UpdatePanelAction?.Invoke(LoginState.REGISTER);
        }

        private void Button_SignIn_Click(object sender, EventArgs e)
        {
           UpdateLoginState(LoginState.LOGIN, textBox_UserName.Text, textBox_Password.Text, checkBox_RememberMe.Checked);          
        }

        #endregion

    }
}
