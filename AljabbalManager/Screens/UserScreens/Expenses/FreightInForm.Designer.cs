namespace ASDBFramework.Screens.UserScreens.Expenses
{
    partial class FreightInForm
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
            this.FreightInDataGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.InvoiceNoLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.BillNoTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.FreightInDataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // FreightInDataGridView
            // 
            this.FreightInDataGridView.AllowUserToAddRows = false;
            this.FreightInDataGridView.AllowUserToDeleteRows = false;
            this.FreightInDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.FreightInDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.FreightInDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FreightInDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.FreightInDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FreightInDataGridView.Location = new System.Drawing.Point(4, 154);
            this.FreightInDataGridView.Name = "FreightInDataGridView";
            this.FreightInDataGridView.ReadOnly = true;
            this.FreightInDataGridView.Size = new System.Drawing.Size(588, 292);
            this.FreightInDataGridView.TabIndex = 161;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(133, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Freight In";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(531, 96);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(63, 39);
            this.ViewButton.TabIndex = 160;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // InvoiceNoLabel
            // 
            this.InvoiceNoLabel.AutoSize = true;
            this.InvoiceNoLabel.Location = new System.Drawing.Point(9, 92);
            this.InvoiceNoLabel.Name = "InvoiceNoLabel";
            this.InvoiceNoLabel.Size = new System.Drawing.Size(72, 16);
            this.InvoiceNoLabel.TabIndex = 159;
            this.InvoiceNoLabel.Text = "Invoice No";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(594, 79);
            this.panel1.TabIndex = 158;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(462, 96);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 39);
            this.SaveButton.TabIndex = 157;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Location = new System.Drawing.Point(168, 113);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(118, 22);
            this.TotalAmountTextBox.TabIndex = 156;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(165, 92);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(87, 16);
            this.TotalAmountLabel.TabIndex = 155;
            this.TotalAmountLabel.Text = "Total Amount";
            // 
            // BillNoTextBox
            // 
            this.BillNoTextBox.Location = new System.Drawing.Point(12, 113);
            this.BillNoTextBox.Name = "BillNoTextBox";
            this.BillNoTextBox.Size = new System.Drawing.Size(118, 22);
            this.BillNoTextBox.TabIndex = 166;
            // 
            // FreightInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 448);
            this.Controls.Add(this.BillNoTextBox);
            this.Controls.Add(this.FreightInDataGridView);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.InvoiceNoLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.TotalAmountLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FreightInForm";
            this.Text = "FreightInForm";
            this.Load += new System.EventHandler(this.FreightInForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FreightInDataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView FreightInDataGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.Label InvoiceNoLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.TextBox BillNoTextBox;
    }
}