namespace ASDBFramework.Screens.UserScreens.Debiters.CustomerDebtors
{
    partial class PrintPaymentHistoryForm
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
            this.PaymentHistoryCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // PaymentHistoryCrystalReportViewer
            // 
            this.PaymentHistoryCrystalReportViewer.ActiveViewIndex = -1;
            this.PaymentHistoryCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PaymentHistoryCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.PaymentHistoryCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PaymentHistoryCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.PaymentHistoryCrystalReportViewer.Name = "PaymentHistoryCrystalReportViewer";
            this.PaymentHistoryCrystalReportViewer.Size = new System.Drawing.Size(876, 609);
            this.PaymentHistoryCrystalReportViewer.TabIndex = 1;
            this.PaymentHistoryCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PrintPaymentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 609);
            this.Controls.Add(this.PaymentHistoryCrystalReportViewer);
            this.Name = "PrintPaymentHistoryForm";
            this.Text = "Print Payment History";
            this.Load += new System.EventHandler(this.PrintPaymentHistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer PaymentHistoryCrystalReportViewer;
    }
}