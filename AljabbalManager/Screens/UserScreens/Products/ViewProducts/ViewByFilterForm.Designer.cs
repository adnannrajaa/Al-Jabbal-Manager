namespace ASDBFramework.Screens.UserScreens.Products.ViewProducts
{
    partial class ViewByFilterForm
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
            this.FilterProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductCodeTextBox = new System.Windows.Forms.TextBox();
            this.SaleTokenViewButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ProductNameComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.FilterProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // FilterProductsDataGridView
            // 
            this.FilterProductsDataGridView.AllowUserToAddRows = false;
            this.FilterProductsDataGridView.AllowUserToDeleteRows = false;
            this.FilterProductsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.FilterProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FilterProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.ProductDescription,
            this.Unit,
            this.Quantity,
            this.Price,
            this.ShortageLimit,
            this.UpdatedDate});
            this.FilterProductsDataGridView.Location = new System.Drawing.Point(6, 61);
            this.FilterProductsDataGridView.Name = "FilterProductsDataGridView";
            this.FilterProductsDataGridView.ReadOnly = true;
            this.FilterProductsDataGridView.Size = new System.Drawing.Size(1018, 555);
            this.FilterProductsDataGridView.TabIndex = 8;
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
            this.ProductDescription.Width = 250;
            // 
            // Unit
            // 
            this.Unit.HeaderText = "Unit";
            this.Unit.Name = "Unit";
            this.Unit.ReadOnly = true;
            this.Unit.Width = 80;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // ShortageLimit
            // 
            this.ShortageLimit.HeaderText = "Shortage Limit";
            this.ShortageLimit.Name = "ShortageLimit";
            this.ShortageLimit.ReadOnly = true;
            this.ShortageLimit.Width = 120;
            // 
            // UpdatedDate
            // 
            this.UpdatedDate.HeaderText = "Updated Date";
            this.UpdatedDate.Name = "UpdatedDate";
            this.UpdatedDate.ReadOnly = true;
            this.UpdatedDate.Width = 193;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 16);
            this.label3.TabIndex = 165;
            this.label3.Text = "Product Code";
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeTextBox.Location = new System.Drawing.Point(6, 31);
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(112, 23);
            this.ProductCodeTextBox.TabIndex = 166;
            // 
            // SaleTokenViewButton
            // 
            this.SaleTokenViewButton.Location = new System.Drawing.Point(324, 32);
            this.SaleTokenViewButton.Name = "SaleTokenViewButton";
            this.SaleTokenViewButton.Size = new System.Drawing.Size(63, 23);
            this.SaleTokenViewButton.TabIndex = 161;
            this.SaleTokenViewButton.Text = "View";
            this.SaleTokenViewButton.UseVisualStyleBackColor = true;
            this.SaleTokenViewButton.Click += new System.EventHandler(this.SaleTokenViewButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(137, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 160;
            this.label1.Text = "Product Name";
            // 
            // ProductNameComboBox
            // 
            this.ProductNameComboBox.FormattingEnabled = true;
            this.ProductNameComboBox.Location = new System.Drawing.Point(140, 30);
            this.ProductNameComboBox.Name = "ProductNameComboBox";
            this.ProductNameComboBox.Size = new System.Drawing.Size(162, 24);
            this.ProductNameComboBox.TabIndex = 167;
            // 
            // ViewByFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.Controls.Add(this.ProductNameComboBox);
            this.Controls.Add(this.ProductCodeTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SaleTokenViewButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FilterProductsDataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewByFilterForm";
            this.Text = "ViewByFilterForm";
            this.Load += new System.EventHandler(this.ViewByFilterForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilterProductsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FilterProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductCodeTextBox;
        private System.Windows.Forms.Button SaleTokenViewButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ProductNameComboBox;
    }
}