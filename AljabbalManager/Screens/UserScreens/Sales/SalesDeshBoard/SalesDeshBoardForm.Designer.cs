namespace ASDBFramework.Screens.UserScreens.Sales.SalesDeshBoard
{
    partial class SalesDeshBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesDeshBoardForm));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageSalesToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.makeInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesReturnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SalesReportsToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.saleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.Desktop;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(982, 22);
            this.statusStrip1.TabIndex = 189;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ToolStripStatusLabel
            // 
            this.ToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.ToolStripStatusLabel.Name = "ToolStripStatusLabel";
            this.ToolStripStatusLabel.Size = new System.Drawing.Size(331, 17);
            this.ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Make Invoice ";
            this.ToolStripStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(982, 458);
            this.MainPanel.TabIndex = 159;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripButton,
            this.toolStripSeparator1,
            this.ManageSalesToolStripButton,
            this.toolStripSeparator2,
            this.SalesReportsToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(982, 25);
            this.toolStrip1.TabIndex = 154;
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ManageSalesToolStripButton
            // 
            this.ManageSalesToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ManageSalesToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.makeInvoiceToolStripMenuItem,
            this.salesReturnToolStripMenuItem});
            this.ManageSalesToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageSalesToolStripButton.Image")));
            this.ManageSalesToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageSalesToolStripButton.Name = "ManageSalesToolStripButton";
            this.ManageSalesToolStripButton.Size = new System.Drawing.Size(92, 22);
            this.ManageSalesToolStripButton.Text = "Manage Sales";
            // 
            // makeInvoiceToolStripMenuItem
            // 
            this.makeInvoiceToolStripMenuItem.Name = "makeInvoiceToolStripMenuItem";
            this.makeInvoiceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.makeInvoiceToolStripMenuItem.Text = "Make Invoice";
            this.makeInvoiceToolStripMenuItem.Click += new System.EventHandler(this.makeInvoiceToolStripMenuItem_Click);
            // 
            // salesReturnToolStripMenuItem
            // 
            this.salesReturnToolStripMenuItem.Name = "salesReturnToolStripMenuItem";
            this.salesReturnToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salesReturnToolStripMenuItem.Text = "Sales Return";
            this.salesReturnToolStripMenuItem.Click += new System.EventHandler(this.salesReturnToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // SalesReportsToolStripButton
            // 
            this.SalesReportsToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SalesReportsToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saleReportToolStripMenuItem});
            this.SalesReportsToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("SalesReportsToolStripButton.Image")));
            this.SalesReportsToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SalesReportsToolStripButton.Name = "SalesReportsToolStripButton";
            this.SalesReportsToolStripButton.Size = new System.Drawing.Size(84, 22);
            this.SalesReportsToolStripButton.Text = "Sales Report";
            // 
            // saleReportToolStripMenuItem
            // 
            this.saleReportToolStripMenuItem.Name = "saleReportToolStripMenuItem";
            this.saleReportToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.saleReportToolStripMenuItem.Text = "Sale Report";
            this.saleReportToolStripMenuItem.Click += new System.EventHandler(this.saleReportToolStripMenuItem_Click);
            // 
            // SalesDeshBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 483);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "SalesDeshBoardForm";
            this.ShowInTaskbar = true;
            this.Text = "SalesDeshBoardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SalesDeshBoardForm_FormClosing);
            this.Load += new System.EventHandler(this.SalesDeshBoardForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripDropDownButton ManageSalesToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem makeInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesReturnToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton SalesReportsToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem saleReportToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel;

    }
}