namespace UserManagementUI
{
    partial class RegisterView
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
            this.pictureBox_BackGround = new System.Windows.Forms.PictureBox();
            this.label_UserName = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.label_ConfirmPassword = new System.Windows.Forms.Label();
            this.textBox_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.button_Submit = new System.Windows.Forms.Button();
            this.button_Exit = new System.Windows.Forms.Button();
            this.button_ShowHideConf = new System.Windows.Forms.Button();
            this.button_ShowHidePass = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BackGround)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox_BackGround
            // 
            this.pictureBox_BackGround.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_BackGround.Image = global::UserManagementUI.Properties.Resources.pictureBox_BackGround_Image;
            this.pictureBox_BackGround.Location = new System.Drawing.Point(0, 0);
            this.pictureBox_BackGround.Name = "pictureBox_BackGround";
            this.pictureBox_BackGround.Size = new System.Drawing.Size(325, 278);
            this.pictureBox_BackGround.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_BackGround.TabIndex = 11;
            this.pictureBox_BackGround.TabStop = false;
            // 
            // label_UserName
            // 
            this.label_UserName.AutoSize = true;
            this.label_UserName.Location = new System.Drawing.Point(73, 27);
            this.label_UserName.Name = "label_UserName";
            this.label_UserName.Size = new System.Drawing.Size(60, 13);
            this.label_UserName.TabIndex = 17;
            this.label_UserName.Text = "User Name";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.Location = new System.Drawing.Point(76, 43);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(173, 20);
            this.textBox_UserName.TabIndex = 16;
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.Location = new System.Drawing.Point(73, 66);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(53, 13);
            this.label_Password.TabIndex = 19;
            this.label_Password.Text = "Password";
            // 
            // textBox_Password
            // 
            this.textBox_Password.Location = new System.Drawing.Point(76, 82);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(173, 20);
            this.textBox_Password.TabIndex = 18;
            // 
            // label_ConfirmPassword
            // 
            this.label_ConfirmPassword.AutoSize = true;
            this.label_ConfirmPassword.Location = new System.Drawing.Point(73, 105);
            this.label_ConfirmPassword.Name = "label_ConfirmPassword";
            this.label_ConfirmPassword.Size = new System.Drawing.Size(91, 13);
            this.label_ConfirmPassword.TabIndex = 20;
            this.label_ConfirmPassword.Text = "Confirm Password";
            // 
            // textBox_ConfirmPassword
            // 
            this.textBox_ConfirmPassword.Location = new System.Drawing.Point(76, 121);
            this.textBox_ConfirmPassword.Name = "textBox_ConfirmPassword";
            this.textBox_ConfirmPassword.Size = new System.Drawing.Size(173, 20);
            this.textBox_ConfirmPassword.TabIndex = 21;
            // 
            // button_Submit
            // 
            this.button_Submit.BackColor = System.Drawing.SystemColors.Control;
            this.button_Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Submit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_Submit.Location = new System.Drawing.Point(76, 162);
            this.button_Submit.Name = "button_Submit";
            this.button_Submit.Size = new System.Drawing.Size(75, 23);
            this.button_Submit.TabIndex = 22;
            this.button_Submit.Text = "Submit";
            this.button_Submit.UseVisualStyleBackColor = false;
            // 
            // button_Exit
            // 
            this.button_Exit.BackColor = System.Drawing.SystemColors.Control;
            this.button_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Exit.Location = new System.Drawing.Point(174, 162);
            this.button_Exit.Margin = new System.Windows.Forms.Padding(37, 3, 3, 3);
            this.button_Exit.Name = "button_Exit";
            this.button_Exit.Size = new System.Drawing.Size(75, 23);
            this.button_Exit.TabIndex = 23;
            this.button_Exit.Text = "Exit";
            this.button_Exit.UseVisualStyleBackColor = false;
            // 
            // button_ShowHideConf
            // 
            this.button_ShowHideConf.BackColor = System.Drawing.SystemColors.Window;
            this.button_ShowHideConf.BackgroundImage = global::UserManagementUI.Properties.Resources.show;
            this.button_ShowHideConf.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ShowHideConf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowHideConf.ForeColor = System.Drawing.SystemColors.Window;
            this.button_ShowHideConf.Location = new System.Drawing.Point(255, 121);
            this.button_ShowHideConf.Name = "button_ShowHideConf";
            this.button_ShowHideConf.Size = new System.Drawing.Size(23, 20);
            this.button_ShowHideConf.TabIndex = 24;
            this.button_ShowHideConf.UseVisualStyleBackColor = false;
            // 
            // button_ShowHidePass
            // 
            this.button_ShowHidePass.BackColor = System.Drawing.SystemColors.Window;
            this.button_ShowHidePass.BackgroundImage = global::UserManagementUI.Properties.Resources.show;
            this.button_ShowHidePass.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_ShowHidePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ShowHidePass.ForeColor = System.Drawing.SystemColors.Window;
            this.button_ShowHidePass.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button_ShowHidePass.Location = new System.Drawing.Point(255, 82);
            this.button_ShowHidePass.Name = "button_ShowHidePass";
            this.button_ShowHidePass.Size = new System.Drawing.Size(23, 20);
            this.button_ShowHidePass.TabIndex = 25;
            this.button_ShowHidePass.UseVisualStyleBackColor = false;
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LightSteelBlue;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 256);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(325, 22);
            this.statusStrip.TabIndex = 26;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(175, 17);
            this.toolStripStatusLabel.Text = "Welcome to Registration Panel !";
            // 
            // RegisterView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.button_ShowHidePass);
            this.Controls.Add(this.button_ShowHideConf);
            this.Controls.Add(this.button_Submit);
            this.Controls.Add(this.button_Exit);
            this.Controls.Add(this.label_UserName);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.label_ConfirmPassword);
            this.Controls.Add(this.textBox_ConfirmPassword);
            this.Controls.Add(this.pictureBox_BackGround);
            this.Name = "RegisterView";
            this.Size = new System.Drawing.Size(325, 278);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BackGround)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox_BackGround;
        private System.Windows.Forms.Label label_UserName;
        private System.Windows.Forms.TextBox textBox_UserName;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_Password;
        private System.Windows.Forms.Label label_ConfirmPassword;
        private System.Windows.Forms.TextBox textBox_ConfirmPassword;
        private System.Windows.Forms.Button button_Submit;
        private System.Windows.Forms.Button button_Exit;
        private System.Windows.Forms.Button button_ShowHideConf;
        private System.Windows.Forms.Button button_ShowHidePass;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}
