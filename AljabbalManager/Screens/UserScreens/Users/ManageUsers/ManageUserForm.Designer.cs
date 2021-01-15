namespace ASDBFramework.Screens.UserScreens.Users
{
    partial class ManageUserForm
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
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ManageUserDataGridView = new System.Windows.Forms.DataGridView();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(766, 403);
            this.MainPanel.TabIndex = 31;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.ManageUserDataGridView);
            this.panel1.Location = new System.Drawing.Point(4, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(749, 379);
            this.panel1.TabIndex = 27;
            // 
            // ManageUserDataGridView
            // 
            this.ManageUserDataGridView.AllowUserToAddRows = false;
            this.ManageUserDataGridView.AllowUserToDeleteRows = false;
            this.ManageUserDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.ManageUserDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ManageUserDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ManageUserDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.ManageUserDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ManageUserDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ManageUserDataGridView.Location = new System.Drawing.Point(0, 0);
            this.ManageUserDataGridView.Name = "ManageUserDataGridView";
            this.ManageUserDataGridView.ReadOnly = true;
            this.ManageUserDataGridView.Size = new System.Drawing.Size(745, 375);
            this.ManageUserDataGridView.TabIndex = 8;
            this.ManageUserDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ManageUserDataGridView_MouseDoubleClick);
            // 
            // ManageUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 403);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUserForm";
            this.Text = "ManageUserForm";
            this.Load += new System.EventHandler(this.ManageUserForm_Load);
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ManageUserDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView ManageUserDataGridView;
    }
}