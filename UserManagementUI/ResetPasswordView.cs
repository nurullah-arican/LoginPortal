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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserManagementUI
{
    public partial class ResetPasswordView : UserControl
    {
        public event Action<LoginState> OnExitState;

        public enum StatusMessageType
        {
            UserName,
            OldPassword,
            NewPassword,
            ConfirmPassword
        }

        public ResetPasswordView()
        {
            InitializeComponent();

            LoginService loginService = LoginService.GetInstance();
            loginService.ResetPasswordResultHandler += LoginService_ResetPasswordResultHandler;

            #region PROPERTIES

            // Buttons
            button_Exit.Enabled = true;
            button_ResetPassword.Enabled = false;

            // Textboxes
            textBox_UserName.MaxLength = 15;

            textBox_OldPassword.PasswordChar = '*';
            textBox_OldPassword.MaxLength = 12;
            textBox_OldPassword.Enabled = false;

            textBox_NewPassword.PasswordChar = '*';
            textBox_NewPassword.MaxLength = 12;
            textBox_NewPassword.Enabled = false;

            textBox_ConfirmNewPassword.PasswordChar = '*';
            textBox_ConfirmNewPassword.MaxLength = 12;
            textBox_ConfirmNewPassword.Enabled = false;

            // Labels
            label_UserName.Parent = pictureBox_BackGround;
            label_UserName.BackColor = Color.Transparent;

            label_OldPassword.Parent = pictureBox_BackGround;
            label_OldPassword.BackColor = Color.Transparent;

            label_NewPassword.Parent = pictureBox_BackGround;
            label_NewPassword.BackColor = Color.Transparent;

            label_ConfirmNewPassword.Parent = pictureBox_BackGround;
            label_ConfirmNewPassword.BackColor = Color.Transparent;

            #endregion

            #region EVENT_DEFINITIONS

            // Buttons
            button_Exit.Click += Button_Exit_Click;
            button_ResetPassword.Click += Button_ResetPassword_Click;
            button_ShowHideOldPass.Click += Button_ShowHideOldPass_Click;
            button_ShowHideNewPass.Click += Button_ShowHideNewPass_Click;
            button_ShowHideConfPass.Click += Button_ShowHideConfPass_Click;

            // Textboxes
            textBox_UserName.GotFocus += TextBox_UserName_GotFocus;
            textBox_OldPassword.GotFocus += TextBox_OldPassword_GotFocus;
            textBox_NewPassword.GotFocus += TextBox_NewPassword_GotFocus;
            textBox_ConfirmNewPassword.GotFocus += TextBox_ConfirmNewPassword_GotFocus;
            textBox_OldPassword.KeyPress += TextBox_OldPassword_KeyPress;
            textBox_NewPassword.KeyPress += TextBox_NewPassword_KeyPress;
            textBox_ConfirmNewPassword.KeyPress += TextBox_ConfirmNewPassword_KeyPress;
            textBox_UserName.TextChanged += TextBox_UserName_TextChanged;
            textBox_OldPassword.TextChanged += TextBox_OldPassword_TextChanged;
            textBox_NewPassword.TextChanged += TextBox_NewPassword_TextChanged;
            textBox_ConfirmNewPassword.TextChanged += TextBox_ConfirmNewPassword_TextChanged;

            #endregion

        }

        #region INTERNAL_FUNCTIONS

        private void TogglePasswordVisibility(System.Windows.Forms.TextBox textBox, System.Windows.Forms.Button button)
        {
            textBox.PasswordChar = textBox.PasswordChar == '*' ? '\0' : '*';
            button.BackgroundImage = textBox.PasswordChar == '*' ? Resources.show : Resources.hide;
        }

        private void ControlHandleProperty(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private string GetStatusMessage(StatusMessageType statusMessageType)
        {
            switch (statusMessageType)
            {
                case StatusMessageType.UserName:
                    return "Maximum Length is 15!";
                case StatusMessageType.OldPassword:
                    return "Only numbers are allowed and maximum length is 12!";
                case StatusMessageType.NewPassword:
                    return "New Password cannot be the same as the Old Password!";
                case StatusMessageType.ConfirmPassword:
                    return "Confirm Password must match the New Password!";
                default:
                    return "Unknown status!";
            }
        }

        private void UpdateStripStatus(StatusMessageType statusMessageType)
        {
            toolStripStatus.BackColor = Color.Wheat;
            toolStripStatusLabel.Text = GetStatusMessage(statusMessageType);
        }

        #endregion

        #region EVENTS

        private void LoginService_ResetPasswordResultHandler(UserInputStatus userInputStatus)
        {
            toolStripStatus.BackColor = userInputStatus == UserInputStatus.PROCESS_COMPLETED ? Color.Turquoise : Color.LightSalmon;
            toolStripStatusLabel.Text = userInputStatus == UserInputStatus.PROCESS_COMPLETED ? "Password reset has been successfully completed." : "Password reset could not be completed.";
        }

        private void TextBox_ConfirmNewPassword_TextChanged(object sender, EventArgs e)
        {
            button_ResetPassword.Enabled = (textBox_ConfirmNewPassword.Text == textBox_NewPassword.Text) ? true : false;
        }

        private void TextBox_NewPassword_TextChanged(object sender, EventArgs e)
        {
            textBox_ConfirmNewPassword.Enabled = (textBox_NewPassword.TextLength >= 8 && textBox_NewPassword.TextLength <= 12 && textBox_NewPassword.Text != textBox_OldPassword.Text) ? true : false;
        }

        private void TextBox_OldPassword_TextChanged(object sender, EventArgs e)
        {
            textBox_NewPassword.Enabled = (textBox_OldPassword.TextLength >= 8 && textBox_OldPassword.TextLength <= 12) ? true : false;
        }

        private void TextBox_UserName_TextChanged(object sender, EventArgs e)
        {
            textBox_OldPassword.Enabled = string.IsNullOrEmpty(textBox_UserName.Text) == false ? true : false;
        }

        private void TextBox_ConfirmNewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHandleProperty(e);
        }

        private void TextBox_NewPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHandleProperty(e);
        }

        private void TextBox_OldPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            ControlHandleProperty(e);
        }

        private void TextBox_ConfirmNewPassword_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.ConfirmPassword);
        }

        private void TextBox_NewPassword_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.NewPassword);
        }

        private void TextBox_OldPassword_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.OldPassword);
        }

        private void TextBox_UserName_GotFocus(object sender, EventArgs e)
        {
            UpdateStripStatus(StatusMessageType.UserName);
        }

        private void Button_ShowHideConfPass_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(textBox_ConfirmNewPassword, button_ShowHideConfPass);
        }

        private void Button_ShowHideNewPass_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(textBox_NewPassword, button_ShowHideNewPass);
        }

        private void Button_ShowHideOldPass_Click(object sender, EventArgs e)
        {
            TogglePasswordVisibility(textBox_OldPassword, button_ShowHideOldPass);
        }

        private void Button_ResetPassword_Click(object sender, EventArgs e)
        {
            LoginService loginService = LoginService.GetInstance();
            loginService.ProcessStateTransition(LoginState.RESET_PASSWORD, textBox_UserName.Text, textBox_OldPassword.Text, textBox_ConfirmNewPassword.Text);
        }

        private void Button_Exit_Click(object sender, EventArgs e)
        {
            OnExitState?.Invoke(LoginState.LOGIN);
        }

        #endregion

    }
}
