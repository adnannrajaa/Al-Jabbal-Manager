namespace ASDBFramework.Screens.UserScreens.Products.ViewProducts
{
    partial class ViewAllProductsForm
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
            this.G_View_All_Products = new System.Windows.Forms.GroupBox();
            this.AllProductsDataGridView = new System.Windows.Forms.DataGridView();
            this.PID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ShortageLimit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UpdatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.G_View_All_Products.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // G_View_All_Products
            // 
            this.G_View_All_Products.Controls.Add(this.AllProductsDataGridView);
            this.G_View_All_Products.Dock = System.Windows.Forms.DockStyle.Fill;
            this.G_View_All_Products.Location = new System.Drawing.Point(0, 0);
            this.G_View_All_Products.Name = "G_View_All_Products";
            this.G_View_All_Products.Size = new System.Drawing.Size(1029, 622);
            this.G_View_All_Products.TabIndex = 3;
            this.G_View_All_Products.TabStop = false;
            this.G_View_All_Products.Text = "View All Products";
          
            // 
            // AllProductsDataGridView
            // 
            this.AllProductsDataGridView.AllowUserToAddRows = false;
            this.AllProductsDataGridView.AllowUserToDeleteRows = false;
            this.AllProductsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.AllProductsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AllProductsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PID,
            this.ProductDescription,
            this.Unit,
            this.Quantity,
            this.Price,
            this.ShortageLimit,
            this.UpdatedDate});
            this.AllProductsDataGridView.Location = new System.Drawing.Point(5, 21);
            this.AllProductsDataGridView.Name = "AllProductsDataGridView";
            this.AllProductsDataGridView.ReadOnly = true;
            this.AllProductsDataGridView.Size = new System.Drawing.Size(1018, 596);
            this.AllProductsDataGridView.TabIndex = 0;
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
            // ViewAllProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 622);
            this.Controls.Add(this.G_View_All_Products);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewAllProductsForm";
            this.Text = "ViewAllProductsForm";
            this.Load += new System.EventHandler(this.ViewAllProductsForm_Load);
            this.G_View_All_Products.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AllProductsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox G_View_All_Products;
        private System.Windows.Forms.DataGridView AllProductsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn PID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Unit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ShortageLimit;
        private System.Windows.Forms.DataGridViewTextBoxColumn UpdatedDate;
    }
}