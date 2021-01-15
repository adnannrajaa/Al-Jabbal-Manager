namespace ASDBFramework.Screens
{
    partial class NotificationForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.MessagesAboutCompanyGroupBox = new System.Windows.Forms.GroupBox();
            this.CompanyPayableDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NetAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountPayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MessagesAboutCustomersGroupBox = new System.Windows.Forms.GroupBox();
            this.CustomerDebitorDataGridView = new System.Windows.Forms.DataGridView();
            this.InvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PhoneNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuePament = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DuePaymentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MessagesAboutStockPanel = new System.Windows.Forms.Panel();
            this.ProductsMessagesGroupBox = new System.Windows.Forms.GroupBox();
            this.ShortProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ResetButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.MessagesAboutCompanyGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompanyPayableDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.MessagesAboutCustomersGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDebitorDataGridView)).BeginInit();
            this.MessagesAboutStockPanel.SuspendLayout();
            this.ProductsMessagesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ShortProductsDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.MessagesAboutCompanyGroupBox);
            this.panel2.Location = new System.Drawing.Point(12, 355);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(932, 326);
            this.panel2.TabIndex = 5;
            // 
            // MessagesAboutCompanyGroupBox
            // 
            this.MessagesAboutCompanyGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesAboutCompanyGroupBox.Controls.Add(this.CompanyPayableDataGridView);
            this.MessagesAboutCompanyGroupBox.Location = new System.Drawing.Point(3, 3);
            this.MessagesAboutCompanyGroupBox.Name = "MessagesAboutCompanyGroupBox";
            this.MessagesAboutCompanyGroupBox.Size = new System.Drawing.Size(922, 316);
            this.MessagesAboutCompanyGroupBox.TabIndex = 2;
            this.MessagesAboutCompanyGroupBox.TabStop = false;
            this.MessagesAboutCompanyGroupBox.Text = "Messages about company";
            // 
            // CompanyPayableDataGridView
            // 
            this.CompanyPayableDataGridView.AllowUserToAddRows = false;
            this.CompanyPayableDataGridView.AllowUserToDeleteRows = false;
            this.CompanyPayableDataGridView.AllowUserToResizeColumns = false;
            this.CompanyPayableDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.CompanyPayableDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.CompanyPayableDataGridView.BackgroundColor = System.Drawing.Color.Magenta;
            this.CompanyPayableDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompanyPayableDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.NetAmount,
            this.AmountPayed,
            this.PurchaseDate,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.CompanyPayableDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyPayableDataGridView.Location = new System.Drawing.Point(3, 18);
            this.CompanyPayableDataGridView.Name = "CompanyPayableDataGridView";
            this.CompanyPayableDataGridView.ReadOnly = true;
            this.CompanyPayableDataGridView.Size = new System.Drawing.Size(916, 295);
            this.CompanyPayableDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "InvoiceNo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 70;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Party Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 130;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Phone No";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // NetAmount
            // 
            this.NetAmount.HeaderText = "Balance";
            this.NetAmount.Name = "NetAmount";
            this.NetAmount.ReadOnly = true;
            // 
            // AmountPayed
            // 
            this.AmountPayed.HeaderText = "CashPayed";
            this.AmountPayed.Name = "AmountPayed";
            this.AmountPayed.ReadOnly = true;
            // 
            // PurchaseDate
            // 
            this.PurchaseDate.HeaderText = "InvoiceDate";
            this.PurchaseDate.Name = "PurchaseDate";
            this.PurchaseDate.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Due Payment";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "DuePaymentDate";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 153;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.MessagesAboutCustomersGroupBox);
            this.panel1.Location = new System.Drawing.Point(715, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(637, 316);
            this.panel1.TabIndex = 4;
            // 
            // MessagesAboutCustomersGroupBox
            // 
            this.MessagesAboutCustomersGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesAboutCustomersGroupBox.Controls.Add(this.CustomerDebitorDataGridView);
            this.MessagesAboutCustomersGroupBox.Location = new System.Drawing.Point(3, 3);
            this.MessagesAboutCustomersGroupBox.Name = "MessagesAboutCustomersGroupBox";
            this.MessagesAboutCustomersGroupBox.Size = new System.Drawing.Size(627, 306);
            this.MessagesAboutCustomersGroupBox.TabIndex = 1;
            this.MessagesAboutCustomersGroupBox.TabStop = false;
            this.MessagesAboutCustomersGroupBox.Text = "Messages about customers";
            // 
            // CustomerDebitorDataGridView
            // 
            this.CustomerDebitorDataGridView.AllowUserToAddRows = false;
            this.CustomerDebitorDataGridView.AllowUserToDeleteRows = false;
            this.CustomerDebitorDataGridView.AllowUserToResizeColumns = false;
            this.CustomerDebitorDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            this.CustomerDebitorDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.CustomerDebitorDataGridView.BackgroundColor = System.Drawing.Color.Crimson;
            this.CustomerDebitorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomerDebitorDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.InvoiceNo,
            this.CustomerName,
            this.PhoneNo,
            this.DuePament,
            this.DuePaymentDate});
            this.CustomerDebitorDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CustomerDebitorDataGridView.Location = new System.Drawing.Point(3, 18);
            this.CustomerDebitorDataGridView.Name = "CustomerDebitorDataGridView";
            this.CustomerDebitorDataGridView.ReadOnly = true;
            this.CustomerDebitorDataGridView.Size = new System.Drawing.Size(621, 285);
            this.CustomerDebitorDataGridView.TabIndex = 3;
            // 
            // InvoiceNo
            // 
            this.InvoiceNo.HeaderText = "InvoiceNo";
            this.InvoiceNo.Name = "InvoiceNo";
            this.InvoiceNo.ReadOnly = true;
            this.InvoiceNo.Width = 70;
            // 
            // CustomerName
            // 
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.ReadOnly = true;
            this.CustomerName.Width = 130;
            // 
            // PhoneNo
            // 
            this.PhoneNo.HeaderText = "Phone No";
            this.PhoneNo.Name = "PhoneNo";
            this.PhoneNo.ReadOnly = true;
            // 
            // DuePament
            // 
            this.DuePament.HeaderText = "Due Payment";
            this.DuePament.Name = "DuePament";
            this.DuePament.ReadOnly = true;
            this.DuePament.Width = 120;
            // 
            // DuePaymentDate
            // 
            this.DuePaymentDate.HeaderText = "DuePaymentDate";
            this.DuePaymentDate.Name = "DuePaymentDate";
            this.DuePaymentDate.ReadOnly = true;
            this.DuePaymentDate.Width = 158;
            // 
            // MessagesAboutStockPanel
            // 
            this.MessagesAboutStockPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.MessagesAboutStockPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MessagesAboutStockPanel.Controls.Add(this.ProductsMessagesGroupBox);
            this.MessagesAboutStockPanel.Location = new System.Drawing.Point(12, 12);
            this.MessagesAboutStockPanel.Name = "MessagesAboutStockPanel";
            this.MessagesAboutStockPanel.Size = new System.Drawing.Size(691, 316);
            this.MessagesAboutStockPanel.TabIndex = 3;
            // 
            // ProductsMessagesGroupBox
            // 
            this.ProductsMessagesGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ProductsMessagesGroupBox.Controls.Add(this.ShortProductsDataGridView);
            this.ProductsMessagesGroupBox.Location = new System.Drawing.Point(4, 0);
            this.ProductsMessagesGroupBox.Name = "ProductsMessagesGroupBox";
            this.ProductsMessagesGroupBox.Size = new System.Drawing.Size(680, 312);
            this.ProductsMessagesGroupBox.TabIndex = 1;
            this.ProductsMessagesGroupBox.TabStop = false;
            this.ProductsMessagesGroupBox.Text = "Messages about stock";
            // 
            // ShortProductsDataGridView
            // 
            this.ShortProductsDataGridView.AllowUserToAddRows = false;
            this.ShortProductsDataGridView.AllowUserToDeleteRows = false;
            this.ShortProductsDataGridView.AllowUserToResizeColumns = false;
            this.ShortProductsDataGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Orange;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            this.ShortProductsDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ShortProductsDataGridView.BackgroundColor = System.Drawing.Color.DimGray;
            this.ShortProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ShortProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.ProductDescription,
            this.Quantity,
            this.ShortageLimit});
            this.ShortProductsDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShortProductsDataGridView.Location = new System.Drawing.Point(3, 18);
            this.ShortProductsDataGridView.Name = "ShortProductsDataGridView";
            this.ShortProductsDataGridView.ReadOnly = true;
            this.ShortProductsDataGridView.Size = new System.Drawing.Size(674, 291);
            this.ShortProductsDataGridView.TabIndex = 2;
            // 
            // PID
            // 
            this.PID.HeaderText = "Product Code";
            this.PID.Name = "PID";
            this.PID.ReadOnly = true;
            this.PID.Width = 130;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "Product Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            this.ProductDescription.Width = 262;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 120;
            // 
            // ShortageLimit
            // 
            this.ShortageLimit.HeaderText = "Shortage Limit";
            this.ShortageLimit.Name = "ShortageLimit";
            this.ShortageLimit.ReadOnly = true;
            this.ShortageLimit.Width = 120;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Location = new System.Drawing.Point(960, 355);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(392, 326);
            this.panel3.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ResetButton);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(382, 316);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Backup And Recovery";
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(6, 35);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(370, 28);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Load Default Setting";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // NotificationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 693);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MessagesAboutStockPanel);
            this.MaximizeBox = true;
            this.Name = "NotificationForm";
            this.Text = "Important Messages";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.NotificationForm_Load);
            this.panel2.ResumeLayout(false);
            this.MessagesAboutCompanyGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CompanyPayableDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.MessagesAboutCustomersGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomerDebitorDataGridView)).EndInit();
            this.MessagesAboutStockPanel.ResumeLayout(false);
            this.ProductsMessagesGroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ShortProductsDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox MessagesAboutCustomersGroupBox;
        private System.Windows.Forms.GroupBox MessagesAboutCompanyGroupBox;
        private System.Windows.Forms.Panel MessagesAboutStockPanel;
        private System.Windows.Forms.GroupBox ProductsMessagesGroupBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView ShortProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageLimit;
        private System.Windows.Forms.DataGridView CustomerDebitorDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn InvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PhoneNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuePament;
        private System.Windows.Forms.DataGridViewTextBoxColumn DuePaymentDate;
        private System.Windows.Forms.DataGridView CompanyPayableDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn NetAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountPayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.Button ResetButton;
    }
}