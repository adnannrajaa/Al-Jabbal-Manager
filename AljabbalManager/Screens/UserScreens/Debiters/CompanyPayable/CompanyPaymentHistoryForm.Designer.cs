﻿namespace ASDBFramework.Screens.UserScreens.Debiters.CompanyPayable
{
    partial class CompanyPaymentHistoryForm
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
            this.PartyNameComboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.InvoiceNoTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.PrintButton = new System.Windows.Forms.Button();
            this.AmountRecivedTextBox = new System.Windows.Forms.TextBox();
            this.CashRecivedButton = new System.Windows.Forms.Button();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PartyPaymentHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.Invoice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PartyPaymentHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PartyNameComboBox
            // 
            this.PartyNameComboBox.FormattingEnabled = true;
            this.PartyNameComboBox.Location = new System.Drawing.Point(5, 39);
            this.PartyNameComboBox.Name = "PartyNameComboBox";
            this.PartyNameComboBox.Size = new System.Drawing.Size(223, 24);
            this.PartyNameComboBox.TabIndex = 0;
            this.PartyNameComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.PartyNameComboBox_KeyDown);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.PartyNameComboBox);
            this.panel1.Controls.Add(this.InvoiceNoTextBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.PrintButton);
            this.panel1.Controls.Add(this.AmountRecivedTextBox);
            this.panel1.Controls.Add(this.CashRecivedButton);
            this.panel1.Controls.Add(this.DiscountTextBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 438);
            this.panel1.TabIndex = 8;
            // 
            // InvoiceNoTextBox
            // 
            this.InvoiceNoTextBox.Location = new System.Drawing.Point(5, 115);
            this.InvoiceNoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.InvoiceNoTextBox.Name = "InvoiceNoTextBox";
            this.InvoiceNoTextBox.Size = new System.Drawing.Size(121, 22);
            this.InvoiceNoTextBox.TabIndex = 1;
            this.InvoiceNoTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.InvoiceNoTextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 95);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "Invoice No";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 79;
            this.label2.Text = "Amount Paid";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(134, 261);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(86, 31);
            this.PrintButton.TabIndex = 5;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            this.PrintButton.Click += new System.EventHandler(this.PrintButton_Click);
            // 
            // AmountRecivedTextBox
            // 
            this.AmountRecivedTextBox.Location = new System.Drawing.Point(5, 219);
            this.AmountRecivedTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.AmountRecivedTextBox.Name = "AmountRecivedTextBox";
            this.AmountRecivedTextBox.Size = new System.Drawing.Size(223, 22);
            this.AmountRecivedTextBox.TabIndex = 3;
            this.AmountRecivedTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AmountRecivedTextBox_KeyDown);
            // 
            // CashRecivedButton
            // 
            this.CashRecivedButton.Location = new System.Drawing.Point(12, 261);
            this.CashRecivedButton.Name = "CashRecivedButton";
            this.CashRecivedButton.Size = new System.Drawing.Size(116, 31);
            this.CashRecivedButton.TabIndex = 4;
            this.CashRecivedButton.Text = "Save";
            this.CashRecivedButton.UseVisualStyleBackColor = true;
            this.CashRecivedButton.Click += new System.EventHandler(this.CashRecivedButton_Click);
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Location = new System.Drawing.Point(5, 163);
            this.DiscountTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(194, 22);
            this.DiscountTextBox.TabIndex = 2;
            this.DiscountTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.DiscountTextBox_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 143);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.TabIndex = 81;
            this.label3.Text = "Discount";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Party Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.PartyPaymentHistoryDataGridView);
            this.panel2.Location = new System.Drawing.Point(245, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(706, 438);
            this.panel2.TabIndex = 9;
            // 
            // PartyPaymentHistoryDataGridView
            // 
            this.PartyPaymentHistoryDataGridView.AllowUserToAddRows = false;
            this.PartyPaymentHistoryDataGridView.AllowUserToDeleteRows = false;
            this.PartyPaymentHistoryDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PartyPaymentHistoryDataGridView.BackgroundColor = System.Drawing.Color.White;
            this.PartyPaymentHistoryDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PartyPaymentHistoryDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.PartyPaymentHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PartyPaymentHistoryDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Invoice,
            this.SubTotal,
            this.Discount,
            this.TotalAmount,
            this.Credit,
            this.Debit,
            this.Date});
            this.PartyPaymentHistoryDataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PartyPaymentHistoryDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PartyPaymentHistoryDataGridView.Name = "PartyPaymentHistoryDataGridView";
            this.PartyPaymentHistoryDataGridView.ReadOnly = true;
            this.PartyPaymentHistoryDataGridView.Size = new System.Drawing.Size(702, 434);
            this.PartyPaymentHistoryDataGridView.TabIndex = 159;
            // 
            // Invoice
            // 
            this.Invoice.HeaderText = "Invoice ";
            this.Invoice.Name = "Invoice";
            this.Invoice.ReadOnly = true;
            this.Invoice.Width = 90;
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "SubTotal";
            this.SubTotal.Name = "SubTotal";
            this.SubTotal.ReadOnly = true;
            this.SubTotal.Width = 90;
            // 
            // Discount
            // 
            this.Discount.HeaderText = "Discount";
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            this.Discount.Width = 90;
            // 
            // TotalAmount
            // 
            this.TotalAmount.HeaderText = "NetAmount";
            this.TotalAmount.Name = "TotalAmount";
            this.TotalAmount.ReadOnly = true;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.ReadOnly = true;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.ReadOnly = true;
            this.Date.Width = 90;
            // 
            // CompanyPaymentHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 448);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CompanyPaymentHistoryForm";
            this.Text = "CompanyPaymentHistoryForm";
            this.Load += new System.EventHandler(this.CompanyPaymentHistoryForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PartyPaymentHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox PartyNameComboBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox InvoiceNoTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.TextBox AmountRecivedTextBox;
        private System.Windows.Forms.Button CashRecivedButton;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView PartyPaymentHistoryDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Invoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;

    }
}