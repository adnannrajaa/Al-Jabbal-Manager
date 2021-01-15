namespace ASDBFramework.Screens.UserScreens.Products.ManageToken
{
    partial class ManageTokenForm
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ViewTokenBrandDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.BrandClearButton = new System.Windows.Forms.Button();
            this.BrandAddButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.BrandNameTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.BrandIdTextBox = new System.Windows.Forms.TextBox();
            this.TokenSalePanel = new System.Windows.Forms.Panel();
            this.SaleTokenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaleTokenDataGridView = new System.Windows.Forms.DataGridView();
            this.SaleTokenViewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.SaleTokenSaveButton = new System.Windows.Forms.Button();
            this.SaleTokenAmountTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SaleTokenBrandComboBox = new System.Windows.Forms.ComboBox();
            this.TokenPurchasePanel = new System.Windows.Forms.Panel();
            this.PurchasesTokenDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TokenPurchaseDataGridView = new System.Windows.Forms.DataGridView();
            this.ViewButton = new System.Windows.Forms.Button();
            this.TokenBrandLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TokenBrandComboBox = new System.Windows.Forms.ComboBox();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ViewTokenBrandDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.TokenSalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleTokenDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.TokenPurchasePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TokenPurchaseDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(5, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1016, 143);
            this.panel3.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ViewTokenBrandDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(375, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(634, 133);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "View available Token Brand";
            // 
            // ViewTokenBrandDataGridView
            // 
            this.ViewTokenBrandDataGridView.AllowUserToAddRows = false;
            this.ViewTokenBrandDataGridView.AllowUserToDeleteRows = false;
            this.ViewTokenBrandDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ViewTokenBrandDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ViewTokenBrandDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ViewTokenBrandDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ViewTokenBrandDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ViewTokenBrandDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ViewTokenBrandDataGridView.Location = new System.Drawing.Point(3, 18);
            this.ViewTokenBrandDataGridView.Name = "ViewTokenBrandDataGridView";
            this.ViewTokenBrandDataGridView.ReadOnly = true;
            this.ViewTokenBrandDataGridView.Size = new System.Drawing.Size(628, 112);
            this.ViewTokenBrandDataGridView.TabIndex = 160;
            this.ViewTokenBrandDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ViewTokenBrandDataGridView_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BrandClearButton);
            this.groupBox1.Controls.Add(this.BrandAddButton);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.BrandNameTextBox);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.BrandIdTextBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(369, 133);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Token Brand";
            // 
            // BrandClearButton
            // 
            this.BrandClearButton.Location = new System.Drawing.Point(187, 92);
            this.BrandClearButton.Name = "BrandClearButton";
            this.BrandClearButton.Size = new System.Drawing.Size(130, 22);
            this.BrandClearButton.TabIndex = 162;
            this.BrandClearButton.Text = "Clear";
            this.BrandClearButton.UseVisualStyleBackColor = true;
            this.BrandClearButton.Click += new System.EventHandler(this.BrandClearButton_Click);
            // 
            // BrandAddButton
            // 
            this.BrandAddButton.Location = new System.Drawing.Point(51, 92);
            this.BrandAddButton.Name = "BrandAddButton";
            this.BrandAddButton.Size = new System.Drawing.Size(130, 22);
            this.BrandAddButton.TabIndex = 161;
            this.BrandAddButton.Text = "Add";
            this.BrandAddButton.UseVisualStyleBackColor = true;
            this.BrandAddButton.Click += new System.EventHandler(this.BrandAddButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 16);
            this.label7.TabIndex = 160;
            this.label7.Text = "Brand Name";
            // 
            // BrandNameTextBox
            // 
            this.BrandNameTextBox.Location = new System.Drawing.Point(103, 52);
            this.BrandNameTextBox.Name = "BrandNameTextBox";
            this.BrandNameTextBox.Size = new System.Drawing.Size(179, 22);
            this.BrandNameTextBox.TabIndex = 159;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 16);
            this.label6.TabIndex = 158;
            this.label6.Text = "Brand Id";
            // 
            // BrandIdTextBox
            // 
            this.BrandIdTextBox.Location = new System.Drawing.Point(103, 24);
            this.BrandIdTextBox.Name = "BrandIdTextBox";
            this.BrandIdTextBox.Size = new System.Drawing.Size(138, 22);
            this.BrandIdTextBox.TabIndex = 0;
            // 
            // TokenSalePanel
            // 
            this.TokenSalePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TokenSalePanel.Controls.Add(this.SaleTokenDateTimePicker);
            this.TokenSalePanel.Controls.Add(this.SaleTokenDataGridView);
            this.TokenSalePanel.Controls.Add(this.SaleTokenViewButton);
            this.TokenSalePanel.Controls.Add(this.label1);
            this.TokenSalePanel.Controls.Add(this.panel2);
            this.TokenSalePanel.Controls.Add(this.SaleTokenSaveButton);
            this.TokenSalePanel.Controls.Add(this.SaleTokenAmountTextBox);
            this.TokenSalePanel.Controls.Add(this.label4);
            this.TokenSalePanel.Controls.Add(this.label5);
            this.TokenSalePanel.Controls.Add(this.SaleTokenBrandComboBox);
            this.TokenSalePanel.Location = new System.Drawing.Point(514, 161);
            this.TokenSalePanel.Name = "TokenSalePanel";
            this.TokenSalePanel.Size = new System.Drawing.Size(507, 457);
            this.TokenSalePanel.TabIndex = 1;
            // 
            // SaleTokenDateTimePicker
            // 
            this.SaleTokenDateTimePicker.CustomFormat = " ";
            this.SaleTokenDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SaleTokenDateTimePicker.Location = new System.Drawing.Point(276, 90);
            this.SaleTokenDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaleTokenDateTimePicker.Name = "SaleTokenDateTimePicker";
            this.SaleTokenDateTimePicker.Size = new System.Drawing.Size(118, 22);
            this.SaleTokenDateTimePicker.TabIndex = 160;
            this.SaleTokenDateTimePicker.ValueChanged += new System.EventHandler(this.SaleTokenDateTimePicker_ValueChanged);
            this.SaleTokenDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SaleTokenDateTimePicker_KeyDown);
            // 
            // SaleTokenDataGridView
            // 
            this.SaleTokenDataGridView.AllowUserToAddRows = false;
            this.SaleTokenDataGridView.AllowUserToDeleteRows = false;
            this.SaleTokenDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SaleTokenDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SaleTokenDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleTokenDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SaleTokenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleTokenDataGridView.Location = new System.Drawing.Point(3, 167);
            this.SaleTokenDataGridView.Name = "SaleTokenDataGridView";
            this.SaleTokenDataGridView.ReadOnly = true;
            this.SaleTokenDataGridView.Size = new System.Drawing.Size(497, 283);
            this.SaleTokenDataGridView.TabIndex = 159;
            // 
            // SaleTokenViewButton
            // 
            this.SaleTokenViewButton.Location = new System.Drawing.Point(414, 119);
            this.SaleTokenViewButton.Name = "SaleTokenViewButton";
            this.SaleTokenViewButton.Size = new System.Drawing.Size(63, 23);
            this.SaleTokenViewButton.TabIndex = 158;
            this.SaleTokenViewButton.Text = "View";
            this.SaleTokenViewButton.UseVisualStyleBackColor = true;
            this.SaleTokenViewButton.Click += new System.EventHandler(this.SaleTokenViewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 16);
            this.label1.TabIndex = 157;
            this.label1.Text = "Token Brand";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(503, 79);
            this.panel2.TabIndex = 156;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(142, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 42);
            this.label2.TabIndex = 0;
            this.label2.Text = "Token Sale";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaleTokenSaveButton
            // 
            this.SaleTokenSaveButton.Location = new System.Drawing.Point(414, 89);
            this.SaleTokenSaveButton.Name = "SaleTokenSaveButton";
            this.SaleTokenSaveButton.Size = new System.Drawing.Size(63, 22);
            this.SaleTokenSaveButton.TabIndex = 155;
            this.SaleTokenSaveButton.Text = "Save";
            this.SaleTokenSaveButton.UseVisualStyleBackColor = true;
            this.SaleTokenSaveButton.Click += new System.EventHandler(this.SaleTokenSaveButton_Click);
            // 
            // SaleTokenAmountTextBox
            // 
            this.SaleTokenAmountTextBox.Location = new System.Drawing.Point(276, 120);
            this.SaleTokenAmountTextBox.Name = "SaleTokenAmountTextBox";
            this.SaleTokenAmountTextBox.Size = new System.Drawing.Size(118, 22);
            this.SaleTokenAmountTextBox.TabIndex = 153;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(183, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 16);
            this.label4.TabIndex = 152;
            this.label4.Text = "Total Amount";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 151;
            this.label5.Text = "Date";
            // 
            // SaleTokenBrandComboBox
            // 
            this.SaleTokenBrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaleTokenBrandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaleTokenBrandComboBox.FormattingEnabled = true;
            this.SaleTokenBrandComboBox.Location = new System.Drawing.Point(12, 118);
            this.SaleTokenBrandComboBox.Name = "SaleTokenBrandComboBox";
            this.SaleTokenBrandComboBox.Size = new System.Drawing.Size(154, 24);
            this.SaleTokenBrandComboBox.TabIndex = 150;
            // 
            // TokenPurchasePanel
            // 
            this.TokenPurchasePanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TokenPurchasePanel.Controls.Add(this.PurchasesTokenDateTimePicker);
            this.TokenPurchasePanel.Controls.Add(this.TokenPurchaseDataGridView);
            this.TokenPurchasePanel.Controls.Add(this.ViewButton);
            this.TokenPurchasePanel.Controls.Add(this.TokenBrandLabel);
            this.TokenPurchasePanel.Controls.Add(this.panel1);
            this.TokenPurchasePanel.Controls.Add(this.SaveButton);
            this.TokenPurchasePanel.Controls.Add(this.TotalAmountTextBox);
            this.TokenPurchasePanel.Controls.Add(this.TotalAmountLabel);
            this.TokenPurchasePanel.Controls.Add(this.DateLabel);
            this.TokenPurchasePanel.Controls.Add(this.TokenBrandComboBox);
            this.TokenPurchasePanel.Location = new System.Drawing.Point(5, 161);
            this.TokenPurchasePanel.Name = "TokenPurchasePanel";
            this.TokenPurchasePanel.Size = new System.Drawing.Size(503, 457);
            this.TokenPurchasePanel.TabIndex = 0;
            // 
            // PurchasesTokenDateTimePicker
            // 
            this.PurchasesTokenDateTimePicker.CustomFormat = " ";
            this.PurchasesTokenDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.PurchasesTokenDateTimePicker.Location = new System.Drawing.Point(276, 89);
            this.PurchasesTokenDateTimePicker.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.PurchasesTokenDateTimePicker.Name = "PurchasesTokenDateTimePicker";
            this.PurchasesTokenDateTimePicker.Size = new System.Drawing.Size(118, 22);
            this.PurchasesTokenDateTimePicker.TabIndex = 160;
            this.PurchasesTokenDateTimePicker.ValueChanged += new System.EventHandler(this.PurchasesTokenDateTimePicker_ValueChanged);
            this.PurchasesTokenDateTimePicker.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PurchasesTokenDateTimePicker_KeyDown);
            // 
            // TokenPurchaseDataGridView
            // 
            this.TokenPurchaseDataGridView.AllowUserToAddRows = false;
            this.TokenPurchaseDataGridView.AllowUserToDeleteRows = false;
            this.TokenPurchaseDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.TokenPurchaseDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TokenPurchaseDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TokenPurchaseDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.TokenPurchaseDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TokenPurchaseDataGridView.Location = new System.Drawing.Point(3, 165);
            this.TokenPurchaseDataGridView.Name = "TokenPurchaseDataGridView";
            this.TokenPurchaseDataGridView.ReadOnly = true;
            this.TokenPurchaseDataGridView.Size = new System.Drawing.Size(493, 285);
            this.TokenPurchaseDataGridView.TabIndex = 159;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(414, 119);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(63, 23);
            this.ViewButton.TabIndex = 158;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // TokenBrandLabel
            // 
            this.TokenBrandLabel.AutoSize = true;
            this.TokenBrandLabel.Location = new System.Drawing.Point(9, 95);
            this.TokenBrandLabel.Name = "TokenBrandLabel";
            this.TokenBrandLabel.Size = new System.Drawing.Size(86, 16);
            this.TokenBrandLabel.TabIndex = 157;
            this.TokenBrandLabel.Text = "Token Brand";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(499, 79);
            this.panel1.TabIndex = 156;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(96, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(306, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Token Pruchase";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(414, 89);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 22);
            this.SaveButton.TabIndex = 155;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Location = new System.Drawing.Point(276, 120);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(118, 22);
            this.TotalAmountTextBox.TabIndex = 153;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(183, 126);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(87, 16);
            this.TotalAmountLabel.TabIndex = 152;
            this.TotalAmountLabel.Text = "Total Amount";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(230, 95);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(37, 16);
            this.DateLabel.TabIndex = 151;
            this.DateLabel.Text = "Date";
            // 
            // TokenBrandComboBox
            // 
            this.TokenBrandComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TokenBrandComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TokenBrandComboBox.FormattingEnabled = true;
            this.TokenBrandComboBox.Location = new System.Drawing.Point(12, 118);
            this.TokenBrandComboBox.Name = "TokenBrandComboBox";
            this.TokenBrandComboBox.Size = new System.Drawing.Size(154, 24);
            this.TokenBrandComboBox.TabIndex = 150;
            // 
            // ManageTokenForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 621);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.TokenSalePanel);
            this.Controls.Add(this.TokenPurchasePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageTokenForm";
            this.Text = "ManageTokenForm";
            this.Load += new System.EventHandler(this.ManageTokenForm_Load);
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ViewTokenBrandDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TokenSalePanel.ResumeLayout(false);
            this.TokenSalePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleTokenDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.TokenPurchasePanel.ResumeLayout(false);
            this.TokenPurchasePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TokenPurchaseDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TokenPurchasePanel;
        private System.Windows.Forms.Panel TokenSalePanel;
        private System.Windows.Forms.DataGridView TokenPurchaseDataGridView;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label TokenBrandLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.ComboBox TokenBrandComboBox;
        private System.Windows.Forms.DataGridView SaleTokenDataGridView;
        private System.Windows.Forms.Button SaleTokenViewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SaleTokenSaveButton;
        private System.Windows.Forms.TextBox SaleTokenAmountTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox SaleTokenBrandComboBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView ViewTokenBrandDataGridView;
        private System.Windows.Forms.Button BrandClearButton;
        private System.Windows.Forms.Button BrandAddButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox BrandNameTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox BrandIdTextBox;
        private System.Windows.Forms.DateTimePicker SaleTokenDateTimePicker;
        private System.Windows.Forms.DateTimePicker PurchasesTokenDateTimePicker;
    }
}