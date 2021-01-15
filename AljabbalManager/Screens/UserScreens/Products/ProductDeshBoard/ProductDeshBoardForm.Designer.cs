namespace ASDBFramework.Screens.UserScreens.Products.ProductDeshBoard
{
    partial class ProductDeshBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductDeshBoardForm));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ManagePurchasesToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.productsPurchasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageProductsToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.productsDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stockDetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ProductsReportToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.allProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortProductsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageTokensToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripButton,
            this.toolStripSeparator3,
            this.ManagePurchasesToolStripButton,
            this.toolStripSeparator1,
            this.ManageProductsToolStripButton,
            this.toolStripSeparator2,
            this.ManageTokensToolStripButton,
            this.toolStripSeparator4,
            this.ProductsReportToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(830, 25);
            this.toolStrip1.TabIndex = 157;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BackToolStripButton
            // 
            this.BackToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BackToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("BackToolStripButton.Image")));
            this.BackToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BackToolStripButton.Name = "BackToolStripButton";
            this.BackToolStripButton.Size = new System.Drawing.Size(36, 22);
            this.BackToolStripButton.Text = "Back";
            this.BackToolStripButton.Click += new System.EventHandler(this.BackToolStripButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ManagePurchasesToolStripButton
            // 
            this.ManagePurchasesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ManagePurchasesToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsPurchasesToolStripMenuItem});
            this.ManagePurchasesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManagePurchasesToolStripButton.Image")));
            this.ManagePurchasesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManagePurchasesToolStripButton.Name = "ManagePurchasesToolStripButton";
            this.ManagePurchasesToolStripButton.Size = new System.Drawing.Size(119, 22);
            this.ManagePurchasesToolStripButton.Text = "Manage Purchases";
            // 
            // productsPurchasesToolStripMenuItem
            // 
            this.productsPurchasesToolStripMenuItem.Name = "productsPurchasesToolStripMenuItem";
            this.productsPurchasesToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.productsPurchasesToolStripMenuItem.Text = "Products Purchases";
            this.productsPurchasesToolStripMenuItem.Click += new System.EventHandler(this.productsPurchasesToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ManageProductsToolStripButton
            // 
            this.ManageProductsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ManageProductsToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.productsDetailToolStripMenuItem,
            this.stockDetToolStripMenuItem});
            this.ManageProductsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageProductsToolStripButton.Image")));
            this.ManageProductsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageProductsToolStripButton.Name = "ManageProductsToolStripButton";
            this.ManageProductsToolStripButton.Size = new System.Drawing.Size(113, 22);
            this.ManageProductsToolStripButton.Text = "Manage Products";
            // 
            // productsDetailToolStripMenuItem
            // 
            this.productsDetailToolStripMenuItem.Name = "productsDetailToolStripMenuItem";
            this.productsDetailToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.productsDetailToolStripMenuItem.Text = "Add Products";
            this.productsDetailToolStripMenuItem.Click += new System.EventHandler(this.productsDetailToolStripMenuItem_Click);
            // 
            // stockDetToolStripMenuItem
            // 
            this.stockDetToolStripMenuItem.Name = "stockDetToolStripMenuItem";
            this.stockDetToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.stockDetToolStripMenuItem.Text = "Add Stock";
            this.stockDetToolStripMenuItem.Click += new System.EventHandler(this.stockDetToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ProductsReportToolStripButton
            // 
            this.ProductsReportToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ProductsReportToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allProductsToolStripMenuItem,
            this.shortProductsToolStripMenuItem,
            this.applyFilterToolStripMenuItem});
            this.ProductsReportToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ProductsReportToolStripButton.Image")));
            this.ProductsReportToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ProductsReportToolStripButton.Name = "ProductsReportToolStripButton";
            this.ProductsReportToolStripButton.Size = new System.Drawing.Size(105, 22);
            this.ProductsReportToolStripButton.Text = "Products Report";
            // 
            // allProductsToolStripMenuItem
            // 
            this.allProductsToolStripMenuItem.Name = "allProductsToolStripMenuItem";
            this.allProductsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.allProductsToolStripMenuItem.Text = "All Products";
            this.allProductsToolStripMenuItem.Click += new System.EventHandler(this.allProductsToolStripMenuItem_Click);
            // 
            // shortProductsToolStripMenuItem
            // 
            this.shortProductsToolStripMenuItem.Name = "shortProductsToolStripMenuItem";
            this.shortProductsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.shortProductsToolStripMenuItem.Text = "Short Products";
            this.shortProductsToolStripMenuItem.Click += new System.EventHandler(this.shortProductsToolStripMenuItem_Click);
            // 
            // applyFilterToolStripMenuItem
            // 
            this.applyFilterToolStripMenuItem.Name = "applyFilterToolStripMenuItem";
            this.applyFilterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.applyFilterToolStripMenuItem.Text = "Apply Filter";
            this.applyFilterToolStripMenuItem.Click += new System.EventHandler(this.applyFilterToolStripMenuItem_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(830, 413);
            this.MainPanel.TabIndex = 158;
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // ManageTokensToolStripButton
            // 
            this.ManageTokensToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ManageTokensToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageTokensToolStripButton.Image")));
            this.ManageTokensToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageTokensToolStripButton.Name = "ManageTokensToolStripButton";
            this.ManageTokensToolStripButton.Size = new System.Drawing.Size(104, 22);
            this.ManageTokensToolStripButton.Text = "Manage Tokens";
            this.ManageTokensToolStripButton.Click += new System.EventHandler(this.ManageTokensToolStripButton_Click);
            // 
            // ProductDeshBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 438);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimizeBox = true;
            this.Name = "ProductDeshBoardForm";
            this.ShowInTaskbar = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProductDeshBoardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ProductDeshBoardForm_FormClosing);
            this.Load += new System.EventHandler(this.ProductDeshBoardForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripDropDownButton ManagePurchasesToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem productsPurchasesToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ManageProductsToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem productsDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stockDetToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ProductsReportToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem allProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortProductsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem applyFilterToolStripMenuItem;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripDropDownButton ManageTokensToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
    }
}