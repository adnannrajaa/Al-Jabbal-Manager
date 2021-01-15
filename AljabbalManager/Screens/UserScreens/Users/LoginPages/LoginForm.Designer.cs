namespace ASDBFramework.Screens
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ChangePasswordLinkLabel = new System.Windows.Forms.LinkLabel();
            this.PasswordRecoveryLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ChangePasswordLinkLabel
            // 
            this.ChangePasswordLinkLabel.AutoSize = true;
            this.ChangePasswordLinkLabel.LinkColor = System.Drawing.Color.Maroon;
            this.ChangePasswordLinkLabel.Location = new System.Drawing.Point(99, 390);
            this.ChangePasswordLinkLabel.Name = "ChangePasswordLinkLabel";
            this.ChangePasswordLinkLabel.Size = new System.Drawing.Size(129, 16);
            this.ChangePasswordLinkLabel.TabIndex = 26;
            this.ChangePasswordLinkLabel.TabStop = true;
            this.ChangePasswordLinkLabel.Text = "Change a Password";
            this.ChangePasswordLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.ChangePasswordLinkLabel_LinkClicked);
            // 
            // PasswordRecoveryLinkLabel
            // 
            this.PasswordRecoveryLinkLabel.AutoSize = true;
            this.PasswordRecoveryLinkLabel.LinkColor = System.Drawing.Color.Maroon;
            this.PasswordRecoveryLinkLabel.Location = new System.Drawing.Point(242, 390);
            this.PasswordRecoveryLinkLabel.Name = "PasswordRecoveryLinkLabel";
            this.PasswordRecoveryLinkLabel.Size = new System.Drawing.Size(130, 16);
            this.PasswordRecoveryLinkLabel.TabIndex = 27;
            this.PasswordRecoveryLinkLabel.TabStop = true;
            this.PasswordRecoveryLinkLabel.Text = "Password Recovery";
            // 
            // MainPanel
            // 
            this.MainPanel.Location = new System.Drawing.Point(71, 49);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(542, 336);
            this.MainPanel.TabIndex = 28;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 454);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.PasswordRecoveryLinkLabel);
            this.Controls.Add(this.ChangePasswordLinkLabel);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LoginForm";
            this.ShowInTaskbar = true;
            this.Text = "LoginForm";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel ChangePasswordLinkLabel;
        private System.Windows.Forms.LinkLabel PasswordRecoveryLinkLabel;
        private System.Windows.Forms.Panel MainPanel;


    }
}