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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace UserManagementUI
{
    public partial class RegisterView : UserControl
    {
        public event Action<LoginState> OnExitState;

        public enum StatusMessageType
        {
            UserName,
            Password,
            ConfirmPassword
        }

        public RegisterView()
        {
            InitializeComponent();

            LoginService loginService = LoginService.GetInstance();
            loginService.RegisterActionResultHandler += LoginService_RegisterActionResultHandler;

            #region PROPERTIES

            // Buttons
            button_Exit.Enabled = true;
            button_Submit.Enabled = false;

            // Textboxes
            textBox_UserName.MaxLength = 15;

            textBox_Password.PasswordChar = '*';
            textBox_Password.MaxLength = 12;
            textBox_Password.Enabled = false;

            textBox_ConfirmPassword.PasswordChar = '*';
            textBox_ConfirmPassword.MaxLength = 12;
            textBox_ConfirmPassword.Enabled = false;

            // Labels
            label_UserName.Parent = pictureBox_BackGround;
            label_UserName.BackColor = Color.Transparent;

            label_Password.Parent = pictureBox_BackGround;
            label_Password.BackColor = Color.Transparent;

            label_ConfirmPassword.Parent = pictureBox_BackGround;
            label_ConfirmPassword.BackColor = Color.Transparent;

            #endregion

            #region EVENT_DEFINITIONS

            // Buttons
            button_Submit.Click += Button_Submit_Click;
            button_Exit.Click += Button_Exit_Click;
            button_ShowHideConf.Click += Button_ShowHideConf_Click;
            button_ShowHidePass.Click += Button_ShowHidePass_Click;

            // Textboxes
            textBox_UserName.GotFocus += TextBox_UserName_GotFocus;
            textBox_Password.GotFocus += TextBox_Password_GotFocus;
            textBox_ConfirmPassword.GotFocus += TextBox_ConfirmPassword_GotFocus;
            textBox_UserName.TextChanged += TextBox_UserName_TextChanged;
            textBox_Password.TextChanged += TextBox_Password_TextChanged;
            textBox_ConfirmPassword.TextChanged += TextBox_ConfirmPassword_TextChanged;
            textBox_Password.KeyPress += TextBox_Password_KeyPress;    
            textBox_ConfirmPassword.KeyPress += TextBox_ConfirmPassword_KeyPress;

            #endregion

        }

        #region INTERNAL_FUNCTIONS

        private void ControlHandleProperty(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TogglePasswordVisibility(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Button button)
        {
            textBox.PasswordChar = textBox.PasswordChar == '*' ? '\0' : '*';
            button.BackgroundImage = textBox.PasswordChar == '*' ? Resources.show : Resources.hide;
        }

        private string GetStatusMessage(StatusMessageType statusMessageType)
        {
            switch (statusMessageType)
            {
                case StatusMessageType.UserName:
                    return "Maximum Length is 15!";
                case StatusMessageType.Password:
                    return "Only numbers are allowed and maximum length is 12!";
                case StatusMessageType.ConfirmPassword:
                    return "Password should be same!";
                default:
                    return "Unknown status!";
            }
        }

        private void UpdateStripStatus(StatusMessageType statusMessageType)
        {
            statusStrip.BackColor = Color.Wheat;
            toolStripStatusLabel.Text = GetStatusMessage(statusMessageType);
        }

        #endregion

        #region EVENTS

        private void LoginService_RegisterActionResultHandler(UserInputStatus userInputStatus)
        {
            statusStrip.BackColor = userInputStatus == UserInputStatus.PROCESS_COMPLETED ? Color.Turquoise : Color.LightSalmon;
            toolStripStatusLabel.Text = userInputStatus == UserInputStatus.PROCESS_COMPLETED ? "User registration has been successfully completed." : "User registration could not be completed.";
        }

        private void TextBox_ConfirmPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHandleProperty(e);
        }

        private void TextBox_ConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            button_Submit.Enabled = (textBox_ConfirmPassword.Text == textBox_Password.Text) ? true : false;
        }

        private void TextBox_Password_TextChanged(object sender, EventArgs e)
        {
            textBox_ConfirmPassword.Enabled = (textBox_Password.TextLength >= 8 && textBox_Password.TextLength <= 12) ? true : false;
        }

        private void TextBox_UserName_TextChanged(object sender, EventArgs e)
        {
            textBox_Password.Enabled = string.IsNullOrEmpty(textBox_UserName.Text) == true ? false : true;
        }

        private void TextBox_Password_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHandleProperty(e);
        }

        private void TextBox_ConfirmPassword_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.ConfirmPassword);
        }

        private void TextBox_Password_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.Password);
        }

        private void TextBox_UserName_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.UserName);
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            OnExitState?.Invoke(LoginState.LOGIN);
        }

        private void Button_Submit_Click(object sender, EventArgs e)
        {
            LoginService loginService = LoginService.GetInstance();
            loginService.ProcessStateTransition(LoginState.REGISTER, textBox_UserName.Text, textBox_Password.Text);
        }

        private void Button_ShowHidePass_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(textBox_Password, button_ShowHidePass);
        }

        private void Button_ShowHideConf_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(textBox_ConfirmPassword, button_ShowHideConf);
        }

        #endregion


    }
}
