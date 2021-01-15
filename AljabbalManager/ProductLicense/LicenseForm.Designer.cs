namespace ASDBFramework.Screens.UserScreens.ProductLicense
{
    partial class LicenseForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LicenseForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TrialDaysLeftLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ProductKeyLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.ProductKeyMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.EnterLicenseKeyButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(759, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // TrialDaysLeftLabel
            // 
            this.TrialDaysLeftLabel.AutoSize = true;
            this.TrialDaysLeftLabel.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.TrialDaysLeftLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TrialDaysLeftLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.TrialDaysLeftLabel.Location = new System.Drawing.Point(277, 140);
            this.TrialDaysLeftLabel.Name = "TrialDaysLeftLabel";
            this.TrialDaysLeftLabel.Size = new System.Drawing.Size(406, 25);
            this.TrialDaysLeftLabel.TabIndex = 1;
            this.TrialDaysLeftLabel.Text = "You have 30 days left in your trial Period.";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(197, 239);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(49, 17);
            this.NameLabel.TabIndex = 2;
            this.NameLabel.Text = "Name:";
            // 
            // ProductKeyLabel
            // 
            this.ProductKeyLabel.AutoSize = true;
            this.ProductKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductKeyLabel.Location = new System.Drawing.Point(197, 278);
            this.ProductKeyLabel.Name = "ProductKeyLabel";
            this.ProductKeyLabel.Size = new System.Drawing.Size(89, 17);
            this.ProductKeyLabel.TabIndex = 3;
            this.ProductKeyLabel.Text = "Product Key:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(299, 234);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(283, 23);
            this.NameTextBox.TabIndex = 4;
            // 
            // ProductKeyMaskedTextBox
            // 
            this.ProductKeyMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductKeyMaskedTextBox.Location = new System.Drawing.Point(299, 272);
            this.ProductKeyMaskedTextBox.Mask = ">AAAAA-AAAAA-AAAAA-AAAAA-AAAAA";
            this.ProductKeyMaskedTextBox.Name = "ProductKeyMaskedTextBox";
            this.ProductKeyMaskedTextBox.Size = new System.Drawing.Size(283, 23);
            this.ProductKeyMaskedTextBox.TabIndex = 5;
            // 
            // EnterLicenseKeyButton
            // 
            this.EnterLicenseKeyButton.Location = new System.Drawing.Point(175, 322);
            this.EnterLicenseKeyButton.Name = "EnterLicenseKeyButton";
            this.EnterLicenseKeyButton.Size = new System.Drawing.Size(264, 23);
            this.EnterLicenseKeyButton.TabIndex = 6;
            this.EnterLicenseKeyButton.Text = "Enter License Key";
            this.EnterLicenseKeyButton.UseVisualStyleBackColor = true;
            this.EnterLicenseKeyButton.Click += new System.EventHandler(this.EnterLicenseKeyButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(445, 322);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(158, 23);
            this.ExitButton.TabIndex = 7;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // LicenseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(779, 368);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.EnterLicenseKeyButton);
            this.Controls.Add(this.ProductKeyMaskedTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ProductKeyLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TrialDaysLeftLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "LicenseForm";
            this.Text = "License Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LicenseForm_FormClosing);
            this.Load += new System.EventHandler(this.LicenseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TrialDaysLeftLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label ProductKeyLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.MaskedTextBox ProductKeyMaskedTextBox;
        private System.Windows.Forms.Button EnterLicenseKeyButton;
        private System.Windows.Forms.Button ExitButton;
    }
}