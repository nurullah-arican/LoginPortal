namespace UserManagementUI
{
    partial class LoginView
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginView));
            this.toolStripStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox_BackGround = new System.Windows.Forms.PictureBox();
            this.checkBox_RememberMe = new System.Windows.Forms.CheckBox();
            this.button_SignIn = new System.Windows.Forms.Button();
            this.button_SignUp = new System.Windows.Forms.Button();
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.linkLabel_ForgetPassword = new System.Windows.Forms.LinkLabel();
            this.button_ShowHidePass = new System.Windows.Forms.Button();
            this.toolStripStatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BackGround)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripStatus
            // 
            this.toolStripStatus.BackColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripStatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.toolStripStatus.Location = new System.Drawing.Point(0, 256);
            this.toolStripStatus.Name = "toolStripStatus";
            this.toolStripStatus.Size = new System.Drawing.Size(325, 22);
            this.toolStripStatus.TabIndex = 7;
            this.toolStripStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(138, 17);
            this.toolStripStatusLabel.Text = "Welcome to LoginPortal!";
            // 
            // pictureBox_BackGround
            // 
            this.pictureBox_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_BackGround.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_BackGround.Image")));
            this.pictureBox_BackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_BackGround.Name = "pictureBox_BackGround";
            this.pictureBox_BackGround.Size = new System.Drawing.Size(325, 256);
            this.pictureBox_BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_BackGround.TabIndex = 11;
            this.pictureBox_BackGround.TabStop = false;
            // 
            // checkBox_RememberMe
            // 
            this.checkBox_RememberMe.AutoSize = true;
            this.checkBox_RememberMe.BackColor = System.Drawing.SystemColors.Control;
            this.checkBox_RememberMe.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_RememberMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_RememberMe.Location = new System.Drawing.Point(64, 115);
            this.checkBox_RememberMe.Name = "checkBox_RememberMe";
            this.checkBox_RememberMe.Size = new System.Drawing.Size(92, 17);
            this.checkBox_RememberMe.TabIndex = 19;
            this.checkBox_RememberMe.Text = "Remember Me";
            this.checkBox_RememberMe.UseVisualStyleBackColor = false;
            // 
            // button_SignIn
            // 
            this.button_SignIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button_SignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignIn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_SignIn.Location = new System.Drawing.Point(64, 179);
            this.button_SignIn.Name = "button_SignIn";
            this.button_SignIn.Size = new System.Drawing.Size(75, 23);
            this.button_SignIn.TabIndex = 21;
            this.button_SignIn.Text = "Sign In";
            this.button_SignIn.UseVisualStyleBackColor = true;
            // 
            // button_SignUp
            // 
            this.button_SignUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_SignUp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_SignUp.Location = new System.Drawing.Point(182, 179);
            this.button_SignUp.Name = "button_SignUp";
            this.button_SignUp.Size = new System.Drawing.Size(75, 23);
            this.button_SignUp.TabIndex = 22;
            this.button_SignUp.Text = "Sign Up";
            this.button_SignUp.UseVisualStyleBackColor = true;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_UserName.Location = new System.Drawing.Point(61, 28);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(60, 13);
            this.label_UserName.TabIndex = 24;
            this.label_UserName.Text = "User Name";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_UserName.Location = new System.Drawing.Point(64, 44);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(193, 20);
            this.textBox_UserName.TabIndex = 23;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(61, 67);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 26;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Password.Location = new System.Drawing.Point(64, 83);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(193, 20);
            this.textBox_Password.TabIndex = 25;
            // 
            // linkLabel_ForgetPassword
            // 
            this.linkLabel_ForgetPassword.ActiveLinkColor = System.Drawing.SystemColors.HotTrack;
            this.linkLabel_ForgetPassword.AutoSize = true;
            this.linkLabel_ForgetPassword.BackColor = System.Drawing.Color.Transparent;
            this.linkLabel_ForgetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_ForgetPassword.LinkColor = System.Drawing.SystemColors.ControlText;
            this.linkLabel_ForgetPassword.Location = new System.Drawing.Point(162, 119);
            this.linkLabel_ForgetPassword.Name = "linkLabel_ForgetPassword";
            this.linkLabel_ForgetPassword.Size = new System.Drawing.Size(95, 13);
            this.linkLabel_ForgetPassword.TabIndex = 27;
            this.linkLabel_ForgetPassword.TabStop = true;
            this.linkLabel_ForgetPassword.Text = "Forget Password ?";
            // 
            // button_ShowHidePass
            // 
            this.button_ShowHidePass.BackColor = System.Drawing.SystemColors.Window;
            this.button_ShowHidePass.BackgroundImage = global::UserManagementUI.Properties.Resources.show;
            this.button_ShowHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ShowHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowHidePass.ForeColor = System.Drawing.SystemColors.Window;
            this.button_ShowHidePass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ShowHidePass.Location = new System.Drawing.Point(263, 82);
            this.button_ShowHidePass.Name = "button_ShowHidePass";
            this.button_ShowHidePass.Size = new System.Drawing.Size(23, 21);
            this.button_ShowHidePass.TabIndex = 28;
            this.button_ShowHidePass.UseVisualStyleBackColor = false;
            // 
            // LoginView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_ShowHidePass);
            this.Controls.Add(this.linkLabel_ForgetPassword);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.button_SignUp);
            this.Controls.Add(this.button_SignIn);
            this.Controls.Add(this.checkBox_RememberMe);
            this.Controls.Add(this.pictureBox_BackGround);
            this.Controls.Add(this.toolStripStatus);
            this.Name = "LoginView";
            this.Size = new System.Drawing.Size(325, 278);
            this.toolStripStatus.ResumeLayout(false);
            this.toolStripStatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BackGround)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip toolStripStatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.PictureBox pictureBox_BackGround;
        private System.Windows.Forms.CheckBox checkBox_RememberMe;
        private System.Windows.Forms.Button button_SignIn;
        private System.Windows.Forms.Button button_SignUp;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.LinkLabel linkLabel_ForgetPassword;
        private System.Windows.Forms.Button button_ShowHidePass;
    }
}
