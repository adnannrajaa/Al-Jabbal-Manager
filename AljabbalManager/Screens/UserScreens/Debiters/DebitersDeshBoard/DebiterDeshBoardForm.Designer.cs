namespace ASDBFramework.Screens.UserScreens.Debiters.DebitersDeshBoard
{
    partial class DebiterDeshBoardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DebiterDeshBoardForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BackToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ManageCustomerToolStripSplitButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.listAllDebtorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showPaymentsDetailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ManagePartyToolStripButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.payableToPartyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partyPaymentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 25);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(903, 423);
            this.MainPanel.TabIndex = 2;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BackToolStripButton,
            this.toolStripSeparator2,
            this.ManageCustomerToolStripSplitButton,
            this.toolStripSeparator1,
            this.ManagePartyToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(903, 25);
            this.toolStrip1.TabIndex = 1;
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // ManageCustomerToolStripSplitButton
            // 
            this.ManageCustomerToolStripSplitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ManageCustomerToolStripSplitButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAllDebtorsToolStripMenuItem,
            this.showPaymentsDetailToolStripMenuItem});
            this.ManageCustomerToolStripSplitButton.Image = ((System.Drawing.Image)(resources.GetObject("ManageCustomerToolStripSplitButton.Image")));
            this.ManageCustomerToolStripSplitButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManageCustomerToolStripSplitButton.Name = "ManageCustomerToolStripSplitButton";
            this.ManageCustomerToolStripSplitButton.Size = new System.Drawing.Size(118, 22);
            this.ManageCustomerToolStripSplitButton.Text = "Manage Customer";
            // 
            // listAllDebtorsToolStripMenuItem
            // 
            this.listAllDebtorsToolStripMenuItem.Name = "listAllDebtorsToolStripMenuItem";
            this.listAllDebtorsToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.listAllDebtorsToolStripMenuItem.Text = "List All Debtors";
            this.listAllDebtorsToolStripMenuItem.Click += new System.EventHandler(this.listAllDebtorsToolStripMenuItem_Click);
            // 
            // showPaymentsDetailToolStripMenuItem
            // 
            this.showPaymentsDetailToolStripMenuItem.Name = "showPaymentsDetailToolStripMenuItem";
            this.showPaymentsDetailToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.showPaymentsDetailToolStripMenuItem.Text = "Payments By Customer";
            this.showPaymentsDetailToolStripMenuItem.Click += new System.EventHandler(this.showPaymentsDetailToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // ManagePartyToolStripButton
            // 
            this.ManagePartyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ManagePartyToolStripButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payableToPartyToolStripMenuItem,
            this.partyPaymentsToolStripMenuItem});
            this.ManagePartyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("ManagePartyToolStripButton.Image")));
            this.ManagePartyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ManagePartyToolStripButton.Name = "ManagePartyToolStripButton";
            this.ManagePartyToolStripButton.Size = new System.Drawing.Size(93, 22);
            this.ManagePartyToolStripButton.Text = "Manage Party";
            // 
            // payableToPartyToolStripMenuItem
            // 
            this.payableToPartyToolStripMenuItem.Name = "payableToPartyToolStripMenuItem";
            this.payableToPartyToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.payableToPartyToolStripMenuItem.Text = "Payable To Party";
            this.payableToPartyToolStripMenuItem.Click += new System.EventHandler(this.payableToPartyToolStripMenuItem_Click);
            // 
            // partyPaymentsToolStripMenuItem
            // 
            this.partyPaymentsToolStripMenuItem.Name = "partyPaymentsToolStripMenuItem";
            this.partyPaymentsToolStripMenuItem.Size = new System.Drawing.Size(170, 22);
            this.partyPaymentsToolStripMenuItem.Text = "Payments to party";
            this.partyPaymentsToolStripMenuItem.Click += new System.EventHandler(this.partyPaymentsToolStripMenuItem_Click);
            // 
            // DebiterDeshBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 448);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.toolStrip1);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "DebiterDeshBoardForm";
            this.ShowInTaskbar = true;
            this.Text = "Debtors Desh Board Form";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DebiterDeshBoardForm_FormClosing);
            this.Load += new System.EventHandler(this.DebiterDeshBoardForm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BackToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.ToolStripDropDownButton ManageCustomerToolStripSplitButton;
        private System.Windows.Forms.ToolStripMenuItem listAllDebtorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showPaymentsDetailToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton ManagePartyToolStripButton;
        private System.Windows.Forms.ToolStripMenuItem payableToPartyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partyPaymentsToolStripMenuItem;

    }
}