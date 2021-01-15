namespace ASDBFramework.Screens.UserScreens.Sales.SaleInvoice
{
    partial class MakeInvoiceForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MakeInvoiceCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MakeInvoiceCrystalReportViewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 609);
            this.panel1.TabIndex = 0;
            // 
            // MakeInvoiceCrystalReportViewer
            // 
            this.MakeInvoiceCrystalReportViewer.ActiveViewIndex = -1;
            this.MakeInvoiceCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MakeInvoiceCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MakeInvoiceCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MakeInvoiceCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MakeInvoiceCrystalReportViewer.Name = "MakeInvoiceCrystalReportViewer";
            this.MakeInvoiceCrystalReportViewer.Size = new System.Drawing.Size(876, 609);
            this.MakeInvoiceCrystalReportViewer.TabIndex = 0;
            this.MakeInvoiceCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // MakeInvoiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 609);
            this.Controls.Add(this.panel1);
            this.Name = "MakeInvoiceForm";
            this.Text = "Print Invoice";
            this.Load += new System.EventHandler(this.MakeInvoiceForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer MakeInvoiceCrystalReportViewer;
    }
}