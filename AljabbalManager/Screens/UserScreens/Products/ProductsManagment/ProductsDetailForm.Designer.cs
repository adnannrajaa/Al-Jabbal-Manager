namespace ASDBFramework.Screens.UserScreens.Products
{
    partial class ProductsDetailForm
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
            this.ProductsDetailDataGridView = new System.Windows.Forms.DataGridView();
            this.SNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.ProductUnitComboBox = new System.Windows.Forms.ComboBox();
            this.ProductDescriptionComboBox = new System.Windows.Forms.ComboBox();
            this.ProductNameComboBox = new System.Windows.Forms.ComboBox();
            this.ProductCodeTextBox = new System.Windows.Forms.TextBox();
            this.ProductCodeLabel = new System.Windows.Forms.Label();
            this.ProductDescriptionLabel = new System.Windows.Forms.Label();
            this.ProductNameLabel = new System.Windows.Forms.Label();
            this.ProductUnitLabel = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDetailDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ProductsDetailDataGridView
            // 
            this.ProductsDetailDataGridView.AllowUserToAddRows = false;
            this.ProductsDetailDataGridView.AllowUserToDeleteRows = false;
            this.ProductsDetailDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.ProductsDetailDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductsDetailDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SNo,
            this.ProductCode,
            this.ProductName,
            this.ProductDescription,
            this.ProductUnit});
            this.ProductsDetailDataGridView.GridColor = System.Drawing.Color.Silver;
            this.ProductsDetailDataGridView.Location = new System.Drawing.Point(10, 96);
            this.ProductsDetailDataGridView.Name = "ProductsDetailDataGridView";
            this.ProductsDetailDataGridView.ReadOnly = true;
            this.ProductsDetailDataGridView.Size = new System.Drawing.Size(1009, 505);
            this.ProductsDetailDataGridView.TabIndex = 10;
            this.ProductsDetailDataGridView.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ProductsDetailDataGridView_MouseDoubleClick);
            // 
            // SNo
            // 
            this.SNo.HeaderText = "SNo";
            this.SNo.Name = "SNo";
            this.SNo.ReadOnly = true;
            this.SNo.Width = 60;
            // 
            // ProductCode
            // 
            this.ProductCode.HeaderText = "Product Code";
            this.ProductCode.Name = "ProductCode";
            this.ProductCode.ReadOnly = true;
            this.ProductCode.Width = 130;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Product Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            this.ProductName.Width = 200;
            // 
            // ProductDescription
            // 
            this.ProductDescription.HeaderText = "Product Description";
            this.ProductDescription.Name = "ProductDescription";
            this.ProductDescription.ReadOnly = true;
            this.ProductDescription.Width = 460;
            // 
            // ProductUnit
            // 
            this.ProductUnit.HeaderText = "Product Unit";
            this.ProductUnit.Name = "ProductUnit";
            this.ProductUnit.ReadOnly = true;
            this.ProductUnit.Width = 115;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(764, 42);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(59, 30);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(703, 42);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(55, 30);
            this.AddButton.TabIndex = 8;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ProductUnitComboBox
            // 
            this.ProductUnitComboBox.FormattingEnabled = true;
            this.ProductUnitComboBox.Location = new System.Drawing.Point(559, 48);
            this.ProductUnitComboBox.Name = "ProductUnitComboBox";
            this.ProductUnitComboBox.Size = new System.Drawing.Size(121, 24);
            this.ProductUnitComboBox.TabIndex = 7;
            // 
            // ProductDescriptionComboBox
            // 
            this.ProductDescriptionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.ProductDescriptionComboBox.FormattingEnabled = true;
            this.ProductDescriptionComboBox.Location = new System.Drawing.Point(346, 48);
            this.ProductDescriptionComboBox.Name = "ProductDescriptionComboBox";
            this.ProductDescriptionComboBox.Size = new System.Drawing.Size(171, 21);
            this.ProductDescriptionComboBox.TabIndex = 6;
            // 
            // ProductNameComboBox
            // 
            this.ProductNameComboBox.FormattingEnabled = true;
            this.ProductNameComboBox.Location = new System.Drawing.Point(160, 48);
            this.ProductNameComboBox.Name = "ProductNameComboBox";
            this.ProductNameComboBox.Size = new System.Drawing.Size(141, 24);
            this.ProductNameComboBox.TabIndex = 5;
            this.ProductNameComboBox.SelectedIndexChanged += new System.EventHandler(this.ProductNameComboBox_SelectedIndexChanged);
            this.ProductNameComboBox.TextChanged += new System.EventHandler(this.ProductNameComboBox_TextChanged);
            // 
            // ProductCodeTextBox
            // 
            this.ProductCodeTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCodeTextBox.Location = new System.Drawing.Point(12, 49);
            this.ProductCodeTextBox.Name = "ProductCodeTextBox";
            this.ProductCodeTextBox.Size = new System.Drawing.Size(100, 23);
            this.ProductCodeTextBox.TabIndex = 4;
            // 
            // ProductCodeLabel
            // 
            this.ProductCodeLabel.AutoSize = true;
            this.ProductCodeLabel.Location = new System.Drawing.Point(9, 25);
            this.ProductCodeLabel.Name = "ProductCodeLabel";
            this.ProductCodeLabel.Size = new System.Drawing.Size(90, 16);
            this.ProductCodeLabel.TabIndex = 3;
            this.ProductCodeLabel.Text = "Product Code";
            // 
            // ProductDescriptionLabel
            // 
            this.ProductDescriptionLabel.AutoSize = true;
            this.ProductDescriptionLabel.Location = new System.Drawing.Point(343, 25);
            this.ProductDescriptionLabel.Name = "ProductDescriptionLabel";
            this.ProductDescriptionLabel.Size = new System.Drawing.Size(125, 16);
            this.ProductDescriptionLabel.TabIndex = 2;
            this.ProductDescriptionLabel.Text = "Product Description";
            // 
            // ProductNameLabel
            // 
            this.ProductNameLabel.AutoSize = true;
            this.ProductNameLabel.Location = new System.Drawing.Point(157, 25);
            this.ProductNameLabel.Name = "ProductNameLabel";
            this.ProductNameLabel.Size = new System.Drawing.Size(94, 16);
            this.ProductNameLabel.TabIndex = 1;
            this.ProductNameLabel.Text = "Product Name";
            // 
            // ProductUnitLabel
            // 
            this.ProductUnitLabel.AutoSize = true;
            this.ProductUnitLabel.Location = new System.Drawing.Point(556, 25);
            this.ProductUnitLabel.Name = "ProductUnitLabel";
            this.ProductUnitLabel.Size = new System.Drawing.Size(80, 16);
            this.ProductUnitLabel.TabIndex = 0;
            this.ProductUnitLabel.Text = "Product Unit";
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(829, 42);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(59, 30);
            this.ClearButton.TabIndex = 11;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // ProductsDetailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 675);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.ProductsDetailDataGridView);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ProductUnitComboBox);
            this.Controls.Add(this.ProductDescriptionComboBox);
            this.Controls.Add(this.ProductNameComboBox);
            this.Controls.Add(this.ProductCodeTextBox);
            this.Controls.Add(this.ProductCodeLabel);
            this.Controls.Add(this.ProductDescriptionLabel);
            this.Controls.Add(this.ProductNameLabel);
            this.Controls.Add(this.ProductUnitLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductsDetailForm";
            this.Text = "ProductsDetailForm";
            this.Load += new System.EventHandler(this.ProductsDetailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductsDetailDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ProductUnitLabel;
        private System.Windows.Forms.Label ProductNameLabel;
        private System.Windows.Forms.Label ProductDescriptionLabel;
        private System.Windows.Forms.Label ProductCodeLabel;
        private System.Windows.Forms.TextBox ProductCodeTextBox;
        private System.Windows.Forms.ComboBox ProductNameComboBox;
        private System.Windows.Forms.ComboBox ProductDescriptionComboBox;
        private System.Windows.Forms.ComboBox ProductUnitComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.DataGridView ProductsDetailDataGridView;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductUnit;
    }
}