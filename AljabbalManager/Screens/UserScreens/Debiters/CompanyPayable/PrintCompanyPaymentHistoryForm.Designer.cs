﻿namespace ASDBFramework.Screens.UserScreens.Debiters.CompanyPayable
{
    partial class PrintCompanyPaymentHistoryForm
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
            this.CompanyPaymentHistoryCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // CompanyPaymentHistoryCrystalReportViewer
            // 
            this.CompanyPaymentHistoryCrystalReportViewer.ActiveViewIndex = -1;
            this.CompanyPaymentHistoryCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CompanyPaymentHistoryCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.CompanyPaymentHistoryCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CompanyPaymentHistoryCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.CompanyPaymentHistoryCrystalReportViewer.Name = "CompanyPaymentHistoryCrystalReportViewer";
            this.CompanyPaymentHistoryCrystalReportViewer.Size = new System.Drawing.Size(876, 609);
            this.CompanyPaymentHistoryCrystalReportViewer.TabIndex = 2;
            this.CompanyPaymentHistoryCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PrintCompanyPaymentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 609);
            this.Controls.Add(this.CompanyPaymentHistoryCrystalReportViewer);
            this.Name = "PrintCompanyPaymentHistoryForm";
            this.Text = "Print Payment History";
            this.Load += new System.EventHandler(this.PrintCompanyPaymentHistoryForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer CompanyPaymentHistoryCrystalReportViewer;
    }
}