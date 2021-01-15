namespace ASDBFramework.Screens.UserScreens.Products
{
    partial class StockDetailForm
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
            this.ClearButton = new System.Windows.Forms.Button();
            this.OutOfStockTextBox = new System.Windows.Forms.TextBox();
            this.OutOfStockLabel = new System.Windows.Forms.Label();
            this.QuantityTextBox = new System.Windows.Forms.TextBox();
            this.CostPriceTextBox = new System.Windows.Forms.TextBox();
            this.RetailPriceTextBox = new System.Windows.Forms.TextBox();
            this.StockDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CostPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RetailPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutOfStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddButton = new System.Windows.Forms.Button();
            this.ProductCodeTextBox = new System.Windows.Forms.TextBox();
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.CostPriceLabel = new System.Windows.Forms.Label();
            this.QuantityLabel = new System.Windows.Forms.Label();
            this.RetailPriceLabel = new System.Windows.Forms.Label();
            this.OpeningInventoryButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.StockDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(788, 38);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(68, 30);
            this.ClearButton.TabIndex = 28;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // OutOfStockTextBox
            // 
            this.OutOfStockTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutOfStockTextBox.Location = new System.Drawing.Point(579, 45);
            this.OutOfStockTextBox.Name = "OutOfStockTextBox";
            this.OutOfStockTextBox.Size = new System.Drawing.Size(100, 23);
            this.OutOfStockTextBox.TabIndex = 4;
            // 
            // OutOfStockLabel
            // 
            this.OutOfStockLabel.AutoSize = true;
            this.OutOfStockLabel.Location = new System.Drawing.Point(576, 21);
            this.OutOfStockLabel.Name = "OutOfStockLabel";
            this.OutOfStockLabel.Size = new System.Drawing.Size(81, 16);
            this.OutOfStockLabel.TabIndex = 27;
            this.OutOfStockLabel.Text = "Out Of Stock";
            // 
            // QuantityTextBox
            // 
            this.QuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QuantityTextBox.Location = new System.Drawing.Point(154, 45);
            this.QuantityTextBox.Name = "QuantityTextBox";
            this.QuantityTextBox.Size = new System.Drawing.Size(100, 23);
            this.QuantityTextBox.TabIndex = 1;
            // 
            // CostPriceTextBox
            // 
            this.CostPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostPriceTextBox.Location = new System.Drawing.Point(296, 45);
            this.CostPriceTextBox.Name = "CostPriceTextBox";
            this.CostPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.CostPriceTextBox.TabIndex = 2;
            // 
            // RetailPriceTextBox
            // 
            this.RetailPriceTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RetailPriceTextBox.Location = new System.Drawing.Point(438, 45);
            this.RetailPriceTextBox.Name = "RetailPriceTextBox";
            this.RetailPriceTextBox.Size = new System.Drawing.Size(100, 23);
            this.RetailPriceTextBox.TabIndex = 3;
            // 
            // StockDetailDataGridView
            // 
            this.StockDetailDataGridView.AllowUserToAddRows = false;
            this.StockDetailDataGridView.AllowUserToDeleteRows = false;
            this.StockDetailDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.StockDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StockDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.ProductCode,
            this.ProductDescription,
            this.Quantity,
            this.CostPrice,
            this.RetailPrice,
            this.OutOfStock,
            this.Date});
            this.StockDetailDataGridView.GridColor = System.Drawing.Color.Silver;
            this.StockDetailDataGridView.Location = new System.Drawing.Point(10, 97);
            this.StockDetailDataGridView.Name = "StockDetailDataGridView";
            this.StockDetailDataGridView.ReadOnly = true;
            this.StockDetailDataGridView.Size = new System.Drawing.Size(1009, 512);
            this.StockDetailDataGridView.TabIndex = 21;
            this.StockDetailDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.StockDetailDataGridView_MouseDoubleClick);
            // 
            // SNo
            // 
            this.SNo.HeaderText = "SNo";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 60;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 115;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "Product Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            this.ProductDescription.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // CostPrice
            // 
            this.CostPrice.HeaderText = "Cost Price";
            this.CostPrice.Name = "CostPrice";
            this.CostPrice.ReadOnly = true;
            // 
            // RetailPrice
            // 
            this.RetailPrice.HeaderText = "Retail Price";
            this.RetailPrice.Name = "RetailPrice";
            this.RetailPrice.ReadOnly = true;
            // 
            // OutOfStock
            // 
            this.OutOfStock.HeaderText = "OutOfStock";
            this.OutOfStock.Name = "OutOfStock";
            this.OutOfStock.ReadOnly = true;
            this.OutOfStock.Width = 120;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 170;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(713, 38);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(68, 30);
            this.AddButton.TabIndex = 5;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeTextBox.Location = new System.Drawing.Point(12, 45);
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductCodeTextBox.TabIndex = 0;
            this.ProductCodeTextBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProductCodeTextBox_MouseDoubleClick);
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.AutoSize = true;
            this.ProductCodeLabel.Location = new System.Drawing.Point(9, 21);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(90, 16);
            this.ProductCodeLabel.TabIndex = 14;
            this.ProductCodeLabel.Text = "Product Code";
            // 
            // CostPriceLabel
            // 
            this.CostPriceLabel.AutoSize = true;
            this.CostPriceLabel.Location = new System.Drawing.Point(293, 21);
            this.CostPriceLabel.Name = "CostPriceLabel";
            this.CostPriceLabel.Size = new System.Drawing.Size(69, 16);
            this.CostPriceLabel.TabIndex = 13;
            this.CostPriceLabel.Text = "Cost Price";
            // 
            // QuantityLabel
            // 
            this.QuantityLabel.AutoSize = true;
            this.QuantityLabel.Location = new System.Drawing.Point(151, 21);
            this.QuantityLabel.Name = "QuantityLabel";
            this.QuantityLabel.Size = new System.Drawing.Size(56, 16);
            this.QuantityLabel.TabIndex = 12;
            this.QuantityLabel.Text = "Quantity";
            // 
            // RetailPriceLabel
            // 
            this.RetailPriceLabel.AutoSize = true;
            this.RetailPriceLabel.Location = new System.Drawing.Point(435, 21);
            this.RetailPriceLabel.Name = "RetailPriceLabel";
            this.RetailPriceLabel.Size = new System.Drawing.Size(77, 16);
            this.RetailPriceLabel.TabIndex = 11;
            this.RetailPriceLabel.Text = "Retail Price";
            // 
            // OpeningInventoryButton
            // 
            this.OpeningInventoryButton.Location = new System.Drawing.Point(862, 38);
            this.OpeningInventoryButton.Name = "OpeningInventoryButton";
            this.OpeningInventoryButton.Size = new System.Drawing.Size(157, 30);
            this.OpeningInventoryButton.TabIndex = 29;
            this.OpeningInventoryButton.Text = "Opening Inventory";
            this.OpeningInventoryButton.UseVisualStyleBackColor = true;
            this.OpeningInventoryButton.Click += new System.EventHandler(this.OpeningInventoryButton_Click);
            // 
            // StockDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 675);
            this.Controls.Add(this.OpeningInventoryButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.OutOfStockTextBox);
            this.Controls.Add(this.OutOfStockLabel);
            this.Controls.Add(this.QuantityTextBox);
            this.Controls.Add(this.CostPriceTextBox);
            this.Controls.Add(this.RetailPriceTextBox);
            this.Controls.Add(this.StockDetailDataGridView);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ProductCodeTextBox);
            this.Controls.Add(this.ProductCodeLabel);
            this.Controls.Add(this.CostPriceLabel);
            this.Controls.Add(this.QuantityLabel);
            this.Controls.Add(this.RetailPriceLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StockDetailForm";
            this.Text = "StockDetailForm";
            this.Load += new System.EventHandler(this.StockDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StockDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView StockDetailDataGridView;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox ProductCodeTextBox;
        private System.Windows.Forms.Label ProductCodeLabel;
        private System.Windows.Forms.Label CostPriceLabel;
        private System.Windows.Forms.Label QuantityLabel;
        private System.Windows.Forms.Label RetailPriceLabel;
        private System.Windows.Forms.TextBox RetailPriceTextBox;
        private System.Windows.Forms.TextBox CostPriceTextBox;
        private System.Windows.Forms.TextBox QuantityTextBox;
        private System.Windows.Forms.TextBox OutOfStockTextBox;
        private System.Windows.Forms.Label OutOfStockLabel;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn CostPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn RetailPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutOfStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.Button OpeningInventoryButton;
    }
}