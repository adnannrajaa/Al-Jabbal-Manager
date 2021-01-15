namespace ASDBFramework.Screens.UserScreens.Expenses
{
    partial class WagesForm
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
            this.SaleriesDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.EmployeeNameComboBox = new System.Windows.Forms.ComboBox();
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.CurrentSalaryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SaleriesDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SaleriesDataGridView
            // 
            this.SaleriesDataGridView.AllowUserToAddRows = false;
            this.SaleriesDataGridView.AllowUserToDeleteRows = false;
            this.SaleriesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SaleriesDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SaleriesDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleriesDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SaleriesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleriesDataGridView.Location = new System.Drawing.Point(3, 175);
            this.SaleriesDataGridView.Name = "SaleriesDataGridView";
            this.SaleriesDataGridView.ReadOnly = true;
            this.SaleriesDataGridView.Size = new System.Drawing.Size(588, 270);
            this.SaleriesDataGridView.TabIndex = 149;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(506, 142);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(63, 24);
            this.ViewButton.TabIndex = 148;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(146, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Saleries";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(9, 87);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(110, 16);
            this.NameLabel.TabIndex = 147;
            this.NameLabel.Text = "Employee Name";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 79);
            this.panel1.TabIndex = 146;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(506, 103);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 24);
            this.SaveButton.TabIndex = 145;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Location = new System.Drawing.Point(241, 147);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(118, 22);
            this.TotalAmountTextBox.TabIndex = 143;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(241, 128);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(78, 16);
            this.TotalAmountLabel.TabIndex = 142;
            this.TotalAmountLabel.Text = "Salary Paid";
            // 
            // EmployeeNameComboBox
            // 
            this.EmployeeNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameComboBox.FormattingEnabled = true;
            this.EmployeeNameComboBox.Location = new System.Drawing.Point(12, 103);
            this.EmployeeNameComboBox.Name = "EmployeeNameComboBox";
            this.EmployeeNameComboBox.Size = new System.Drawing.Size(211, 24);
            this.EmployeeNameComboBox.TabIndex = 140;
            this.EmployeeNameComboBox.SelectedIndexChanged += new System.EventHandler(this.EmployeeNameComboBox_SelectedIndexChanged);
            this.EmployeeNameComboBox.TextChanged += new System.EventHandler(this.EmployeeNameComboBox_TextChanged);
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.Location = new System.Drawing.Point(380, 103);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(106, 22);
            this.YearTextBox.TabIndex = 153;
            // 
            // CurrentSalaryTextBox
            // 
            this.CurrentSalaryTextBox.Location = new System.Drawing.Point(241, 103);
            this.CurrentSalaryTextBox.Name = "CurrentSalaryTextBox";
            this.CurrentSalaryTextBox.Size = new System.Drawing.Size(118, 22);
            this.CurrentSalaryTextBox.TabIndex = 155;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 154;
            this.label1.Text = "Current Salary";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthComboBox.FormattingEnabled = true;
            this.MonthComboBox.Items.AddRange(new object[] {
            "Jan",
            "Feb",
            "Mar",
            "Apirl",
            "May",
            "Jun",
            "Jul",
            "Aug",
            "Sep",
            "Oct",
            "Nov",
            "Dec"});
            this.MonthComboBox.Location = new System.Drawing.Point(380, 145);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(93, 24);
            this.MonthComboBox.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 16);
            this.label2.TabIndex = 157;
            this.label2.Text = "Year";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(377, 128);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 158;
            this.label4.Text = "Month";
            // 
            // WagesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 448);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.CurrentSalaryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.SaleriesDataGridView);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.EmployeeNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WagesForm";
            this.Text = "WagesForm";
            this.Load += new System.EventHandler(this.WagesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SaleriesDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SaleriesDataGridView;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.ComboBox EmployeeNameComboBox;
        private System.Windows.Forms.TextBox YearTextBox;
        private System.Windows.Forms.TextBox CurrentSalaryTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}