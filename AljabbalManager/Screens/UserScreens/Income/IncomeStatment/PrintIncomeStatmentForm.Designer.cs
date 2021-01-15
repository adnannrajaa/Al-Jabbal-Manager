namespace ASDBFramework.Screens.UserScreens.Income.IncomeStatment
{
    partial class PrintIncomeStatmentForm
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
            this.IncomeStatmentCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // IncomeStatmentCrystalReportViewer
            // 
            this.IncomeStatmentCrystalReportViewer.ActiveViewIndex = -1;
            this.IncomeStatmentCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.IncomeStatmentCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.IncomeStatmentCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IncomeStatmentCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.IncomeStatmentCrystalReportViewer.Name = "IncomeStatmentCrystalReportViewer";
            this.IncomeStatmentCrystalReportViewer.Size = new System.Drawing.Size(876, 609);
            this.IncomeStatmentCrystalReportViewer.TabIndex = 1;
            this.IncomeStatmentCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.IncomeStatmentCrystalReportViewer.Load += new System.EventHandler(this.IncomeStatmentCrystalReportViewer_Load);
            // 
            // PrintIncomeStatmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 609);
            this.Controls.Add(this.IncomeStatmentCrystalReportViewer);
            this.Name = "PrintIncomeStatmentForm";
            this.Text = "Print Income Statment";
            this.Load += new System.EventHandler(this.PrintIncomeStatmentForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer IncomeStatmentCrystalReportViewer;
    }
}