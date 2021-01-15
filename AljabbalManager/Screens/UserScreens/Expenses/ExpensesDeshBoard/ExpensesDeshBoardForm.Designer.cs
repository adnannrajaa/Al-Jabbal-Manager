namespace ASDBFramework.Screens.UserScreens.Expenses.ExpensesDeshBoard
{
    partial class ExpensesDeshBoardForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Daily Expenses");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Monthly Expenses");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Drawings");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Direct Expenses", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Freight in");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Wages");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Others", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ExpensesDeshBoradTreeView = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(213, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(759, 466);
            this.MainPanel.TabIndex = 157;
            // 
            // ExpensesDeshBoradTreeView
            // 
            this.ExpensesDeshBoradTreeView.Dock = System.Windows.Forms.DockStyle.Left;
            this.ExpensesDeshBoradTreeView.Location = new System.Drawing.Point(0, 0);
            this.ExpensesDeshBoradTreeView.Name = "ExpensesDeshBoradTreeView";
            treeNode1.Name = "DailyExpensesChildNode";
            treeNode1.Text = "Daily Expenses";
            treeNode2.Name = "MonthlyExpensesChildNode";
            treeNode2.Text = "Monthly Expenses";
            treeNode3.Name = "DrawingsChildNode";
            treeNode3.Text = "Drawings";
            treeNode4.Name = "ExpensesRootNode";
            treeNode4.Text = "Direct Expenses";
            treeNode5.Name = "FreightInChildNode";
            treeNode5.Text = "Freight in";
            treeNode6.Name = "WagesChildNode";
            treeNode6.Text = "Wages";
            treeNode7.Name = "ManageProductsRootNode";
            treeNode7.Text = "Others";
            this.ExpensesDeshBoradTreeView.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode7});
            this.ExpensesDeshBoradTreeView.Size = new System.Drawing.Size(213, 466);
            this.ExpensesDeshBoradTreeView.TabIndex = 156;
            this.ExpensesDeshBoradTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ExpansesDeshBoradTreeView_AfterSelect);
            // 
            // ExpensesDeshBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 466);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.ExpensesDeshBoradTreeView);
            this.MinimizeBox = true;
            this.Name = "ExpensesDeshBoardForm";
            this.ShowInTaskbar = true;
            this.Text = "ExpensesDeshBoardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ExpensesDeshBoardForm_FormClosing);
            this.Load += new System.EventHandler(this.ExpensesDeshBoardForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TreeView ExpensesDeshBoradTreeView;
    }
}