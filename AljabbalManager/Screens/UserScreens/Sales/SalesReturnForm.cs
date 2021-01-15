using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Windows;
using ASDBFramework.Utillities;
using System.Data.SqlClient;
using ASDBFramework.Models.Users;

namespace ASDBFramework.Screens.UserScreens
{
    public partial class SalesReturnForm : TemplateForm
    {
        DataTable dtProducts = new DataTable();
        float SubTotal = 0;
        int _SaleReturnCustomerDetailId = 0;
        int No = 1;
        public SalesReturnForm()
        {
            InitializeComponent();
        }

        private void SalesReturnForm_Load(object sender, EventArgs e)
        {
            dtProducts.Columns.Add("SNo").ToString();
            dtProducts.Columns.Add("ProductCode").ToString();
            dtProducts.Columns.Add("ProductName").ToString();
            dtProducts.Columns.Add("Unit").ToString();
            dtProducts.Columns.Add("Quantity").ToString();
            dtProducts.Columns.Add("RetailPrice").ToString();
            dtProducts.Columns.Add("Total").ToString();
            InvoiceNoTextBox.Focus();
            ListTodaySalesReturn();

        }
        private void ListTodaySalesReturn()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        SaleReturnCustomerDetail.InvoiceNo AS 'BillNo', SaleReturnCustomerDetail.CustomerName as 'Customer', SaleReturnCustomerPaymentDetail.NetAmount AS 'TotalAmount'
                                     FROM            SaleReturnCustomerDetail INNER JOIN
                         SaleReturnCustomerPaymentDetail ON SaleReturnCustomerDetail.SaleReturnCustomerDetailId = SaleReturnCustomerPaymentDetail.SaleReturnCustomerDetailId
                                            WHERE        (SaleReturnCustomerDetail.CreatedDate = @TodayDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@TodayDate", Convert.ToDateTime(DateTime.Today));
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable mydt = new DataTable();
                        da.Fill(mydt);
                        TodaySaleReturnDataGridView.DataSource = mydt;
                        TodaySaleReturnDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }

                ListTotalTodaySaleReturn();
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in ListTodaySalesReturn:\n" + ex.Message);

            }
        }
        private void ListTotalTodaySaleReturn()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        SUM(NetAmount) AS 'TotalAmount'
                                            FROM            SaleReturnCustomerPaymentDetail
                                            WHERE        (CreatedDate = @TodayDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@TodayDate", Convert.ToDateTime(DateTime.Today));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        TotalSaleLlabel.Text = reader["TotalAmount"].ToString();
                    }
                }


            }

            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error ListTotalTodaySaleReturn:\n" + ex.Message);


            }
        }
        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                SaleReturnInvoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SaleReturnInvoiceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                AddToPurchaseDataGridView();
                ClearProductInformation();
            }
        }
        private bool IsFormValid()
        {
            if (ProductCodeTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Code is required. ");
                ProductCodeTextBox.Focus();
                return false;
            }
            if (ProductDescriptionTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Name is required. ");
                ProductDescriptionTextBox.Focus();
                return false;
            }
            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Quantity is required. ");
                QuantityTextBox.Focus();
                return false;
            }
            if (RetailPriceTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Retail Price is required. ");
                RetailPriceTextBox.Focus();
                return false;
            }
            if (TotalTextBox.Text.Trim() == string.Empty)
            {
                TotalTextBox.Focus();
                return false;
            }
            return true;
        }
        private void AddToPurchaseDataGridView()
        {
            float _Total = Convert.ToInt32(RetailPriceTextBox.Text) * Convert.ToInt32(QuantityTextBox.Text);
            DataRow ProductAdd = dtProducts.NewRow();
            ProductAdd["SNo"] = No;
            ProductAdd["ProductCode"] = ProductCodeTextBox.Text;
            ProductAdd["ProductName"] = ProductDescriptionTextBox.Text;
            ProductAdd["Unit"] = UnitTextBox.Text;
            ProductAdd["Quantity"] = QuantityTextBox.Text;
            ProductAdd["RetailPrice"] = RetailPriceTextBox.Text;
            ProductAdd["Total"] = _Total;
            dtProducts.Rows.Add(ProductAdd);
            SaleReturnInvoiceDataGridView.DataSource = dtProducts;
            No = No + 1;
            SubTotal += _Total;
            NetAmountLabel.Text = SubTotal.ToString();
        }
        private void ClearProductInformation()
        {
            ProductCodeTextBox.Text = string.Empty;
            ProductDescriptionTextBox.Text = string.Empty;
            UnitTextBox.Text = string.Empty;
            QuantityTextBox.Text = string.Empty;
            RetailPriceTextBox.Text = string.Empty;
            TotalTextBox.Text = string.Empty;
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearProductInformation();
        }

        private void CashRecivedButton_Click(object sender, EventArgs e)
        {
            if (CashPayedTextBox.Text.Trim() == string.Empty)
            {
                CashPayedTextBox.Text = "0";
                CashPayedTextBox.Focus();
            }
            else
            {
                CreditLabel.Text = CashPayedTextBox.Text;
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int Rows;

            SubTotal = 0;
            try
            {
                Rows = Convert.ToInt32(SaleReturnInvoiceDataGridView.CurrentCell.RowIndex.ToString());
                dtProducts.Rows.RemoveAt(Convert.ToInt32(SaleReturnInvoiceDataGridView.CurrentCell.RowIndex.ToString()));
                if (Rows == 0)
                {
                    No = 1;
                }
                if (Rows > 0)
                {
                    foreach (DataRow dataRow in dtProducts.Rows)
                    {

                        SubTotal += Convert.ToInt32(dataRow["Total"].ToString());
                        
                        NetAmountLabel.Text = SubTotal.ToString();
                       


                    }
                    No = No - 1;
                }
            }
            catch (Exception)
            {
                SubTotal = 0;
               
                NetAmountLabel.Text = SubTotal.ToString();
               
                ASMessageBox.ShowErrorMessage("No More Row to delete");

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerInformValid())
            {
                SaveCustomerRecord();
                GetLatestCustomerId();
                SaveSaleReturnRecord();
                SavePaymentRecordRecord();
                ListTodaySalesReturn();
                SaveButton.Enabled = false;
                ASMessageBox.ShowSucessMessage("Record Added Successfully.");
               
            }
        }

        private void SavePaymentRecordRecord()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO SaleReturnCustomerPaymentDetail
                         (SaleReturnCustomerDetailId, InvoiceNo, NetAmount, CashPayed, CreatedBy, CreatedDate)
           VALUES        (@SaleReturnCustomerDetailId,@InvoiceNo, @NetAmount, @CashPayed, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@SaleReturnCustomerDetailId", _SaleReturnCustomerDetailId);
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@NetAmount", NetAmountLabel.Text);
                        cmd.Parameters.AddWithValue("@CashPayed", CreditLabel.Text);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
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
        private void SaveSaleReturnRecord()
        {
            try
            {
                float quantity = 0;
                int _ProductCode = 0;
                string conString = AppSetting.ConnectionString();
                string _CommandInsert = @"INSERT INTO SaleReturnCustomerProductsDetail
                         (SaleReturnCustomerDetailId, ProductCode, ProductDescription, ProductUnit, ProductQuantity, RetailPrice, Total, CreatedBy, CreatedDate)
           VALUES        (@SaleReturnCustomerDetailId, @ProductCode, @ProductDescription, @ProductUnit, @ProductQunatity, @RetailPrice, @Total, @CreatedBy, @CreatedDate)";

                string _ComandUpdate = @"UPDATE       ProductStock
                                        SET                ProductQuantity =ProductQuantity+@ProductQuantity 
                                        where ProductCode =@ProductCode";
                foreach (DataRow dr in dtProducts.Rows)
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(_CommandInsert, conn))
                        {
                            cmd.Parameters.AddWithValue("@SaleReturnCustomerDetailId", _SaleReturnCustomerDetailId);
                            cmd.Parameters.AddWithValue("@ProductCode", dr["ProductCode"].ToString());
                            cmd.Parameters.AddWithValue("@ProductDescription", dr["ProductName"].ToString());
                            cmd.Parameters.AddWithValue("@ProductUnit", dr["Unit"].ToString());
                            cmd.Parameters.AddWithValue("@ProductQunatity", dr["Quantity"].ToString());
                            cmd.Parameters.AddWithValue("@RetailPrice", dr["RetailPrice"].ToString());
                            cmd.Parameters.AddWithValue("@Total", dr["Total"].ToString());
                            cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                            cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                    }

                    quantity = Convert.ToInt32(dr["Quantity"].ToString());
                    _ProductCode = Convert.ToInt32(dr["ProductCode"].ToString());

                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(_ComandUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductQuantity", quantity);
                            cmd.Parameters.AddWithValue("@ProductCode", _ProductCode);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }
        private void GetLatestCustomerId()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        TOP (1) SaleReturnCustomerDetailId
                        FROM            SaleReturnCustomerDetail
                            ORDER BY SaleReturnCustomerDetailId DESC";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        _SaleReturnCustomerDetailId = Convert.ToInt32(reader["SaleReturnCustomerDetailId"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }
        private void SaveCustomerRecord()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO SaleReturnCustomerDetail
                         (InvoiceNo, CustomerName, CustomerCellNo, CreatedBy, CreatedDate)
           VALUES        (@InvoiceNo, @CustomerName, @CustomerCellNo, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@CustomerCellNo", CustomerCellTextBox.Text);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
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
        private bool CustomerInformValid()
        {
            if (InvoiceNoTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Invoice No is required. ");
                InvoiceNoTextBox.Focus();
                return false;
            }
            if (CustomerNameTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Customer Name is required. ");
                CustomerNameTextBox.Focus();
                return false;
            }
            if (Convert.ToInt32(NetAmountLabel.Text) == 0)
            {
                ASMessageBox.ShowErrorMessage("No Record Found.");
                return false;
            }
            return true;
        }

        private void ResetTextButton_Click(object sender, EventArgs e)
        {
            ClearCustomerInformation();
            ClearProductInformation();
            CashPayedTextBox.Text = string.Empty;
            CreditLabel.Text = string.Empty; ;
            NetAmountLabel.Text = string.Empty;
            SubTotal = 0;
            dtProducts.Rows.Clear();
            SaveButton.Enabled = true;
        }
        private void ClearCustomerInformation()
        {
            InvoiceNoTextBox.Text = string.Empty;
            CustomerCellTextBox.Text = string.Empty;
            CustomerNameTextBox.Text = string.Empty;
           
        }

        private void ProductCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                ClearProductInformation();
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    if (GetDataFromProductStock())
                    {
                        GetDataFromProductDetail();
                    }
                    

                }
            }
        }
        private void GetDataFromProductDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"Select ProductDescription,ProductUnit From ProductsDetail where ProductCode=@ProductCode";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        ProductDescriptionTextBox.Text = reader["ProductDescription"].ToString();
                        UnitTextBox.Text = reader["ProductUnit"].ToString();
                    }
                }


            }

            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage(ex.Message);
                ClearProductInformation();
            }
        }
        private bool GetDataFromProductStock()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ProductQuantity, ProductRetailPrice
                                   FROM            ProductStock
                                   WHERE        (ProductCode = @ProductCode)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        RetailPriceTextBox.Text = reader["ProductRetailPrice"].ToString();
                        return true;
                    }
                }

            }

            catch (Exception)
            {
                ASMessageBox.ShowErrorMessage("Stock Not Exist. ");
                ClearProductInformation();

            }
            return false;
        }

        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                TotalTextBox.Text = (Convert.ToInt32(QuantityTextBox.Text) * Convert.ToInt32(RetailPriceTextBox.Text)).ToString();
            }
            catch (Exception)
            {

            }
        }
    }
}
