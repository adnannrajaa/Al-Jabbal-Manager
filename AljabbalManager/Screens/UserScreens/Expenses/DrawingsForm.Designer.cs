namespace ASDBFramework.Screens.UserScreens.Expenses
{
    partial class DrawingsForm
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.TotalAmountTextBox = new System.Windows.Forms.TextBox();
            this.TotalAmountLabel = new System.Windows.Forms.Label();
            this.ShareholderNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.ShareholderNameLabel = new System.Windows.Forms.Label();
            this.ViewButton = new System.Windows.Forms.Button();
            this.DrawingsDataGridView = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(438, 95);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(63, 39);
            this.SaveButton.TabIndex = 82;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // TotalAmountTextBox
            // 
            this.TotalAmountTextBox.Location = new System.Drawing.Point(210, 110);
            this.TotalAmountTextBox.Name = "TotalAmountTextBox";
            this.TotalAmountTextBox.Size = new System.Drawing.Size(118, 22);
            this.TotalAmountTextBox.TabIndex = 80;
            // 
            // TotalAmountLabel
            // 
            this.TotalAmountLabel.AutoSize = true;
            this.TotalAmountLabel.Location = new System.Drawing.Point(207, 91);
            this.TotalAmountLabel.Name = "TotalAmountLabel";
            this.TotalAmountLabel.Size = new System.Drawing.Size(105, 16);
            this.TotalAmountLabel.TabIndex = 79;
            this.TotalAmountLabel.Text = "Drawing Amount";
            // 
            // ShareholderNameComboBox
            // 
            this.ShareholderNameComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShareholderNameComboBox.FormattingEnabled = true;
            this.ShareholderNameComboBox.Location = new System.Drawing.Point(12, 110);
            this.ShareholderNameComboBox.Name = "ShareholderNameComboBox";
            this.ShareholderNameComboBox.Size = new System.Drawing.Size(154, 24);
            this.ShareholderNameComboBox.TabIndex = 77;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(570, 79);
            this.panel1.TabIndex = 135;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(121, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(335, 42);
            this.label3.TabIndex = 0;
            this.label3.Text = "Manage Drawings";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ShareholderNameLabel
            // 
            this.ShareholderNameLabel.AutoSize = true;
            this.ShareholderNameLabel.Location = new System.Drawing.Point(9, 91);
            this.ShareholderNameLabel.Name = "ShareholderNameLabel";
            this.ShareholderNameLabel.Size = new System.Drawing.Size(122, 16);
            this.ShareholderNameLabel.TabIndex = 136;
            this.ShareholderNameLabel.Text = "Shareholder Name";
            // 
            // ViewButton
            // 
            this.ViewButton.Location = new System.Drawing.Point(507, 95);
            this.ViewButton.Name = "ViewButton";
            this.ViewButton.Size = new System.Drawing.Size(63, 39);
            this.ViewButton.TabIndex = 137;
            this.ViewButton.Text = "View";
            this.ViewButton.UseVisualStyleBackColor = true;
            this.ViewButton.Click += new System.EventHandler(this.ViewButton_Click);
            // 
            // DrawingsDataGridView
            // 
            this.DrawingsDataGridView.AllowUserToAddRows = false;
            this.DrawingsDataGridView.AllowUserToDeleteRows = false;
            this.DrawingsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DrawingsDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.DrawingsDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DrawingsDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DrawingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DrawingsDataGridView.Location = new System.Drawing.Point(3, 162);
            this.DrawingsDataGridView.Name = "DrawingsDataGridView";
            this.DrawingsDataGridView.ReadOnly = true;
            this.DrawingsDataGridView.Size = new System.Drawing.Size(564, 284);
            this.DrawingsDataGridView.TabIndex = 139;
            // 
            // DrawingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 448);
            this.Controls.Add(this.DrawingsDataGridView);
            this.Controls.Add(this.ViewButton);
            this.Controls.Add(this.ShareholderNameLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.TotalAmountTextBox);
            this.Controls.Add(this.TotalAmountLabel);
            this.Controls.Add(this.ShareholderNameComboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DrawingsForm";
            this.Text = "DrawingsForm";
            this.Load += new System.EventHandler(this.DrawingsForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DrawingsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox TotalAmountTextBox;
        private System.Windows.Forms.Label TotalAmountLabel;
        private System.Windows.Forms.ComboBox ShareholderNameComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ShareholderNameLabel;
        private System.Windows.Forms.Button ViewButton;
        private System.Windows.Forms.DataGridView DrawingsDataGridView;
    }
}