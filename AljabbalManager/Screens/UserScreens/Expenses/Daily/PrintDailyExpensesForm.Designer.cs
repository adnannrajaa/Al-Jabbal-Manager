namespace ASDBFramework.Screens.UserScreens.Expenses.DailyExpenses
{
    partial class PrintDailyExpensesForm
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
            this.DailyExpensesCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DailyExpensesCrystalReportViewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(876, 609);
            this.panel1.TabIndex = 1;
            // 
            // DailyExpensesCrystalReportViewer
            // 
            this.DailyExpensesCrystalReportViewer.ActiveViewIndex = -1;
            this.DailyExpensesCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DailyExpensesCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.DailyExpensesCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DailyExpensesCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.DailyExpensesCrystalReportViewer.Name = "DailyExpensesCrystalReportViewer";
            this.DailyExpensesCrystalReportViewer.Size = new System.Drawing.Size(876, 609);
            this.DailyExpensesCrystalReportViewer.TabIndex = 0;
            this.DailyExpensesCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // PrintDailyExpensesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 609);
            this.Controls.Add(this.panel1);
            this.Name = "PrintDailyExpensesForm";
            this.Text = "Print Daily Expenses";
            this.Load += new System.EventHandler(this.PrintDailyExpensesForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer DailyExpensesCrystalReportViewer;
    }
}