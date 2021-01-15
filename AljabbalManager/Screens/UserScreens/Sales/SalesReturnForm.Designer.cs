namespace ASDBFramework.Screens.UserScreens
{
    partial class SalesReturnForm
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
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CustomerInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerCellTextBox = new System.Windows.Forms.TextBox();
            this.Customer_Name = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DateTimePicker();
            this.DateLabel = new System.Windows.Forms.Label();
            this.InvoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.SaleReturnInvoiceDataGridView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.ResetTextButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CreditLabel = new System.Windows.Forms.Label();
            this.NetAmountLabel = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.PaymentInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.CashPayedTextBox = new System.Windows.Forms.TextBox();
            this.CashRecivedButton = new System.Windows.Forms.Button();
            this.ProductInformationGroupBox = new System.Windows.Forms.GroupBox();
            this.UnitTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.RetailPriceTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.AddToCartButton = new System.Windows.Forms.Button();
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.ProductCodeTextBox = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.ProductDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.TotalSaleLlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TodaySaleGroupBox = new System.Windows.Forms.GroupBox();
            this.TodaySaleReturnDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.CustomerInformationGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleReturnInvoiceDataGridView)).BeginInit();
            this.panel3.SuspendLayout();
            this.PaymentInformationGroupBox.SuspendLayout();
            this.ProductInformationGroupBox.SuspendLayout();
            this.TodaySaleGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodaySaleReturnDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Location = new System.Drawing.Point(18, 106);
            this.QuantityTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(110, 22);
            this.QuantityTextBox.TabIndex = 9;
            this.QuantityTextBox.TextChanged += new System.EventHandler(this.QuantityTextBox_TextChanged);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(240, 162);
            this.ClearButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(125, 22);
            this.ClearButton.TabIndex = 13;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(294, 100);
            this.TotalTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.Size = new System.Drawing.Size(110, 22);
            this.TotalTextBox.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 80);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 16);
            this.label8.TabIndex = 83;
            this.label8.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.CustomerInformationGroupBox);
            this.panel2.Controls.Add(this.SaleReturnInvoiceDataGridView);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.PaymentInformationGroupBox);
            this.panel2.Controls.Add(this.ProductInformationGroupBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1020, 687);
            this.panel2.TabIndex = 185;
            // 
            // CustomerInformationGroupBox
            // 
            this.CustomerInformationGroupBox.Controls.Add(this.label5);
            this.CustomerInformationGroupBox.Controls.Add(this.CustomerCellTextBox);
            this.CustomerInformationGroupBox.Controls.Add(this.Customer_Name);
            this.CustomerInformationGroupBox.Controls.Add(this.Date);
            this.CustomerInformationGroupBox.Controls.Add(this.DateLabel);
            this.CustomerInformationGroupBox.Controls.Add(this.InvoiceNoTextBox);
            this.CustomerInformationGroupBox.Controls.Add(this.label28);
            this.CustomerInformationGroupBox.Controls.Add(this.CustomerNameTextBox);
            this.CustomerInformationGroupBox.Location = new System.Drawing.Point(-5, 6);
            this.CustomerInformationGroupBox.Name = "CustomerInformationGroupBox";
            this.CustomerInformationGroupBox.Size = new System.Drawing.Size(293, 206);
            this.CustomerInformationGroupBox.TabIndex = 183;
            this.CustomerInformationGroupBox.TabStop = false;
            this.CustomerInformationGroupBox.Text = "Customer Information";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 139);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 87;
            this.label5.Text = "Customer Cell No";
            // 
            // CustomerCellTextBox
            // 
            this.CustomerCellTextBox.Location = new System.Drawing.Point(14, 166);
            this.CustomerCellTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CustomerCellTextBox.Name = "CustomerCellTextBox";
            this.CustomerCellTextBox.Size = new System.Drawing.Size(160, 22);
            this.CustomerCellTextBox.TabIndex = 4;
            // 
            // Customer_Name
            // 
            this.Customer_Name.AutoSize = true;
            this.Customer_Name.Location = new System.Drawing.Point(14, 82);
            this.Customer_Name.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.Customer_Name.Name = "Customer_Name";
            this.Customer_Name.Size = new System.Drawing.Size(105, 16);
            this.Customer_Name.TabIndex = 83;
            this.Customer_Name.Text = "Customer Name";
            // 
            // Date
            // 
            this.Date.CustomFormat = "yyyy-MM-dd";
            this.Date.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Date.Location = new System.Drawing.Point(173, 44);
            this.Date.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(111, 22);
            this.Date.TabIndex = 2;
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Location = new System.Drawing.Point(170, 25);
            this.DateLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(37, 16);
            this.DateLabel.TabIndex = 82;
            this.DateLabel.Text = "Date";
            // 
            // InvoiceNoTextBox
            // 
            this.InvoiceNoTextBox.Location = new System.Drawing.Point(14, 44);
            this.InvoiceNoTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.InvoiceNoTextBox.Name = "InvoiceNoTextBox";
            this.InvoiceNoTextBox.Size = new System.Drawing.Size(130, 22);
            this.InvoiceNoTextBox.TabIndex = 0;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(14, 25);
            this.label28.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(72, 16);
            this.label28.TabIndex = 76;
            this.label28.Text = "Invoice No";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(14, 106);
            this.CustomerNameTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(270, 22);
            this.CustomerNameTextBox.TabIndex = 3;
            // 
            // SaleReturnInvoiceDataGridView
            // 
            this.SaleReturnInvoiceDataGridView.AllowUserToAddRows = false;
            this.SaleReturnInvoiceDataGridView.AllowUserToDeleteRows = false;
            this.SaleReturnInvoiceDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.SaleReturnInvoiceDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.SaleReturnInvoiceDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SaleReturnInvoiceDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.SaleReturnInvoiceDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SaleReturnInvoiceDataGridView.Location = new System.Drawing.Point(-5, 218);
            this.SaleReturnInvoiceDataGridView.Name = "SaleReturnInvoiceDataGridView";
            this.SaleReturnInvoiceDataGridView.ReadOnly = true;
            this.SaleReturnInvoiceDataGridView.Size = new System.Drawing.Size(811, 388);
            this.SaleReturnInvoiceDataGridView.TabIndex = 182;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.SaveButton);
            this.panel3.Controls.Add(this.ResetTextButton);
            this.panel3.Controls.Add(this.DeleteButton);
            this.panel3.Controls.Add(this.CreditLabel);
            this.panel3.Controls.Add(this.NetAmountLabel);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Location = new System.Drawing.Point(812, 218);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(197, 388);
            this.panel3.TabIndex = 186;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(11, 286);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(178, 39);
            this.SaveButton.TabIndex = 22;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ResetTextButton
            // 
            this.ResetTextButton.Location = new System.Drawing.Point(11, 326);
            this.ResetTextButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ResetTextButton.Name = "ResetTextButton";
            this.ResetTextButton.Size = new System.Drawing.Size(180, 40);
            this.ResetTextButton.TabIndex = 24;
            this.ResetTextButton.Text = "Reset Text";
            this.ResetTextButton.UseVisualStyleBackColor = true;
            this.ResetTextButton.Click += new System.EventHandler(this.ResetTextButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(11, 11);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(172, 26);
            this.DeleteButton.TabIndex = 21;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CreditLabel
            // 
            this.CreditLabel.AutoSize = true;
            this.CreditLabel.Location = new System.Drawing.Point(108, 92);
            this.CreditLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CreditLabel.Name = "CreditLabel";
            this.CreditLabel.Size = new System.Drawing.Size(15, 16);
            this.CreditLabel.TabIndex = 102;
            this.CreditLabel.Text = "0";
            // 
            // NetAmountLabel
            // 
            this.NetAmountLabel.AutoSize = true;
            this.NetAmountLabel.Location = new System.Drawing.Point(108, 52);
            this.NetAmountLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.NetAmountLabel.Name = "NetAmountLabel";
            this.NetAmountLabel.Size = new System.Drawing.Size(15, 16);
            this.NetAmountLabel.TabIndex = 102;
            this.NetAmountLabel.Text = "0";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(8, 92);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(82, 16);
            this.label20.TabIndex = 18;
            this.label20.Text = "Cash Payed";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(8, 52);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(77, 16);
            this.label21.TabIndex = 16;
            this.label21.Text = "Net Amount";
            // 
            // PaymentInformationGroupBox
            // 
            this.PaymentInformationGroupBox.Controls.Add(this.label17);
            this.PaymentInformationGroupBox.Controls.Add(this.CashPayedTextBox);
            this.PaymentInformationGroupBox.Controls.Add(this.CashRecivedButton);
            this.PaymentInformationGroupBox.Location = new System.Drawing.Point(713, 6);
            this.PaymentInformationGroupBox.Name = "PaymentInformationGroupBox";
            this.PaymentInformationGroupBox.Size = new System.Drawing.Size(296, 206);
            this.PaymentInformationGroupBox.TabIndex = 185;
            this.PaymentInformationGroupBox.TabStop = false;
            this.PaymentInformationGroupBox.Text = "Payment Information";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(9, 26);
            this.label17.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(82, 16);
            this.label17.TabIndex = 127;
            this.label17.Text = "Cash Payed";
            // 
            // CashPayedTextBox
            // 
            this.CashPayedTextBox.Location = new System.Drawing.Point(9, 47);
            this.CashPayedTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CashPayedTextBox.Name = "CashPayedTextBox";
            this.CashPayedTextBox.Size = new System.Drawing.Size(127, 22);
            this.CashPayedTextBox.TabIndex = 17;
            // 
            // CashRecivedButton
            // 
            this.CashRecivedButton.Location = new System.Drawing.Point(156, 44);
            this.CashRecivedButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CashRecivedButton.Name = "CashRecivedButton";
            this.CashRecivedButton.Size = new System.Drawing.Size(127, 25);
            this.CashRecivedButton.TabIndex = 18;
            this.CashRecivedButton.Text = "Cash Payed";
            this.CashRecivedButton.UseVisualStyleBackColor = true;
            this.CashRecivedButton.Click += new System.EventHandler(this.CashRecivedButton_Click);
            // 
            // ProductInformationGroupBox
            // 
            this.ProductInformationGroupBox.Controls.Add(this.QuantityTextBox);
            this.ProductInformationGroupBox.Controls.Add(this.ClearButton);
            this.ProductInformationGroupBox.Controls.Add(this.TotalTextBox);
            this.ProductInformationGroupBox.Controls.Add(this.label8);
            this.ProductInformationGroupBox.Controls.Add(this.UnitTextBox);
            this.ProductInformationGroupBox.Controls.Add(this.label9);
            this.ProductInformationGroupBox.Controls.Add(this.RetailPriceTextBox);
            this.ProductInformationGroupBox.Controls.Add(this.label7);
            this.ProductInformationGroupBox.Controls.Add(this.AddToCartButton);
            this.ProductInformationGroupBox.Controls.Add(this.ProductCodeLabel);
            this.ProductInformationGroupBox.Controls.Add(this.ProductCodeTextBox);
            this.ProductInformationGroupBox.Controls.Add(this.label26);
            this.ProductInformationGroupBox.Controls.Add(this.ProductDescriptionTextBox);
            this.ProductInformationGroupBox.Controls.Add(this.label27);
            this.ProductInformationGroupBox.Location = new System.Drawing.Point(294, 6);
            this.ProductInformationGroupBox.Name = "ProductInformationGroupBox";
            this.ProductInformationGroupBox.Size = new System.Drawing.Size(413, 206);
            this.ProductInformationGroupBox.TabIndex = 184;
            this.ProductInformationGroupBox.TabStop = false;
            this.ProductInformationGroupBox.Text = "Product Information";
            // 
            // UnitTextBox
            // 
            this.UnitTextBox.Location = new System.Drawing.Point(294, 46);
            this.UnitTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UnitTextBox.Name = "UnitTextBox";
            this.UnitTextBox.Size = new System.Drawing.Size(110, 22);
            this.UnitTextBox.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(291, 26);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 16);
            this.label9.TabIndex = 86;
            this.label9.Text = "Unit";
            // 
            // RetailPriceTextBox
            // 
            this.RetailPriceTextBox.Location = new System.Drawing.Point(150, 106);
            this.RetailPriceTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.RetailPriceTextBox.Name = "RetailPriceTextBox";
            this.RetailPriceTextBox.Size = new System.Drawing.Size(110, 22);
            this.RetailPriceTextBox.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 86);
            this.label7.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 16);
            this.label7.TabIndex = 81;
            this.label7.Text = "Retail Price";
            // 
            // AddToCartButton
            // 
            this.AddToCartButton.Location = new System.Drawing.Point(47, 162);
            this.AddToCartButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.AddToCartButton.Name = "AddToCartButton";
            this.AddToCartButton.Size = new System.Drawing.Size(181, 22);
            this.AddToCartButton.TabIndex = 12;
            this.AddToCartButton.Text = "Add To Cart";
            this.AddToCartButton.UseVisualStyleBackColor = true;
            this.AddToCartButton.Click += new System.EventHandler(this.AddToCartButton_Click);
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.AutoSize = true;
            this.ProductCodeLabel.Location = new System.Drawing.Point(15, 26);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(90, 16);
            this.ProductCodeLabel.TabIndex = 97;
            this.ProductCodeLabel.Text = "Product Code";
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeTextBox.Location = new System.Drawing.Point(18, 45);
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(110, 23);
            this.ProductCodeTextBox.TabIndex = 6;
            this.ProductCodeTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductCodeTextBox_KeyDown);
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(15, 86);
            this.label26.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(56, 16);
            this.label26.TabIndex = 70;
            this.label26.Text = "Quantity";
            // 
            // ProductDescriptionTextBox
            // 
            this.ProductDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductDescriptionTextBox.Location = new System.Drawing.Point(150, 45);
            this.ProductDescriptionTextBox.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            this.ProductDescriptionTextBox.Size = new System.Drawing.Size(122, 23);
            this.ProductDescriptionTextBox.TabIndex = 7;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(147, 26);
            this.label27.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(94, 16);
            this.label27.TabIndex = 140;
            this.label27.Text = "Product Name";
            // 
            // TotalSaleLlabel
            // 
            this.TotalSaleLlabel.AutoSize = true;
            this.TotalSaleLlabel.Location = new System.Drawing.Point(122, 482);
            this.TotalSaleLlabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.TotalSaleLlabel.Name = "TotalSaleLlabel";
            this.TotalSaleLlabel.Size = new System.Drawing.Size(15, 16);
            this.TotalSaleLlabel.TabIndex = 149;
            this.TotalSaleLlabel.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 482);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 16);
            this.label4.TabIndex = 148;
            this.label4.Text = "Total Sale Return : ";
            // 
            // TodaySaleGroupBox
            // 
            this.TodaySaleGroupBox.Controls.Add(this.TotalSaleLlabel);
            this.TodaySaleGroupBox.Controls.Add(this.label4);
            this.TodaySaleGroupBox.Controls.Add(this.TodaySaleReturnDataGridView);
            this.TodaySaleGroupBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TodaySaleGroupBox.Location = new System.Drawing.Point(0, 0);
            this.TodaySaleGroupBox.Name = "TodaySaleGroupBox";
            this.TodaySaleGroupBox.Size = new System.Drawing.Size(338, 685);
            this.TodaySaleGroupBox.TabIndex = 0;
            this.TodaySaleGroupBox.TabStop = false;
            this.TodaySaleGroupBox.Text = "Today Sale Return Report";
            // 
            // TodaySaleReturnDataGridView
            // 
            this.TodaySaleReturnDataGridView.AllowUserToAddRows = false;
            this.TodaySaleReturnDataGridView.AllowUserToDeleteRows = false;
            this.TodaySaleReturnDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.TodaySaleReturnDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TodaySaleReturnDataGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.TodaySaleReturnDataGridView.Location = new System.Drawing.Point(3, 18);
            this.TodaySaleReturnDataGridView.Name = "TodaySaleReturnDataGridView";
            this.TodaySaleReturnDataGridView.ReadOnly = true;
            this.TodaySaleReturnDataGridView.Size = new System.Drawing.Size(332, 447);
            this.TodaySaleReturnDataGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TodaySaleGroupBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1030, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 687);
            this.panel1.TabIndex = 184;
            // 
            // SalesReturnForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 687);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReturnForm";
            this.Text = "SalesReturnForm";
            this.Load += new System.EventHandler(this.SalesReturnForm_Load);
            this.panel2.ResumeLayout(false);
            this.CustomerInformationGroupBox.ResumeLayout(false);
            this.CustomerInformationGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SaleReturnInvoiceDataGridView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PaymentInformationGroupBox.ResumeLayout(false);
            this.PaymentInformationGroupBox.PerformLayout();
            this.ProductInformationGroupBox.ResumeLayout(false);
            this.ProductInformationGroupBox.PerformLayout();
            this.TodaySaleGroupBox.ResumeLayout(false);
            this.TodaySaleGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TodaySaleReturnDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox CustomerInformationGroupBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox CustomerCellTextBox;
        private System.Windows.Forms.Label Customer_Name;
        private System.Windows.Forms.DateTimePicker Date;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.TextBox InvoiceNoTextBox;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.DataGridView SaleReturnInvoiceDataGridView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button ResetTextButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label CreditLabel;
        private System.Windows.Forms.Label NetAmountLabel;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox PaymentInformationGroupBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox CashPayedTextBox;
        private System.Windows.Forms.Button CashRecivedButton;
        private System.Windows.Forms.GroupBox ProductInformationGroupBox;
        private System.Windows.Forms.TextBox UnitTextBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox RetailPriceTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button AddToCartButton;
        private System.Windows.Forms.Label ProductCodeLabel;
        private System.Windows.Forms.TextBox ProductCodeTextBox;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox ProductDescriptionTextBox;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label TotalSaleLlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox TodaySaleGroupBox;
        private System.Windows.Forms.DataGridView TodaySaleReturnDataGridView;
        private System.Windows.Forms.Panel panel1;




    }
}