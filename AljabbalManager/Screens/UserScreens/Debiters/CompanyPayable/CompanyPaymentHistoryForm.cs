using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Utillities.Lists;
using ASDBFramework.Utillities;
using System.Data.SqlClient;
using ASDBFramework.Windows;
using ASDBFramework.Models.Users;

namespace ASDBFramework.Screens.UserScreens.Debiters.CompanyPayable
{
    public partial class CompanyPaymentHistoryForm : TemplateForm
    {
        int _PurchasesCompanyDetailId = 0;
        float _SubTotal = 0, _Discount = 0, _NetAmount = 0, _Credit = 0, _Debit = 0;
        public CompanyPaymentHistoryForm()
        {
            InitializeComponent();
        }

        private void CompanyPaymentHistoryForm_Load(object sender, EventArgs e)
        {
            ButtonEnabledStatus(false, false, false);
            ListData.LoadDataInToComboBox(PartyNameComboBox, "usp_PurchasePayablePartyName");
        }

        private void PartyNameComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataWithPartyNameOrInvoiceNo();
                ButtonEnabledStatus(true, false, false);
            }
        }

        private void InvoiceNoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataWithPartyNameOrInvoiceNo();
                ButtonEnabledStatus(true, false, false);
            }
        }

        private void LoadDataWithPartyNameOrInvoiceNo()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        PurchasesPaymentHistoryDetail.PurchasesCompanyDetailId, PurchasesCompanyDetail.InvoiceNo, PurchasesPaymentHistoryDetail.SubTotal, PurchasesPaymentHistoryDetail.Discount, 
                                                             PurchasesPaymentHistoryDetail.NetAmount, PurchasesPaymentHistoryDetail.CashPayed, PurchasesPaymentHistoryDetail.RemainingBalance, PurchasesPaymentHistoryDetail.CreatedDate
                                    FROM            PurchasesCompanyDetail INNER JOIN
                                                             PurchasesPaymentHistoryDetail ON PurchasesCompanyDetail.PurchasesCompanyDetailId = PurchasesPaymentHistoryDetail.PurchasesCompanyDetailId
                                    WHERE        (PurchasesCompanyDetail.CompanyName = @Name) OR
                                                             (PurchasesCompanyDetail.InvoiceNo = @InvoiceNo)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", PartyNameComboBox.Text);
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        PartyPaymentHistoryDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            int n = PartyPaymentHistoryDataGridView.Rows.Add();
                            _PurchasesCompanyDetailId = Convert.ToInt32(Items["PurchasesCompanyDetailId"].ToString());
                            _SubTotal = Convert.ToInt32(Items["SubTotal"].ToString());
                            _NetAmount = Convert.ToInt32(Items["NetAmount"].ToString());
                            _Debit = Convert.ToInt32(Items["RemainingBalance"].ToString());

                            PartyPaymentHistoryDataGridView.Rows[n].Cells[0].Value = Items["InvoiceNo"].ToString();
                            PartyPaymentHistoryDataGridView.Rows[n].Cells[1].Value = Items["SubTotal"].ToString();
                            PartyPaymentHistoryDataGridView.Rows[n].Cells[2].Value = Items["Discount"].ToString();
                            PartyPaymentHistoryDataGridView.Rows[n].Cells[3].Value = Items["NetAmount"].ToString();
                            PartyPaymentHistoryDataGridView.Rows[n].Cells[4].Value = Items["CashPayed"].ToString();
                            PartyPaymentHistoryDataGridView.Rows[n].Cells[5].Value = Items["RemainingBalance"].ToString();
                            PartyPaymentHistoryDataGridView.Rows[n].Cells[6].Value = Items["CreatedDate"].ToString();
                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void DiscountTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonEnabledStatus(true, true, false);
                if (InvoiceNoTextBox.Text.Trim() == string.Empty)
                {
                    InvoiceNoTextBox.Focus();
                    ASMessageBox.ShowErrorMessage("Invoice No Must Required.");
                }
                else
                {
                    if (!TodayLastUpdated())
                    {
                        InsertIntoPaymentHistory();
                    }
                    LoadDataWithPartyNameOrInvoiceNo();
                }
            }
        }

        private void InsertIntoPaymentHistory()
        {
            if (DiscountTextBox.Text.Trim() != string.Empty)
            {
                _Discount = Convert.ToInt32(DiscountTextBox.Text);
                _NetAmount -= _Discount;
                _Debit -= _Discount;
            }
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO PurchasesPaymentHistoryDetail
                         (PurchasesCompanyDetailId, SubTotal, Discount, NetAmount, CashPayed, RemainingBalance, CreatedBy, CreatedDate)
VALUES        (@PurchasesCompanyDetailId,@SubTotal,@Discount,@NetAmount,@CashPayed,@RemainingBalance,@CreatedBy,@CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@PurchasesCompanyDetailId", _PurchasesCompanyDetailId);
                        cmd.Parameters.AddWithValue("@SubTotal", _SubTotal);
                        cmd.Parameters.AddWithValue("@Discount", _Discount);
                        cmd.Parameters.AddWithValue("@NetAmount", _NetAmount);
                        cmd.Parameters.AddWithValue("@CashPayed", "0");
                        cmd.Parameters.AddWithValue("@RemainingBalance", _Debit);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();

                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private bool TodayLastUpdated()
        {
            if (DataExist())
            {
                UpdateTodayRecord();
                return true;
            }
            return false;
        }

        private void UpdateTodayRecord()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       PurchasesPaymentHistoryDetail
                                    SET                Discount = PurchasesPaymentHistoryDetail.Discount + @Discount, NetAmount = PurchasesPaymentHistoryDetail.NetAmount - @NetAmount, 
                                                             RemainingBalance = PurchasesPaymentHistoryDetail.RemainingBalance - @RemainingBalance
                                    FROM            PurchasesPaymentHistoryDetail INNER JOIN
                                                             PurchasesCompanyDetail ON PurchasesPaymentHistoryDetail.PurchasesCompanyDetailId = PurchasesCompanyDetail.PurchasesCompanyDetailId
                                    WHERE        (PurchasesPaymentHistoryDetail.CreatedDate = @CreatedDate) AND (PurchasesCompanyDetail.InvoiceNo = @InvoiceNo)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Discount", DiscountTextBox.Text);
                        cmd.Parameters.AddWithValue("@NetAmount", DiscountTextBox.Text);
                        cmd.Parameters.AddWithValue("@RemainingBalance", DiscountTextBox.Text);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private bool DataExist()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        1 
                            FROM            PurchasesPaymentHistoryDetail INNER JOIN
                                                     PurchasesCompanyDetail ON PurchasesPaymentHistoryDetail.PurchasesCompanyDetailId = PurchasesCompanyDetail.PurchasesCompanyDetailId
                            WHERE        (PurchasesPaymentHistoryDetail.CreatedDate = @CreatedDate) AND (PurchasesCompanyDetail.InvoiceNo = @InvoiceNo)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        if (reader.HasRows)
                        {
                            return true;
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
            return false;
        }

        private void AmountRecivedTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ButtonEnabledStatus(true, true, true);
                if (AmountRecivedTextBox.Text.Trim() == string.Empty)
                {
                    AmountRecivedTextBox.Focus();
                }
                else
                {
                    if (DataExist())
                    {
                        UpdateCashRecived();
                    }
                    else
                    {
                        InsertIntoPaymentHistoryCashRecived();
                    }
                    LoadDataWithPartyNameOrInvoiceNo();
                }
            }
        }

        private void InsertIntoPaymentHistoryCashRecived()
        {
            if (AmountRecivedTextBox.Text.Trim() != string.Empty)
            {
                _Credit = Convert.ToInt32(AmountRecivedTextBox.Text);
                _Debit -= _Credit;
            }
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO PurchasesPaymentHistoryDetail
                         (PurchasesCompanyDetailId, SubTotal, Discount, NetAmount, CashPayed, RemainingBalance, CreatedBy, CreatedDate)
VALUES       (@PurchasesCompanyDetailId, @SubTotal, @Discount, @NetAmount, @CashPayed, @RemainingBalance, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@PurchasesCompanyDetailId", _PurchasesCompanyDetailId);
                        cmd.Parameters.AddWithValue("@SubTotal", _SubTotal);
                        cmd.Parameters.AddWithValue("@Discount", _Discount);
                        cmd.Parameters.AddWithValue("@NetAmount", _NetAmount);
                        cmd.Parameters.AddWithValue("@CashPayed", AmountRecivedTextBox.Text);
                        cmd.Parameters.AddWithValue("@RemainingBalance", _Debit);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void UpdateCashRecived()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       PurchasesPaymentHistoryDetail
                            SET                CashPayed = PurchasesPaymentHistoryDetail.CashPayed + @CashPayed, RemainingBalance = PurchasesPaymentHistoryDetail.RemainingBalance - @RemainingBalance
                            FROM            PurchasesPaymentHistoryDetail INNER JOIN
                                                     PurchasesCompanyDetail ON PurchasesPaymentHistoryDetail.PurchasesCompanyDetailId = PurchasesCompanyDetail.PurchasesCompanyDetailId
                            WHERE        (PurchasesPaymentHistoryDetail.CreatedDate = @CreatedDate) AND (PurchasesCompanyDetail.InvoiceNo = @InvoiceNo)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@CashPayed", AmountRecivedTextBox.Text);
                        cmd.Parameters.AddWithValue("@RemainingBalance", AmountRecivedTextBox.Text);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void CashRecivedButton_Click(object sender, EventArgs e)
        {
            UpdatePurchasesPaymentRecord();
        }

        private void UpdatePurchasesPaymentRecord()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       PurchasesPaymentDetail
SET                Discount =Discount+ @Discount, NetAmount =NetAmount- @Discount, CashPayed =CashPayed+ @CashPayed, RemainingBalance =RemainingBalance-(@Discount+@CashPayed), CreatedBy = @CreatedBy, CreatedDate = @CreatedDate
FROM            PurchasesPaymentDetail INNER JOIN
                         PurchasesCompanyDetail ON PurchasesPaymentDetail.PurchasesCompanyDetailId = PurchasesCompanyDetail.PurchasesCompanyDetailId
WHERE        (PurchasesCompanyDetail.InvoiceNo = @InvoiceNo)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Discount", _Discount);
                        cmd.Parameters.AddWithValue("@CashPayed", AmountRecivedTextBox.Text);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("Record Updated Successfully.");

                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            if (InvoiceNoTextBox.Text.Trim() != string.Empty)
            {
                PrintCompanyPaymentHistoryForm PCPHS = new PrintCompanyPaymentHistoryForm();
                PCPHS.GetPurchasesToCompanyInvoiceNo(Convert.ToInt32(InvoiceNoTextBox.Text));
                PCPHS.Show();
            }
        }
        private void ButtonEnabledStatus(bool v1,bool v2,bool v3)
        {
            DiscountTextBox.Enabled = v1;
            AmountRecivedTextBox.Enabled = v2;
            CashRecivedButton.Enabled = v3;
        }


      
    }
}
