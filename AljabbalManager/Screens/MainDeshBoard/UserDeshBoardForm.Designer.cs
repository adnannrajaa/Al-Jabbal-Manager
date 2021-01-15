namespace ASDBFramework.Screens.UserScreens
{
    partial class UserDeshBoardForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserDeshBoardForm));
            this.TodayDateAndTime = new System.Windows.Forms.Timer(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.IncomePictureBox = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DebitersPictureBox = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ExpensesPictureBox = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.UsersPictureBox = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ItemsPictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SalesPictureBox = new System.Windows.Forms.PictureBox();
            this.StatusStrip = new System.Windows.Forms.StatusStrip();
            this.LoggedinAsToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.DateToolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ShowMessage = new System.Windows.Forms.ToolStripStatusLabel();
            this.View = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebitersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPictureBox)).BeginInit();
            this.StatusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TodayDateAndTime
            // 
            this.TodayDateAndTime.Tick += new System.EventHandler(this.TodayDateAndTime_Tick);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.IncomePictureBox);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.DebitersPictureBox);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.ExpensesPictureBox);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.UsersPictureBox);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.ItemsPictureBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.SalesPictureBox);
            this.panel2.Location = new System.Drawing.Point(223, 173);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1086, 476);
            this.panel2.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(986, 439);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 24);
            this.label7.TabIndex = 25;
            this.label7.Text = "Income";
            // 
            // IncomePictureBox
            // 
            this.IncomePictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IncomePictureBox.Image")));
            this.IncomePictureBox.Location = new System.Drawing.Point(811, 330);
            this.IncomePictureBox.Name = "IncomePictureBox";
            this.IncomePictureBox.Size = new System.Drawing.Size(177, 125);
            this.IncomePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.IncomePictureBox.TabIndex = 24;
            this.IncomePictureBox.TabStop = false;
            this.IncomePictureBox.Click += new System.EventHandler(this.IncomePictureBox_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(608, 439);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 24);
            this.label5.TabIndex = 23;
            this.label5.Text = "Debtors";
            // 
            // DebitersPictureBox
            // 
            this.DebitersPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("DebitersPictureBox.Image")));
            this.DebitersPictureBox.Location = new System.Drawing.Point(425, 330);
            this.DebitersPictureBox.Name = "DebitersPictureBox";
            this.DebitersPictureBox.Size = new System.Drawing.Size(177, 125);
            this.DebitersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.DebitersPictureBox.TabIndex = 22;
            this.DebitersPictureBox.TabStop = false;
            this.DebitersPictureBox.Click += new System.EventHandler(this.DebitersPictureBox_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(176, 439);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 24);
            this.label6.TabIndex = 21;
            this.label6.Text = "Expenses";
            // 
            // ExpensesPictureBox
            // 
            this.ExpensesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ExpensesPictureBox.Image")));
            this.ExpensesPictureBox.Location = new System.Drawing.Point(35, 330);
            this.ExpensesPictureBox.Name = "ExpensesPictureBox";
            this.ExpensesPictureBox.Size = new System.Drawing.Size(167, 125);
            this.ExpensesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ExpensesPictureBox.TabIndex = 20;
            this.ExpensesPictureBox.TabStop = false;
            this.ExpensesPictureBox.Click += new System.EventHandler(this.ExpensesPictureBox_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(986, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 24);
            this.label4.TabIndex = 19;
            this.label4.Text = "Users";
            // 
            // UsersPictureBox
            // 
            this.UsersPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("UsersPictureBox.Image")));
            this.UsersPictureBox.Location = new System.Drawing.Point(811, 9);
            this.UsersPictureBox.Name = "UsersPictureBox";
            this.UsersPictureBox.Size = new System.Drawing.Size(177, 125);
            this.UsersPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.UsersPictureBox.TabIndex = 18;
            this.UsersPictureBox.TabStop = false;
            this.UsersPictureBox.Click += new System.EventHandler(this.UsersPictureBox_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(608, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 24);
            this.label3.TabIndex = 17;
            this.label3.Text = "Items";
            // 
            // ItemsPictureBox
            // 
            this.ItemsPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ItemsPictureBox.Image")));
            this.ItemsPictureBox.Location = new System.Drawing.Point(425, 9);
            this.ItemsPictureBox.Name = "ItemsPictureBox";
            this.ItemsPictureBox.Size = new System.Drawing.Size(177, 125);
            this.ItemsPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemsPictureBox.TabIndex = 16;
            this.ItemsPictureBox.TabStop = false;
            this.ItemsPictureBox.Click += new System.EventHandler(this.ItemsPictureBox_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(176, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 24);
            this.label2.TabIndex = 15;
            this.label2.Text = "Sales";
            // 
            // SalesPictureBox
            // 
            this.SalesPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("SalesPictureBox.Image")));
            this.SalesPictureBox.Location = new System.Drawing.Point(35, 9);
            this.SalesPictureBox.Name = "SalesPictureBox";
            this.SalesPictureBox.Size = new System.Drawing.Size(167, 125);
            this.SalesPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SalesPictureBox.TabIndex = 14;
            this.SalesPictureBox.TabStop = false;
            this.SalesPictureBox.Click += new System.EventHandler(this.SalesPictureBox_Click);
            // 
            // StatusStrip
            // 
            this.StatusStrip.BackColor = System.Drawing.Color.Black;
            this.StatusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoggedinAsToolStripStatusLabel,
            this.DateToolStripStatusLabel,
            this.ShowMessage,
            this.View});
            this.StatusStrip.Location = new System.Drawing.Point(0, 660);
            this.StatusStrip.Name = "StatusStrip";
            this.StatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.StatusStrip.Size = new System.Drawing.Size(1321, 22);
            this.StatusStrip.TabIndex = 15;
            this.StatusStrip.Text = "StatusStrip";
            // 
            // LoggedinAsToolStripStatusLabel
            // 
            this.LoggedinAsToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.LoggedinAsToolStripStatusLabel.Name = "LoggedinAsToolStripStatusLabel";
            this.LoggedinAsToolStripStatusLabel.Size = new System.Drawing.Size(80, 17);
            this.LoggedinAsToolStripStatusLabel.Text = "Logged in as :";
            // 
            // DateToolStripStatusLabel
            // 
            this.DateToolStripStatusLabel.ForeColor = System.Drawing.Color.White;
            this.DateToolStripStatusLabel.Name = "DateToolStripStatusLabel";
            this.DateToolStripStatusLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DateToolStripStatusLabel.Size = new System.Drawing.Size(28, 17);
            this.DateToolStripStatusLabel.Text = "       ";
            // 
            // ShowMessage
            // 
            this.ShowMessage.ForeColor = System.Drawing.Color.White;
            this.ShowMessage.Name = "ShowMessage";
            this.ShowMessage.Size = new System.Drawing.Size(0, 17);
            // 
            // View
            // 
            this.View.ForeColor = System.Drawing.Color.White;
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(32, 17);
            this.View.Text = "View";
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(47, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(167, 157);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1321, 89);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(441, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(539, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Al Jabbal Managment System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserDeshBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1321, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.StatusStrip);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "UserDeshBoardForm";
            this.ShowInTaskbar = true;
            this.Text = "UserDeshBoradForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserDeshBoardForm_FormClosing);
            this.Load += new System.EventHandler(this.UserDeshBoardForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IncomePictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DebitersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExpensesPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SalesPictureBox)).EndInit();
            this.StatusStrip.ResumeLayout(false);
            this.StatusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.StatusStrip StatusStrip;
        private System.Windows.Forms.ToolStripStatusLabel LoggedinAsToolStripStatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel DateToolStripStatusLabel;
        private System.Windows.Forms.Timer TodayDateAndTime;
        private System.Windows.Forms.PictureBox SalesPictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox ItemsPictureBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox UsersPictureBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox ExpensesPictureBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox DebitersPictureBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox IncomePictureBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripStatusLabel ShowMessage;
        private System.Windows.Forms.ToolStripStatusLabel View;
    }
}