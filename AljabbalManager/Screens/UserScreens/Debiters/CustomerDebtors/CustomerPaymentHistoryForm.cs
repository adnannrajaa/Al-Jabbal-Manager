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
using ASDBFramework.Windows;
using System.Data.SqlClient;
using ASDBFramework.Utillities;
using ASDBFramework.Models.Users;

namespace ASDBFramework.Screens.UserScreens.Debiters.CustomerDebtors
{
    public partial class CustomerPaymentHistoryForm : TemplateForm
    {
        int _SalesCustomerDetailId = 0;
        float _SubTotal = 0, _Discount = 0, _NetAmount = 0, _Credit = 0, _Debit = 0;

        public CustomerPaymentHistoryForm()
        {
            InitializeComponent();
        }

        private void CustomerPaymentHistoryForm_Load(object sender, EventArgs e)
        {
            ListData.LoadDataInToComboBox(CustomerNameComboBox, "usp_SalesDebitorCustomerName");
            ButtonEnabledStatus(false, false, false);
        }

        private void CustomerNameComboBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataWithCustomerName();
                ButtonEnabledStatus(true, false, false);
            }
        }

        private void LoadDataWithCustomerName()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        SalesCustomerPaymentHistoryDetail.SalesCustomerDetailId,SalesCustomerDetail.InvoiceNo, SalesCustomerPaymentHistoryDetail.SubTotal, SalesCustomerPaymentHistoryDetail.CreatedDate as 'Date', SalesCustomerPaymentHistoryDetail.Discount, 
                                                             SalesCustomerPaymentHistoryDetail.NetAmount, SalesCustomerPaymentHistoryDetail.CashRecived, SalesCustomerPaymentHistoryDetail.RemainingBalance
                                    FROM            SalesCustomerDetail INNER JOIN
                                                             SalesCustomerPaymentHistoryDetail ON SalesCustomerDetail.SalesCustomerDetailId = SalesCustomerPaymentHistoryDetail.SalesCustomerDetailId
                                    WHERE        (SalesCustomerDetail.CustomerName = @Name) OR
                                                             (SalesCustomerDetail.InvoiceNo = @InvoiceNo)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", CustomerNameComboBox.Text);
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        CustomerPaymentHistoryDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            int n = CustomerPaymentHistoryDataGridView.Rows.Add();
                            _SalesCustomerDetailId = Convert.ToInt32(Items["SalesCustomerDetailId"].ToString());
                            _SubTotal = Convert.ToInt32(Items["SubTotal"].ToString());
                            _NetAmount = Convert.ToInt32(Items["NetAmount"].ToString());
                            _Debit = Convert.ToInt32(Items["RemainingBalance"].ToString());

                            CustomerPaymentHistoryDataGridView.Rows[n].Cells[0].Value = Items["InvoiceNo"].ToString();
                            CustomerPaymentHistoryDataGridView.Rows[n].Cells[1].Value = Items["SubTotal"].ToString();
                            CustomerPaymentHistoryDataGridView.Rows[n].Cells[2].Value = Items["Discount"].ToString();
                            CustomerPaymentHistoryDataGridView.Rows[n].Cells[3].Value = Items["NetAmount"].ToString();
                            CustomerPaymentHistoryDataGridView.Rows[n].Cells[4].Value = Items["CashRecived"].ToString();
                            CustomerPaymentHistoryDataGridView.Rows[n].Cells[5].Value = Items["RemainingBalance"].ToString();
                            CustomerPaymentHistoryDataGridView.Rows[n].Cells[6].Value = Items["Date"].ToString();
                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void InvoiceNoTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoadDataWithCustomerName();
                ButtonEnabledStatus(true, false, false);
            }
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
                    LoadDataWithCustomerName();
                }
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
                string _Command = @"UPDATE       SalesCustomerPaymentHistoryDetail
                                    SET                Discount =Discount+@Discount, NetAmount =NetAmount -@NetAmount , RemainingBalance =RemainingBalance - @RemainingBalance 
                                    WHERE        (InvoiceNo = @InvoiceNo) and CreatedDate=@CreatedDate";
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
                                    FROM            SalesCustomerPaymentHistoryDetail
                                    Where CreatedDate = @CreatedDate And InvoiceNo = @InvoiceNo";
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
                string _Command = @"INSERT INTO SalesCustomerPaymentHistoryDetail
                                 (SalesCustomerDetailId, InvoiceNo, SubTotal, Discount, NetAmount, CashRecived, RemainingBalance, CreatedBy, CreatedDate)
                    VALUES        (@SalesCustomerDetailId,@InvoiceNo,@SubTotal,@Discount,@NetAmount,@CashRecived,@RemainingBalance,@CreatedBy,@CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@SalesCustomerDetailId", _SalesCustomerDetailId);
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@SubTotal", _SubTotal);
                        cmd.Parameters.AddWithValue("@Discount", _Discount);
                        cmd.Parameters.AddWithValue("@NetAmount", _NetAmount);
                        cmd.Parameters.AddWithValue("@CashRecived","0");
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
                    LoadDataWithCustomerName();
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
                string _Command = @"INSERT INTO SalesCustomerPaymentHistoryDetail
                                 (SalesCustomerDetailId, InvoiceNo, SubTotal, Discount, NetAmount, CashRecived, RemainingBalance, CreatedBy, CreatedDate)
                    VALUES        (@SalesCustomerDetailId,@InvoiceNo,@SubTotal,@Discount,@NetAmount,@CashRecived,@RemainingBalance,@CreatedBy,@CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@SalesCustomerDetailId", _SalesCustomerDetailId);
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@SubTotal", _SubTotal);
                        cmd.Parameters.AddWithValue("@Discount", _Discount);
                        cmd.Parameters.AddWithValue("@NetAmount", _NetAmount);
                        cmd.Parameters.AddWithValue("@CashRecived", AmountRecivedTextBox.Text);
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
                string _Command = @"UPDATE       SalesCustomerPaymentHistoryDetail
                                    SET               CashRecived=CashRecived+@CashRecived, RemainingBalance =RemainingBalance - @RemainingBalance 
                                    WHERE        (InvoiceNo = @InvoiceNo) and CreatedDate=@CreatedDate";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@CashRecived", AmountRecivedTextBox.Text);
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
            UpdateCustomerPaymentDetail();
        }

        private void UpdateCustomerPaymentDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       SalesCustomerPaymentDetail
SET                Discount = Discount + @Discount, NetAmount = NetAmount - @Discount, CashRecived = CashRecived + @CashRecived, RemainingBalance = RemainingBalance - (@CashRecived + @Discount)
WHERE        (InvoiceNo = @InvoiceNo)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Discount", _Discount);
                        cmd.Parameters.AddWithValue("@CashRecived", AmountRecivedTextBox.Text);
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
                PrintPaymentHistoryForm PPHS = new PrintPaymentHistoryForm();
                PPHS.GetSaleToCustomerInvoiceNo(Convert.ToInt32(InvoiceNoTextBox.Text));
                PPHS.Show();
            }
        }

        private void ButtonEnabledStatus(bool v1, bool v2, bool v3)
        {
            DiscountTextBox.Enabled = v1;
            AmountRecivedTextBox.Enabled = v2;
            CashRecivedButton.Enabled = v3;
        }

       
    }
}
