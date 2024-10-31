using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace UserManagementUI
{
    public enum UserInputStatus
    {
        PROCESS_COMPLETED,
        PROCESS_NOT_COMPLETED
    }

    public enum LoginState
    {
        INITIAL,
        LOGIN,
        RESET_PASSWORD,
        REGISTER
    }

    public partial class LoginPortal : Form
    {
     
        public LoginPortal()
        {
            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;
            this.FormBorderStyle = FormBorderStyle.FixedSingle; // Fixed form size

            UpdatePanelControlStatus(LoginState.LOGIN);
        }

        public void UpdatePanelControlStatus(LoginState loginState)
        {
            this.Controls.Clear();
            switch (loginState)
            {
                case LoginState.REGISTER:
                    RegisterView registerControl = new RegisterView();
                    registerControl.OnExitState += RegisterControl_OnExitState;
                    registerControl.Dock = DockStyle.Fill;               
                    this.Controls.Add(registerControl);
                    break;
                case LoginState.RESET_PASSWORD:
                    ResetPasswordView resetPasswordControl = new ResetPasswordView();
                    resetPasswordControl.OnExitState += ResetPasswordControl_OnExitState;
                    resetPasswordControl.Dock = DockStyle.Fill;
                    this.Controls.Add(resetPasswordControl);
                    break;
                case LoginState.LOGIN:
                    LoginView loginControl = new LoginView();
                    loginControl.UpdatePanelAction += LoginControl_UpdatePanelAction;
                    loginControl.Dock = DockStyle.Fill;
                    this.Controls.Add(loginControl);
                    break;
            }
        }

        private void ResetPasswordControl_OnExitState(LoginState loginState)
        {
            UpdatePanelControlStatus(loginState);
        }

        private void LoginControl_UpdatePanelAction(LoginState loginState)
        {
            UpdatePanelControlStatus(loginState);
        }

        private void RegisterControl_OnExitState(LoginState loginState)
        {
            UpdatePanelControlStatus(loginState);
        }

    }

}
