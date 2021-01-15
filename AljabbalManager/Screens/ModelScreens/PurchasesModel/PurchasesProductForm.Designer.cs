namespace ASDBFramework.Screens.UserScreens.ModelScreens
{
    partial class PurchasesProductForm
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
            this.ProductDescriptionLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.OkButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ProductDescriptionListBox = new System.Windows.Forms.ListBox();
            this.ProductNameListBox = new System.Windows.Forms.ListBox();
            this.ProductNameTextBox = new System.Windows.Forms.TextBox();
            this.ProductDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.AutoSize = true;
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(229, 14);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(125, 16);
            this.ProductDescriptionLabel.TabIndex = 8;
            this.ProductDescriptionLabel.Text = "Product Description";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(27, 14);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(94, 16);
            this.ProductNameLabel.TabIndex = 7;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // OkButton
            // 
            this.OkButton.Location = new System.Drawing.Point(481, 37);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(55, 24);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Ok";
            this.OkButton.UseVisualStyleBackColor = true;
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(544, 37);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(55, 24);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // ProductDescriptionListBox
            // 
            this.ProductDescriptionListBox.FormattingEnabled = true;
            this.ProductDescriptionListBox.ItemHeight = 16;
            this.ProductDescriptionListBox.Location = new System.Drawing.Point(232, 61);
            this.ProductDescriptionListBox.Name = "ProductDescriptionListBox";
            this.ProductDescriptionListBox.Size = new System.Drawing.Size(204, 100);
            this.ProductDescriptionListBox.TabIndex = 6;
            this.ProductDescriptionListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductDescriptionListBox_KeyDown);
            this.ProductDescriptionListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProductDescriptionListBox_MouseDoubleClick);
            // 
            // ProductNameListBox
            // 
            this.ProductNameListBox.FormattingEnabled = true;
            this.ProductNameListBox.ItemHeight = 16;
            this.ProductNameListBox.Location = new System.Drawing.Point(30, 61);
            this.ProductNameListBox.Name = "ProductNameListBox";
            this.ProductNameListBox.Size = new System.Drawing.Size(167, 100);
            this.ProductNameListBox.TabIndex = 5;
            this.ProductNameListBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductNameListBox_KeyDown);
            this.ProductNameListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProductNameListBox_MouseDoubleClick);
            // 
            // ProductNameTextBox
            // 
            this.ProductNameTextBox.Location = new System.Drawing.Point(30, 33);
            this.ProductNameTextBox.Name = "ProductNameTextBox";
            this.ProductNameTextBox.Size = new System.Drawing.Size(167, 22);
            this.ProductNameTextBox.TabIndex = 0;
            this.ProductNameTextBox.TextChanged += new System.EventHandler(this.ProductNameTextBox_TextChanged);
            this.ProductNameTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductNameTextBox_KeyDown);
            this.ProductNameTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductNameTextBox_KeyUp);
            // 
            // ProductDescriptionTextBox
            // 
            this.ProductDescriptionTextBox.Location = new System.Drawing.Point(232, 33);
            this.ProductDescriptionTextBox.Name = "ProductDescriptionTextBox";
            this.ProductDescriptionTextBox.Size = new System.Drawing.Size(204, 22);
            this.ProductDescriptionTextBox.TabIndex = 1;
            this.ProductDescriptionTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ProductDescriptionTextBox_KeyDown);
            this.ProductDescriptionTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.ProductDescriptionTextBox_KeyUp);
            // 
            // PurchasesProductForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 169);
            this.Controls.Add(this.ProductDescriptionTextBox);
            this.Controls.Add(this.ProductNameTextBox);
            this.Controls.Add(this.ProductNameListBox);
            this.Controls.Add(this.ProductDescriptionListBox);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.ProductDescriptionLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Name = "PurchasesProductForm";
            this.Text = "PurchasesProductForm";
            this.Load += new System.EventHandler(this.SelectProductForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductDescriptionLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Button OkButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ListBox ProductDescriptionListBox;
        private System.Windows.Forms.ListBox ProductNameListBox;
        private System.Windows.Forms.TextBox ProductNameTextBox;
        private System.Windows.Forms.TextBox ProductDescriptionTextBox;
    }
}