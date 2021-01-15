namespace ASDBFramework.Screens.UserScreens.Users.UserDeshBoard
{
    partial class AddNewUserForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.LabelUserTypeDescription = new System.Windows.Forms.Label();
            this.UserTypeComboBox = new System.Windows.Forms.ComboBox();
            this.UserTypeLabel = new System.Windows.Forms.Label();
            this.CellNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.PhoneNoTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.DOBDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.GenderComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ConfirmPasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmPasswordTextBox = new System.Windows.Forms.TextBox();
            this.NewPasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.UserNameTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Location = new System.Drawing.Point(0, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(765, 399);
            this.MainPanel.TabIndex = 30;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LabelUserTypeDescription);
            this.panel1.Controls.Add(this.UserTypeComboBox);
            this.panel1.Controls.Add(this.UserTypeLabel);
            this.panel1.Controls.Add(this.CellNoTextBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.EmailTextBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.PhoneNoTextBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.DOBDateTimePicker);
            this.panel1.Controls.Add(this.GenderComboBox);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.LastNameTextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.FirstNameTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.ConfirmPasswordLabel);
            this.panel1.Controls.Add(this.ConfirmPasswordTextBox);
            this.panel1.Controls.Add(this.NewPasswordLabel);
            this.panel1.Controls.Add(this.PasswordTextBox);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.ExitButton);
            this.panel1.Controls.Add(this.UserNameTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(31, 68);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 296);
            this.panel1.TabIndex = 27;
            // 
            // LabelUserTypeDescription
            // 
            this.LabelUserTypeDescription.AutoSize = true;
            this.LabelUserTypeDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelUserTypeDescription.Location = new System.Drawing.Point(505, 43);
            this.LabelUserTypeDescription.Name = "LabelUserTypeDescription";
            this.LabelUserTypeDescription.Size = new System.Drawing.Size(27, 20);
            this.LabelUserTypeDescription.TabIndex = 160;
            this.LabelUserTypeDescription.Text = "nn";
            // 
            // UserTypeComboBox
            // 
            this.UserTypeComboBox.FormattingEnabled = true;
            this.UserTypeComboBox.Location = new System.Drawing.Point(321, 43);
            this.UserTypeComboBox.Name = "UserTypeComboBox";
            this.UserTypeComboBox.Size = new System.Drawing.Size(158, 24);
            this.UserTypeComboBox.TabIndex = 158;
            this.UserTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.UserTypeComboBox_SelectedIndexChanged);
            this.UserTypeComboBox.TextChanged += new System.EventHandler(this.UserTypeComboBox_TextChanged);
            // 
            // UserTypeLabel
            // 
            this.UserTypeLabel.AutoSize = true;
            this.UserTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserTypeLabel.Location = new System.Drawing.Point(317, 22);
            this.UserTypeLabel.Name = "UserTypeLabel";
            this.UserTypeLabel.Size = new System.Drawing.Size(85, 20);
            this.UserTypeLabel.TabIndex = 159;
            this.UserTypeLabel.Text = "User type :";
            // 
            // CellNoTextBox
            // 
            this.CellNoTextBox.Location = new System.Drawing.Point(509, 103);
            this.CellNoTextBox.Name = "CellNoTextBox";
            this.CellNoTextBox.Size = new System.Drawing.Size(158, 22);
            this.CellNoTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(505, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 157;
            this.label2.Text = "Cell no :";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(321, 163);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(158, 22);
            this.EmailTextBox.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(317, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 20);
            this.label9.TabIndex = 155;
            this.label9.Text = "Email :";
            // 
            // PhoneNoTextBox
            // 
            this.PhoneNoTextBox.Location = new System.Drawing.Point(321, 103);
            this.PhoneNoTextBox.Name = "PhoneNoTextBox";
            this.PhoneNoTextBox.Size = new System.Drawing.Size(158, 22);
            this.PhoneNoTextBox.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(317, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 20);
            this.label8.TabIndex = 153;
            this.label8.Text = "Phone no :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(19, 194);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 151;
            this.label7.Text = "Date of birth :";
            // 
            // DOBDateTimePicker
            // 
            this.DOBDateTimePicker.CustomFormat = " ";
            this.DOBDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DOBDateTimePicker.Location = new System.Drawing.Point(23, 219);
            this.DOBDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DOBDateTimePicker.Name = "DOBDateTimePicker";
            this.DOBDateTimePicker.Size = new System.Drawing.Size(158, 22);
            this.DOBDateTimePicker.TabIndex = 3;
            this.DOBDateTimePicker.ValueChanged += new System.EventHandler(this.DOBDateTimePicker_ValueChanged);
            // 
            // GenderComboBox
            // 
            this.GenderComboBox.FormattingEnabled = true;
            this.GenderComboBox.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.GenderComboBox.Location = new System.Drawing.Point(23, 161);
            this.GenderComboBox.Name = "GenderComboBox";
            this.GenderComboBox.Size = new System.Drawing.Size(158, 24);
            this.GenderComboBox.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(19, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 65;
            this.label6.Text = "Gender :";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(23, 103);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(158, 22);
            this.LastNameTextBox.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Last name :";
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(23, 43);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(158, 22);
            this.FirstNameTextBox.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(19, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "First name :";
            // 
            // ConfirmPasswordLabel
            // 
            this.ConfirmPasswordLabel.AutoSize = true;
            this.ConfirmPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConfirmPasswordLabel.Location = new System.Drawing.Point(505, 196);
            this.ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            this.ConfirmPasswordLabel.Size = new System.Drawing.Size(144, 20);
            this.ConfirmPasswordLabel.TabIndex = 59;
            this.ConfirmPasswordLabel.Text = "Confirm password :";
            // 
            // ConfirmPasswordTextBox
            // 
            this.ConfirmPasswordTextBox.Location = new System.Drawing.Point(509, 219);
            this.ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            this.ConfirmPasswordTextBox.PasswordChar = '*';
            this.ConfirmPasswordTextBox.Size = new System.Drawing.Size(158, 22);
            this.ConfirmPasswordTextBox.TabIndex = 10;
            // 
            // NewPasswordLabel
            // 
            this.NewPasswordLabel.AutoSize = true;
            this.NewPasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewPasswordLabel.Location = new System.Drawing.Point(317, 196);
            this.NewPasswordLabel.Name = "NewPasswordLabel";
            this.NewPasswordLabel.Size = new System.Drawing.Size(86, 20);
            this.NewPasswordLabel.TabIndex = 57;
            this.NewPasswordLabel.Text = "Password :";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(321, 219);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.Size = new System.Drawing.Size(158, 22);
            this.PasswordTextBox.TabIndex = 9;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(213, 263);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(130, 26);
            this.SaveButton.TabIndex = 11;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Location = new System.Drawing.Point(349, 263);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(130, 26);
            this.ExitButton.TabIndex = 12;
            this.ExitButton.Text = "Clear";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // UserNameTextBox
            // 
            this.UserNameTextBox.Location = new System.Drawing.Point(509, 163);
            this.UserNameTextBox.Name = "UserNameTextBox";
            this.UserNameTextBox.Size = new System.Drawing.Size(158, 22);
            this.UserNameTextBox.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(505, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "User name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(25, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(189, 31);
            this.label3.TabIndex = 26;
            this.label3.Text = "Add New User";
            // 
            // AddNewUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 403);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewUserForm";
            this.Text = "User Screen";
            this.Load += new System.EventHandler(this.AddNewUserForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ConfirmPasswordLabel;
        private System.Windows.Forms.TextBox ConfirmPasswordTextBox;
        private System.Windows.Forms.Label NewPasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.TextBox UserNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox GenderComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox PhoneNoTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker DOBDateTimePicker;
        private System.Windows.Forms.TextBox CellNoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LabelUserTypeDescription;
        private System.Windows.Forms.ComboBox UserTypeComboBox;
        private System.Windows.Forms.Label UserTypeLabel;
    }
}