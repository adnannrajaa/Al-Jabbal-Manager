namespace ASDBFramework.Screens.UserScreens.Users.ManageShareholders
{
    partial class AddNewShareholderForm
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
            this.CNICTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneNoTextBox = new System.Windows.Forms.TextBox();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.CurrentBalanceTextBox = new System.Windows.Forms.TextBox();
            this.ShareholderFatherName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ShareholderNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.StartingBalanceTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.AddressLineTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CNICTextBox
            // 
            this.CNICTextBox.Location = new System.Drawing.Point(251, 97);
            this.CNICTextBox.Name = "CNICTextBox";
            this.CNICTextBox.Size = new System.Drawing.Size(210, 22);
            this.CNICTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(247, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 20);
            this.label2.TabIndex = 157;
            this.label2.Text = "NIC";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(23, 149);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(202, 22);
            this.EmailTextBox.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(19, 126);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 20);
            this.label9.TabIndex = 155;
            this.label9.Text = "Email ";
            // 
            // PhoneNoTextBox
            // 
            this.PhoneNoTextBox.Location = new System.Drawing.Point(251, 149);
            this.PhoneNoTextBox.Name = "PhoneNoTextBox";
            this.PhoneNoTextBox.Size = new System.Drawing.Size(210, 22);
            this.PhoneNoTextBox.TabIndex = 6;
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Location = new System.Drawing.Point(1, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(765, 399);
            this.MainPanel.TabIndex = 32;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.StatusComboBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.CurrentBalanceTextBox);
            this.panel1.Controls.Add(this.ShareholderFatherName);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CNICTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PhoneNoTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DOBDateTimePicker);
            this.panel1.Controls.Add(this.GenderComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.ShareholderNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ConfirmPasswordLabel);
            this.panel1.Controls.Add(this.StartingBalanceTextBox);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.ClearButton);
            this.panel1.Controls.Add(this.AddressLineTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 302);
            this.panel1.TabIndex = 27;
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Items.AddRange(new object[] {
            "Active",
            "Leave"});
            this.StatusComboBox.Location = new System.Drawing.Point(493, 250);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(174, 24);
            this.StatusComboBox.TabIndex = 162;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(489, 227);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 163;
            this.label11.Text = "Status";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(489, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(162, 20);
            this.label10.TabIndex = 161;
            this.label10.Text = "Current Balance(Rs.) ";
            // 
            // CurrentBalanceTextBox
            // 
            this.CurrentBalanceTextBox.Location = new System.Drawing.Point(493, 204);
            this.CurrentBalanceTextBox.Name = "CurrentBalanceTextBox";
            this.CurrentBalanceTextBox.Size = new System.Drawing.Size(174, 22);
            this.CurrentBalanceTextBox.TabIndex = 160;
            // 
            // ShareholderFatherName
            // 
            this.ShareholderFatherName.Location = new System.Drawing.Point(349, 43);
            this.ShareholderFatherName.Name = "ShareholderFatherName";
            this.ShareholderFatherName.Size = new System.Drawing.Size(318, 22);
            this.ShareholderFatherName.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(345, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 159;
            this.label5.Text = "Father Name ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(247, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 20);
            this.label8.TabIndex = 153;
            this.label8.Text = "Mobile ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 151;
            this.label7.Text = "Date Of Birth ";
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.CustomFormat = " ";
            this.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(23, 97);
            this.DOBDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(158, 22);
            this.DOBDateTimePicker.TabIndex = 2;
            this.DOBDateTimePicker.ValueChanged += new System.EventHandler(this.DOBDateTimePicker_ValueChanged);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(493, 95);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(174, 24);
            this.GenderComboBox.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(489, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Gender ";
            // 
            // ShareholderNameTextBox
            // 
            this.ShareholderNameTextBox.Location = new System.Drawing.Point(23, 43);
            this.ShareholderNameTextBox.Name = "ShareholderNameTextBox";
            this.ShareholderNameTextBox.Size = new System.Drawing.Size(283, 22);
            this.ShareholderNameTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Shareholder Name ";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(489, 126);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(186, 20);
            this.ConfirmPasswordLabel.TabIndex = 59;
            this.ConfirmPasswordLabel.Text = "Starting Investment(Rs.) ";
            // 
            // StartingBalanceTextBox
            // 
            this.StartingBalanceTextBox.Location = new System.Drawing.Point(493, 149);
            this.StartingBalanceTextBox.Name = "StartingBalanceTextBox";
            this.StartingBalanceTextBox.Size = new System.Drawing.Size(174, 22);
            this.StartingBalanceTextBox.TabIndex = 4;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(132, 269);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(174, 26);
            this.SaveButton.TabIndex = 9;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(312, 269);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(174, 26);
            this.ClearButton.TabIndex = 10;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // AddressLineTextBox
            // 
            this.AddressLineTextBox.Location = new System.Drawing.Point(23, 204);
            this.AddressLineTextBox.Multiline = true;
            this.AddressLineTextBox.Name = "AddressLineTextBox";
            this.AddressLineTextBox.Size = new System.Drawing.Size(438, 49);
            this.AddressLineTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "Address Line";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Add New Shareholder";
            // 
            // AddNewShareholderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 403);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewShareholderForm";
            this.Text = "Shareholder Screen";
            this.Load += new System.EventHandler(this.AddNewShareholderForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox CNICTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhoneNoTextBox;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DOBDateTimePicker;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ShareholderNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox StartingBalanceTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox AddressLineTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ShareholderFatherName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox CurrentBalanceTextBox;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label label11;
    }
}