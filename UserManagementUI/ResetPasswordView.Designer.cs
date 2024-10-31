namespace UserManagementUI
{
    partial class ResetPasswordView
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
            this.toolStripStatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_Exit = new System.Windows.Forms.Button();
            this.pictureBox_BackGround = new System.Windows.Forms.PictureBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_OldPassword = new System.Windows.Forms.Label();
            this.textBox_OldPassword = new System.Windows.Forms.TextBox();
            this.label_NewPassword = new System.Windows.Forms.Label();
            this.textBox_NewPassword = new System.Windows.Forms.TextBox();
            this.label_ConfirmNewPassword = new System.Windows.Forms.Label();
            this.textBox_ConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.button_ResetPassword = new System.Windows.Forms.Button();
            this.button_ShowHideOldPass = new System.Windows.Forms.Button();
            this.button_ShowHideNewPass = new System.Windows.Forms.Button();
            this.button_ShowHideConfPass = new System.Windows.Forms.Button();
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
            this.toolStripStatus.TabIndex = 8;
            this.toolStripStatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(190, 17);
            this.toolStripStatusLabel.Text = "Welcome to Password Reset Panel!";
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(190, 191);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(38, 3, 3, 3);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(64, 23);
            this.button_Exit.TabIndex = 10;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            // 
            // pictureBox_BackGround
            // 
            this.pictureBox_BackGround.BackgroundImage = global::UserManagementUI.Properties.Resources.pictureBox_BackGround_Image;
            this.pictureBox_BackGround.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_BackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_BackGround.Name = "pictureBox_BackGround";
            this.pictureBox_BackGround.Size = new System.Drawing.Size(325, 256);
            this.pictureBox_BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_BackGround.TabIndex = 12;
            this.pictureBox_BackGround.TabStop = false;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(59, 12);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(60, 13);
            this.label_UserName.TabIndex = 13;
            this.label_UserName.Text = "User Name";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(62, 28);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(192, 20);
            this.textBox_UserName.TabIndex = 14;
            // 
            // label_OldPassword
            // 
            this.label_OldPassword.AutoSize = true;
            this.label_OldPassword.Location = new System.Drawing.Point(59, 51);
            this.label_OldPassword.Name = "label_OldPassword";
            this.label_OldPassword.Size = new System.Drawing.Size(72, 13);
            this.label_OldPassword.TabIndex = 15;
            this.label_OldPassword.Text = "Old Password";
            // 
            // textBox_OldPassword
            // 
            this.textBox_OldPassword.Location = new System.Drawing.Point(62, 67);
            this.textBox_OldPassword.Name = "textBox_OldPassword";
            this.textBox_OldPassword.Size = new System.Drawing.Size(192, 20);
            this.textBox_OldPassword.TabIndex = 16;
            // 
            // label_NewPassword
            // 
            this.label_NewPassword.AutoSize = true;
            this.label_NewPassword.Location = new System.Drawing.Point(59, 90);
            this.label_NewPassword.Name = "label_NewPassword";
            this.label_NewPassword.Size = new System.Drawing.Size(78, 13);
            this.label_NewPassword.TabIndex = 17;
            this.label_NewPassword.Text = "New Password";
            // 
            // textBox_NewPassword
            // 
            this.textBox_NewPassword.Location = new System.Drawing.Point(62, 105);
            this.textBox_NewPassword.Name = "textBox_NewPassword";
            this.textBox_NewPassword.Size = new System.Drawing.Size(192, 20);
            this.textBox_NewPassword.TabIndex = 18;
            // 
            // label_ConfirmNewPassword
            // 
            this.label_ConfirmNewPassword.AutoSize = true;
            this.label_ConfirmNewPassword.Location = new System.Drawing.Point(59, 128);
            this.label_ConfirmNewPassword.Name = "label_ConfirmNewPassword";
            this.label_ConfirmNewPassword.Size = new System.Drawing.Size(116, 13);
            this.label_ConfirmNewPassword.TabIndex = 19;
            this.label_ConfirmNewPassword.Text = "Confirm New Password";
            // 
            // textBox_ConfirmNewPassword
            // 
            this.textBox_ConfirmNewPassword.Location = new System.Drawing.Point(62, 144);
            this.textBox_ConfirmNewPassword.Name = "textBox_ConfirmNewPassword";
            this.textBox_ConfirmNewPassword.Size = new System.Drawing.Size(192, 20);
            this.textBox_ConfirmNewPassword.TabIndex = 20;
            // 
            // button_ResetPassword
            // 
            this.button_ResetPassword.BackColor = System.Drawing.SystemColors.Control;
            this.button_ResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ResetPassword.Location = new System.Drawing.Point(62, 191);
            this.button_ResetPassword.Name = "button_ResetPassword";
            this.button_ResetPassword.Size = new System.Drawing.Size(113, 23);
            this.button_ResetPassword.TabIndex = 21;
            this.button_ResetPassword.Text = "Reset Password";
            this.button_ResetPassword.UseVisualStyleBackColor = false;
            // 
            // button_ShowHideOldPass
            // 
            this.button_ShowHideOldPass.BackColor = System.Drawing.SystemColors.Window;
            this.button_ShowHideOldPass.BackgroundImage = global::UserManagementUI.Properties.Resources.show;
            this.button_ShowHideOldPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ShowHideOldPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowHideOldPass.ForeColor = System.Drawing.SystemColors.Window;
            this.button_ShowHideOldPass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ShowHideOldPass.Location = new System.Drawing.Point(260, 67);
            this.button_ShowHideOldPass.Name = "button_ShowHideOldPass";
            this.button_ShowHideOldPass.Size = new System.Drawing.Size(23, 20);
            this.button_ShowHideOldPass.TabIndex = 26;
            this.button_ShowHideOldPass.UseVisualStyleBackColor = false;
            // 
            // button_ShowHideNewPass
            // 
            this.button_ShowHideNewPass.BackColor = System.Drawing.SystemColors.Window;
            this.button_ShowHideNewPass.BackgroundImage = global::UserManagementUI.Properties.Resources.show;
            this.button_ShowHideNewPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ShowHideNewPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowHideNewPass.ForeColor = System.Drawing.SystemColors.Window;
            this.button_ShowHideNewPass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ShowHideNewPass.Location = new System.Drawing.Point(260, 105);
            this.button_ShowHideNewPass.Name = "button_ShowHideNewPass";
            this.button_ShowHideNewPass.Size = new System.Drawing.Size(23, 20);
            this.button_ShowHideNewPass.TabIndex = 27;
            this.button_ShowHideNewPass.UseVisualStyleBackColor = false;
            // 
            // button_ShowHideConfPass
            // 
            this.button_ShowHideConfPass.BackColor = System.Drawing.SystemColors.Window;
            this.button_ShowHideConfPass.BackgroundImage = global::UserManagementUI.Properties.Resources.show;
            this.button_ShowHideConfPass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ShowHideConfPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowHideConfPass.ForeColor = System.Drawing.SystemColors.Window;
            this.button_ShowHideConfPass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ShowHideConfPass.Location = new System.Drawing.Point(260, 144);
            this.button_ShowHideConfPass.Name = "button_ShowHideConfPass";
            this.button_ShowHideConfPass.Size = new System.Drawing.Size(23, 20);
            this.button_ShowHideConfPass.TabIndex = 28;
            this.button_ShowHideConfPass.UseVisualStyleBackColor = false;
            // 
            // ResetPasswordView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button_ShowHideConfPass);
            this.Controls.Add(this.button_ShowHideNewPass);
            this.Controls.Add(this.button_ShowHideOldPass);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.button_ResetPassword);
            this.Controls.Add(this.textBox_ConfirmNewPassword);
            this.Controls.Add(this.label_ConfirmNewPassword);
            this.Controls.Add(this.textBox_NewPassword);
            this.Controls.Add(this.label_NewPassword);
            this.Controls.Add(this.textBox_OldPassword);
            this.Controls.Add(this.label_OldPassword);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.pictureBox_BackGround);
            this.Controls.Add(this.toolStripStatus);
            this.Name = "ResetPasswordView";
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
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.PictureBox pictureBox_BackGround;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_OldPassword;
        private System.Windows.Forms.TextBox textBox_OldPassword;
        private System.Windows.Forms.Label label_NewPassword;
        private System.Windows.Forms.TextBox textBox_NewPassword;
        private System.Windows.Forms.Label label_ConfirmNewPassword;
        private System.Windows.Forms.TextBox textBox_ConfirmNewPassword;
        private System.Windows.Forms.Button button_ResetPassword;
        private System.Windows.Forms.Button button_ShowHideOldPass;
        private System.Windows.Forms.Button button_ShowHideNewPass;
        private System.Windows.Forms.Button button_ShowHideConfPass;
    }
}
