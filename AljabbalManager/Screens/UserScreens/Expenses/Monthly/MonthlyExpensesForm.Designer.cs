namespace ASDBFramework.Screens.UserScreens.Expenses
{
    partial class MonthlyExpensesForm
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
            this.YearTextBox = new System.Windows.Forms.TextBox();
            this.YearLabel = new System.Windows.Forms.Label();
            this.MonthComboBox = new System.Windows.Forms.ComboBox();
            this.MonthLabel = new System.Windows.Forms.Label();
            this.TelephoneBillTextBox = new System.Windows.Forms.TextBox();
            this.PrintButton = new System.Windows.Forms.Button();
            this.MonthlyExpenseDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.BuildingRentTextBox = new System.Windows.Forms.TextBox();
            this.BuildingRentLabel = new System.Windows.Forms.Label();
            this.TelephoneBillLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.InternetChargesLabel = new System.Windows.Forms.Label();
            this.InternetChargesTextBox = new System.Windows.Forms.TextBox();
            this.ElectricityBillLabel = new System.Windows.Forms.Label();
            this.ElectricityBillTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyExpenseDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // YearTextBox
            // 
            this.YearTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearTextBox.Location = new System.Drawing.Point(658, 121);
            this.YearTextBox.Name = "YearTextBox";
            this.YearTextBox.Size = new System.Drawing.Size(84, 22);
            this.YearTextBox.TabIndex = 142;
            // 
            // YearLabel
            // 
            this.YearLabel.AutoSize = true;
            this.YearLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearLabel.Location = new System.Drawing.Point(658, 100);
            this.YearLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.YearLabel.Name = "YearLabel";
            this.YearLabel.Size = new System.Drawing.Size(41, 16);
            this.YearLabel.TabIndex = 141;
            this.YearLabel.Text = "Year";
            // 
            // MonthComboBox
            // 
            this.MonthComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.MonthComboBox.Location = new System.Drawing.Point(550, 119);
            this.MonthComboBox.Name = "MonthComboBox";
            this.MonthComboBox.Size = new System.Drawing.Size(84, 24);
            this.MonthComboBox.TabIndex = 140;
            // 
            // MonthLabel
            // 
            this.MonthLabel.AutoSize = true;
            this.MonthLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthLabel.Location = new System.Drawing.Point(549, 100);
            this.MonthLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(49, 16);
            this.MonthLabel.TabIndex = 139;
            this.MonthLabel.Text = "Month";
            // 
            // TelephoneBillTextBox
            // 
            this.TelephoneBillTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneBillTextBox.Location = new System.Drawing.Point(12, 121);
            this.TelephoneBillTextBox.Name = "TelephoneBillTextBox";
            this.TelephoneBillTextBox.Size = new System.Drawing.Size(106, 22);
            this.TelephoneBillTextBox.TabIndex = 138;
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(688, 158);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(54, 30);
            this.PrintButton.TabIndex = 137;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // MonthlyExpenseDataGridView
            // 
            this.MonthlyExpenseDataGridView.AllowUserToAddRows = false;
            this.MonthlyExpenseDataGridView.AllowUserToDeleteRows = false;
            this.MonthlyExpenseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MonthlyExpenseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.MonthlyExpenseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MonthlyExpenseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.MonthlyExpenseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MonthlyExpenseDataGridView.Location = new System.Drawing.Point(3, 194);
            this.MonthlyExpenseDataGridView.Name = "MonthlyExpenseDataGridView";
            this.MonthlyExpenseDataGridView.ReadOnly = true;
            this.MonthlyExpenseDataGridView.Size = new System.Drawing.Size(752, 309);
            this.MonthlyExpenseDataGridView.TabIndex = 136;
            // 
            // ViewButton
            // 
            this.ViewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ViewButton.Location = new System.Drawing.Point(630, 158);
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
            this.label2.Location = new System.Drawing.Point(153, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(494, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Manage Monthly Expenses";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BuildingRentTextBox
            // 
            this.BuildingRentTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingRentTextBox.Location = new System.Drawing.Point(286, 119);
            this.BuildingRentTextBox.Multiline = true;
            this.BuildingRentTextBox.Name = "BuildingRentTextBox";
            this.BuildingRentTextBox.Size = new System.Drawing.Size(106, 24);
            this.BuildingRentTextBox.TabIndex = 133;
            // 
            // BuildingRentLabel
            // 
            this.BuildingRentLabel.AutoSize = true;
            this.BuildingRentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BuildingRentLabel.Location = new System.Drawing.Point(282, 100);
            this.BuildingRentLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.BuildingRentLabel.Name = "BuildingRentLabel";
            this.BuildingRentLabel.Size = new System.Drawing.Size(100, 16);
            this.BuildingRentLabel.TabIndex = 132;
            this.BuildingRentLabel.Text = "Building Rent";
            this.BuildingRentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TelephoneBillLabel
            // 
            this.TelephoneBillLabel.AutoSize = true;
            this.TelephoneBillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelephoneBillLabel.Location = new System.Drawing.Point(8, 100);
            this.TelephoneBillLabel.Name = "TelephoneBillLabel";
            this.TelephoneBillLabel.Size = new System.Drawing.Size(109, 16);
            this.TelephoneBillLabel.TabIndex = 129;
            this.TelephoneBillLabel.Text = "Telephone Bill";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(568, 158);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(54, 30);
            this.SaveButton.TabIndex = 130;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // InternetChargesLabel
            // 
            this.InternetChargesLabel.AutoSize = true;
            this.InternetChargesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternetChargesLabel.Location = new System.Drawing.Point(413, 100);
            this.InternetChargesLabel.Name = "InternetChargesLabel";
            this.InternetChargesLabel.Size = new System.Drawing.Size(121, 16);
            this.InternetChargesLabel.TabIndex = 125;
            this.InternetChargesLabel.Text = "Internet Charges";
            // 
            // InternetChargesTextBox
            // 
            this.InternetChargesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InternetChargesTextBox.Location = new System.Drawing.Point(417, 121);
            this.InternetChargesTextBox.Name = "InternetChargesTextBox";
            this.InternetChargesTextBox.Size = new System.Drawing.Size(106, 22);
            this.InternetChargesTextBox.TabIndex = 126;
            // 
            // ElectricityBillLabel
            // 
            this.ElectricityBillLabel.AutoSize = true;
            this.ElectricityBillLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElectricityBillLabel.Location = new System.Drawing.Point(149, 100);
            this.ElectricityBillLabel.Name = "ElectricityBillLabel";
            this.ElectricityBillLabel.Size = new System.Drawing.Size(102, 16);
            this.ElectricityBillLabel.TabIndex = 123;
            this.ElectricityBillLabel.Text = "Electricity Bill";
            // 
            // ElectricityBillTextBox
            // 
            this.ElectricityBillTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElectricityBillTextBox.Location = new System.Drawing.Point(152, 121);
            this.ElectricityBillTextBox.Name = "ElectricityBillTextBox";
            this.ElectricityBillTextBox.Size = new System.Drawing.Size(106, 22);
            this.ElectricityBillTextBox.TabIndex = 124;
            // 
            // MonthlyExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 505);
            this.Controls.Add(this.YearTextBox);
            this.Controls.Add(this.YearLabel);
            this.Controls.Add(this.MonthComboBox);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.TelephoneBillTextBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.MonthlyExpenseDataGridView);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.BuildingRentTextBox);
            this.Controls.Add(this.BuildingRentLabel);
            this.Controls.Add(this.TelephoneBillLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.InternetChargesLabel);
            this.Controls.Add(this.InternetChargesTextBox);
            this.Controls.Add(this.ElectricityBillLabel);
            this.Controls.Add(this.ElectricityBillTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MonthlyExpensesForm";
            this.Text = "MonthlyExpensesForm";
            this.Load += new System.EventHandler(this.MonthlyExpensesForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MonthlyExpenseDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.DataGridView MonthlyExpenseDataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox BuildingRentTextBox;
        private System.Windows.Forms.Label BuildingRentLabel;
        private System.Windows.Forms.Label TelephoneBillLabel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Label InternetChargesLabel;
        private System.Windows.Forms.TextBox InternetChargesTextBox;
        private System.Windows.Forms.Label ElectricityBillLabel;
        private System.Windows.Forms.TextBox ElectricityBillTextBox;
        private System.Windows.Forms.TextBox TelephoneBillTextBox;
        private System.Windows.Forms.Label MonthLabel;
        private System.Windows.Forms.ComboBox MonthComboBox;
        private System.Windows.Forms.Label YearLabel;
        private System.Windows.Forms.TextBox YearTextBox;

    }
}