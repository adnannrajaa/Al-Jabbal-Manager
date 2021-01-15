using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Utillities;
using System.Data.SqlClient;
using ASDBFramework.Windows;

namespace ASDBFramework.Screens
{
    public partial class NotificationForm : TemplateForm
    {
        public NotificationForm()
        {
            InitializeComponent();
        }

        private void NotificationForm_Load(object sender, EventArgs e)
        {
           // ResetButton.Visible = false;
            LoadDataIntoStockDataGridView();
            LoadDataIntoCustomerDebitorDataGridView();
            LoadDataIntoCompaynPayableDataGridView();
        }

        private void LoadDataIntoCompaynPayableDataGridView()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        PurchasesCompanyDetail.InvoiceNo AS 'Invoice', PurchasesCompanyDetail.CompanyName AS 'PartyName', PurchasesCompanyDetail.CompanyCellNo AS 'PhoneNo', 
                         PurchasesPaymentDetail.NetAmount AS 'Balance', PurchasesPaymentDetail.CashPayed AS 'AmountPayed', PurchasesPaymentDetail.CreatedDate AS 'InvoiceDate', PurchasesPaymentDetail.DuePayment as 'DuePayment', 
                         PurchasesPaymentDetail.DuePaymentDate AS 'DuePaymentDate'
                         FROM            PurchasesCompanyDetail INNER JOIN
                         PurchasesPaymentDetail ON PurchasesCompanyDetail.PurchasesCompanyDetailId = PurchasesPaymentDetail.PurchasesCompanyDetailId
                         WHERE        (PurchasesPaymentDetail.RemainingBalance > 0) AND (PurchasesPaymentDetail.DuePaymentDate <= @DuePaymentDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@DuePaymentDate", DateTime.Today);
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        CompanyPayableDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            // CompanyPayableDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            CompanyPayableDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            int n = CompanyPayableDataGridView.Rows.Add();
                            CompanyPayableDataGridView.Rows[n].Cells[0].Value = Items["Invoice"].ToString();
                            CompanyPayableDataGridView.Rows[n].Cells[1].Value = Items["PartyName"].ToString();
                            CompanyPayableDataGridView.Rows[n].Cells[2].Value = Items["PhoneNo"].ToString();
                            CompanyPayableDataGridView.Rows[n].Cells[3].Value = Items["Balance"].ToString();
                            CompanyPayableDataGridView.Rows[n].Cells[4].Value = Items["AmountPayed"].ToString();
                            CompanyPayableDataGridView.Rows[n].Cells[5].Value = Items["InvoiceDate"].ToString();
                            CompanyPayableDataGridView.Rows[n].Cells[6].Value = Items["DuePayment"].ToString();
                            CompanyPayableDataGridView.Rows[n].Cells[7].Value = Items["DuePaymentDate"].ToString();
                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void LoadDataIntoCustomerDebitorDataGridView()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        SalesCustomerDetail.InvoiceNo as 'Invoice',
                                                 SalesCustomerDetail.CustomerName AS 'Customer Name',
                                                 SalesCustomerDetail.CustomerCellNo AS 'Phone No', 
                                                 SalesCustomerPaymentDetail.RemainingBalance AS 'Due Payment', 
                                                 SalesCustomerPaymentDetail.DuePaymentDate AS 'Due Payment Date'
                                  FROM            SalesCustomerDetail INNER JOIN
                                                  SalesCustomerPaymentDetail ON SalesCustomerDetail.SalesCustomerDetailId = SalesCustomerPaymentDetail.SalesCustomerDetailId
                                  WHERE        (SalesCustomerPaymentDetail.RemainingBalance > 0) AND (SalesCustomerPaymentDetail.DuePaymentDate <= @DuePaymentDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@DuePaymentDate", DateTime.Today);
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        CustomerDebitorDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            // CustomerDebitorDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            CustomerDebitorDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            int n = CustomerDebitorDataGridView.Rows.Add();
                            CustomerDebitorDataGridView.Rows[n].Cells[0].Value = Items["Invoice"].ToString();
                            CustomerDebitorDataGridView.Rows[n].Cells[1].Value = Items["Customer Name"].ToString();
                            CustomerDebitorDataGridView.Rows[n].Cells[2].Value = Items["Phone No"].ToString();
                            CustomerDebitorDataGridView.Rows[n].Cells[3].Value = Items["Due Payment"].ToString();
                            CustomerDebitorDataGridView.Rows[n].Cells[4].Value = Items["Due Payment Date"].ToString();
                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
            
        }
        private void LoadDataIntoStockDataGridView()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        ProductsDetail.ProductCode AS 'PID', ProductsDetail.ProductDescription AS 'Product Description', 
                                                 ProductsDetail.ProductUnit AS 'Unit', ProductStock.ProductQuantity AS 'Quantity', 
                                                 ProductStock.ProductRetailPrice AS 'Price', ProductStock.OutOfStock AS 'Shortage Limit',
                                                 ProductStock.CreatedDate AS 'Date'
                                 FROM            ProductsDetail INNER JOIN
                                                 ProductStock ON ProductsDetail.ProductCode = ProductStock.ProductCode
                                 WHERE        (ProductStock.ProductQuantity < ProductStock.OutOfStock)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {

                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        ShortProductsDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                           // ShortProductsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            ShortProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            int n = ShortProductsDataGridView.Rows.Add();
                            ShortProductsDataGridView.Rows[n].Cells[0].Value = Items["PID"].ToString();
                            ShortProductsDataGridView.Rows[n].Cells[1].Value = Items["Product Description"].ToString();
                            ShortProductsDataGridView.Rows[n].Cells[2].Value = Items["Quantity"].ToString();
                            ShortProductsDataGridView.Rows[n].Cells[3].Value = Items["Shortage Limit"].ToString();
                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetExpenseAndEmployees();
            ResetProductsData();
            //ResetProductKey();
            ResetProductPurchasesData();
            ResetProductSalesData();
            ResetShareHolderDetails();
            ResetTokenSalesDetails();
            ResetTokenPurchasesDetails();
            ASMessageBox.ShowSucessMessage("Reset Successfull.");
            LoadDataIntoStockDataGridView();
            LoadDataIntoCustomerDebitorDataGridView();
            LoadDataIntoCompaynPayableDataGridView();
        }

        private void ResetTokenPurchasesDetails()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM TokenPurchases";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetTokenSalesDetails()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM TokenSale";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetShareHolderDetails()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ShareholdersDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetProductSalesData()
        {
            ResetSalesCustomerDetail();
            ResetSalesCustomerProductsDetail();
            ResetSalesCustomerPaymentDetail();
            ResetSalesCustomerPaymentHistoryDetail();
            ResetSalesReturnCustomerDetail();
            ResetSalesReturnCustomerProductsDetail();
            ResetSalesReturnCustomerPaymentDetail();

        }

        private void ResetSalesReturnCustomerPaymentDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM SaleReturnCustomerProductsDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetSalesReturnCustomerProductsDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM SaleReturnCustomerPaymentDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetSalesReturnCustomerDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM SaleReturnCustomerDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetSalesCustomerPaymentHistoryDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM SalesCustomerPaymentHistoryDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetSalesCustomerPaymentDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM SalesCustomerPaymentDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetSalesCustomerProductsDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM SalesCustomerProductsDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetSalesCustomerDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM SalesCustomerDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetProductPurchasesData()
        {
            ResetPurchasesProductDetail();
            ResetPurchasesCompanyDetail();
            ResetPurchasesPaymentDetail();
            ResetPurchasesPaymentHistoryDetail();
        }

        private void ResetPurchasesPaymentHistoryDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM PurchasesPaymentHistoryDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetPurchasesPaymentDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM PurchasesPaymentDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetPurchasesCompanyDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM PurchasesCompanyDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetPurchasesProductDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM PruchasesProductDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetProductsData()
        {
            RestProductEndingInventory();
            RestProductOpeningInventory();
            RestProductStock();

        }

        private void RestProductStock()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ProductStock";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void RestProductOpeningInventory()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ProductsOpeningInventory";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void RestProductEndingInventory()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ProductsEndingInventory";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetProductKey()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       ProductKey
                          SET                Name =@Name , ProductKey =@ProductKey , TrialExpiryDate =@TrialExpiryDate ";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", string.Empty);
                        cmd.Parameters.AddWithValue("@ProductKey", string.Empty);
                        cmd.Parameters.AddWithValue("@TrialExpiryDate", new DateTime(1900, 1, 1));
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

        private void ResetExpenseAndEmployees()
        {
            ResetEmployeeDetails();
            ResetDailyExpenses();
            ResetDrawingsExpenses();
            ResetFreightInExpenses();
            ResetMonthlyExpenses();
            ResetWagesExpenses();
        }

        private void ResetWagesExpenses()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ExpensesWages";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetMonthlyExpenses()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ExpensesMonthly";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetFreightInExpenses()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ExpensesFreightInId";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetDrawingsExpenses()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ExpensesDrawings";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetDailyExpenses()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM ExpensesDaily";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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

        private void ResetEmployeeDetails()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"DELETE FROM EmployeesDetail";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
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
    }
}
