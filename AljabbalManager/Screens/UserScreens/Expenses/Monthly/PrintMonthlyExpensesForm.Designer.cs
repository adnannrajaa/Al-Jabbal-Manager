namespace ASDBFramework.Screens.UserScreens.Expenses.Monthly
{
    partial class PrintMonthlyExpensesForm
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
            this.MonthlyExpensesCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // MonthlyExpensesCrystalReportViewer
            // 
            this.MonthlyExpensesCrystalReportViewer.ActiveViewIndex = -1;
            this.MonthlyExpensesCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MonthlyExpensesCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.MonthlyExpensesCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MonthlyExpensesCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.MonthlyExpensesCrystalReportViewer.Name = "MonthlyExpensesCrystalReportViewer";
            this.MonthlyExpensesCrystalReportViewer.Size = new System.Drawing.Size(876, 609);
            this.MonthlyExpensesCrystalReportViewer.TabIndex = 1;
            this.MonthlyExpensesCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PrintMonthlyExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 609);
            this.Controls.Add(this.MonthlyExpensesCrystalReportViewer);
            this.Name = "PrintMonthlyExpensesForm";
            this.Text = "PrintMonthlyExpensesForm";
            this.Load += new System.EventHandler(this.PrintMonthlyExpensesForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer MonthlyExpensesCrystalReportViewer;
    }
}