using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens.Debiters.CustomerDebtors;
using ASDBFramework.Utillities.Lists;
using ASDBFramework.Utillities;
using System.Data.SqlClient;
using ASDBFramework.Windows;

namespace ASDBFramework.Screens.UserScreens.Debiters
{
    public partial class CustomerDebtorsForm : TemplateForm
    {
        public CustomerDebtorsForm()
        {
            InitializeComponent();
        }

        private void CustomerDebtorsForm_Load(object sender, EventArgs e)
        {
           // ListData.LoadDataInToDataGridView(CustomerDebtorsDataGridView, "usp_SalesDebitorCustomerDetail");
            LoadAllDebitors();
            ListData.LoadDataInToComboBox(CustomerNameComboBox, "usp_SalesDebitorCustomerName");
        }

        private void LoadAllDebitors()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        SalesCustomerDetail.InvoiceNo AS 'Invoice', SalesCustomerDetail.CustomerName AS 'Name', SalesCustomerDetail.CustomerCellNo AS 'Mobile', SalesCustomerPaymentDetail.NetAmount AS 'TotalAmount', 
                         SalesCustomerPaymentDetail.CashRecived AS 'Credit', SalesCustomerPaymentDetail.RemainingBalance AS 'Debit', SalesCustomerPaymentDetail.CreatedDate AS 'SaleDate', 
                         SalesCustomerPaymentDetail.DuePayment, SalesCustomerPaymentDetail.DuePaymentDate AS 'DueDate'
                            FROM            SalesCustomerDetail INNER JOIN
                                                     SalesCustomerPaymentDetail ON SalesCustomerDetail.SalesCustomerDetailId = SalesCustomerPaymentDetail.SalesCustomerDetailId
                            WHERE        (SalesCustomerDetail.SaleType = 'False') AND SalesCustomerPaymentDetail.RemainingBalance > 0 
                            ORDER BY 'SaleDate'";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);

                        foreach (DataRow Items in GetData.Rows)
                        {
                            int n = CustomerDebtorsDataGridView.Rows.Add();
                            CustomerDebtorsDataGridView.Rows[n].Cells[0].Value = Items["Invoice"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[1].Value = Items["Name"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[2].Value = Items["Mobile"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[3].Value = Items["TotalAmount"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[4].Value = Items["Credit"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[5].Value = Items["Debit"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[6].Value = Items["SaleDate"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[7].Value = Items["DuePayment"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[8].Value = Items["DueDate"].ToString();

                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            GetDataWithCustomerName();
        }

        private void GetDataWithCustomerName()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        SalesCustomerDetail.InvoiceNo AS 'Invoice', SalesCustomerDetail.CustomerName AS 'Name', SalesCustomerDetail.CustomerCellNo AS 'Mobile', SalesCustomerPaymentDetail.NetAmount AS 'TotalAmount', 
                         SalesCustomerPaymentDetail.CashRecived AS 'Credit', SalesCustomerPaymentDetail.RemainingBalance AS 'Debit', SalesCustomerPaymentDetail.CreatedDate AS 'SaleDate', 
                         SalesCustomerPaymentDetail.DuePayment, SalesCustomerPaymentDetail.DuePaymentDate AS 'DueDate'
                            FROM            SalesCustomerDetail INNER JOIN
                                                     SalesCustomerPaymentDetail ON SalesCustomerDetail.SalesCustomerDetailId = SalesCustomerPaymentDetail.SalesCustomerDetailId
                            WHERE        (SalesCustomerDetail.SaleType = 'False') AND (SalesCustomerDetail.CustomerName = @Name) AND SalesCustomerPaymentDetail.RemainingBalance > 0
                            ORDER BY 'SaleDate'";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@Name", CustomerNameComboBox.Text);
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        CustomerDebtorsDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            int n = CustomerDebtorsDataGridView.Rows.Add();
                            CustomerDebtorsDataGridView.Rows[n].Cells[0].Value = Items["Invoice"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[1].Value = Items["Name"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[2].Value = Items["Mobile"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[3].Value = Items["TotalAmount"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[4].Value = Items["Credit"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[5].Value = Items["Debit"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[6].Value = Items["SaleDate"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[7].Value = Items["DuePayment"].ToString();
                            CustomerDebtorsDataGridView.Rows[n].Cells[8].Value = Items["DueDate"].ToString();

                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }
    }
}
