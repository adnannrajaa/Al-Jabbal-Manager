namespace ASDBFramework.Screens.UserScreens.Expenses
{
    partial class DailyExpensesForm
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
            this.PrintButton = new System.Windows.Forms.Button();
            this.ViewButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.AdvertismentTextBox = new System.Windows.Forms.TextBox();
            this.AdvertismentLabel = new System.Windows.Forms.Label();
            this.DayComboBox = new System.Windows.Forms.ComboBox();
            this.DayLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.OtherExpensesLabel = new System.Windows.Forms.Label();
            this.OtherExpensesTextBox = new System.Windows.Forms.TextBox();
            this.OfficeExpensesLabel = new System.Windows.Forms.Label();
            this.OfficeExpensesTextBox = new System.Windows.Forms.TextBox();
            this.DailyExpenseDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyExpenseDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(689, 151);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(54, 30);
            this.PrintButton.TabIndex = 137;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(629, 151);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(54, 30);
            this.ViewButton.TabIndex = 135;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(757, 79);
            this.panel1.TabIndex = 134;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(179, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(444, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Daily Expenses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdvertismentTextBox
            // 
            this.AdvertismentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvertismentTextBox.Location = new System.Drawing.Point(208, 110);
            this.AdvertismentTextBox.Multiline = true;
            this.AdvertismentTextBox.Name = "AdvertismentTextBox";
            this.AdvertismentTextBox.Size = new System.Drawing.Size(117, 24);
            this.AdvertismentTextBox.TabIndex = 133;
            // 
            // AdvertismentLabel
            // 
            this.AdvertismentLabel.AutoSize = true;
            this.AdvertismentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdvertismentLabel.Location = new System.Drawing.Point(205, 91);
            this.AdvertismentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.AdvertismentLabel.Name = "AdvertismentLabel";
            this.AdvertismentLabel.Size = new System.Drawing.Size(107, 16);
            this.AdvertismentLabel.TabIndex = 132;
            this.AdvertismentLabel.Text = "Advertisement";
            // 
            // DayComboBox
            // 
            this.DayComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayComboBox.FormattingEnabled = true;
            this.DayComboBox.Items.AddRange(new object[] {
            "Monday",
            "Tuesday",
            "Wenesday",
            "Thursday",
            "Friday",
            "Saturday",
            "Sunday"});
            this.DayComboBox.Location = new System.Drawing.Point(589, 110);
            this.DayComboBox.Name = "DayComboBox";
            this.DayComboBox.Size = new System.Drawing.Size(153, 24);
            this.DayComboBox.TabIndex = 131;
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayLabel.Location = new System.Drawing.Point(587, 91);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(36, 16);
            this.DayLabel.TabIndex = 129;
            this.DayLabel.Text = "Day";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(569, 151);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(54, 30);
            this.SaveButton.TabIndex = 130;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // OtherExpensesLabel
            // 
            this.OtherExpensesLabel.AutoSize = true;
            this.OtherExpensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherExpensesLabel.Location = new System.Drawing.Point(395, 93);
            this.OtherExpensesLabel.Name = "OtherExpensesLabel";
            this.OtherExpensesLabel.Size = new System.Drawing.Size(117, 16);
            this.OtherExpensesLabel.TabIndex = 125;
            this.OtherExpensesLabel.Text = "Other Expenses";
            // 
            // OtherExpensesTextBox
            // 
            this.OtherExpensesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OtherExpensesTextBox.Location = new System.Drawing.Point(398, 112);
            this.OtherExpensesTextBox.Name = "OtherExpensesTextBox";
            this.OtherExpensesTextBox.Size = new System.Drawing.Size(118, 22);
            this.OtherExpensesTextBox.TabIndex = 126;
            // 
            // OfficeExpensesLabel
            // 
            this.OfficeExpensesLabel.AutoSize = true;
            this.OfficeExpensesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficeExpensesLabel.Location = new System.Drawing.Point(14, 91);
            this.OfficeExpensesLabel.Name = "OfficeExpensesLabel";
            this.OfficeExpensesLabel.Size = new System.Drawing.Size(120, 16);
            this.OfficeExpensesLabel.TabIndex = 123;
            this.OfficeExpensesLabel.Text = "Office Expenses";
            // 
            // OfficeExpensesTextBox
            // 
            this.OfficeExpensesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OfficeExpensesTextBox.Location = new System.Drawing.Point(17, 112);
            this.OfficeExpensesTextBox.Name = "OfficeExpensesTextBox";
            this.OfficeExpensesTextBox.Size = new System.Drawing.Size(118, 22);
            this.OfficeExpensesTextBox.TabIndex = 124;
            // 
            // DailyExpenseDataGridView
            // 
            this.DailyExpenseDataGridView.AllowUserToAddRows = false;
            this.DailyExpenseDataGridView.AllowUserToDeleteRows = false;
            this.DailyExpenseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DailyExpenseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DailyExpenseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DailyExpenseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DailyExpenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DailyExpenseDataGridView.Location = new System.Drawing.Point(3, 187);
            this.DailyExpenseDataGridView.Name = "DailyExpenseDataGridView";
            this.DailyExpenseDataGridView.ReadOnly = true;
            this.DailyExpenseDataGridView.Size = new System.Drawing.Size(752, 317);
            this.DailyExpenseDataGridView.TabIndex = 138;
            // 
            // DailyExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 505);
            this.Controls.Add(this.DailyExpenseDataGridView);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.AdvertismentTextBox);
            this.Controls.Add(this.AdvertismentLabel);
            this.Controls.Add(this.DayComboBox);
            this.Controls.Add(this.DayLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.OtherExpensesLabel);
            this.Controls.Add(this.OtherExpensesTextBox);
            this.Controls.Add(this.OfficeExpensesLabel);
            this.Controls.Add(this.OfficeExpensesTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DailyExpensesForm";
            this.Text = "DailyExpensesForm";
            this.Load += new System.EventHandler(this.DailyExpensesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DailyExpenseDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox AdvertismentTextBox;
        private System.Windows.Forms.Label AdvertismentLabel;
        private System.Windows.Forms.ComboBox DayComboBox;
        private System.Windows.Forms.Label DayLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label OtherExpensesLabel;
        private System.Windows.Forms.TextBox OtherExpensesTextBox;
        private System.Windows.Forms.Label OfficeExpensesLabel;
        private System.Windows.Forms.TextBox OfficeExpensesTextBox;
        private System.Windows.Forms.DataGridView DailyExpenseDataGridView;


    }
}