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

namespace ASDBFramework.Screens.UserScreens.Debiters.CustomerDebtors
{
    public partial class PrintPaymentHistoryForm : TemplateForm
    {
        int _InvoiceNo = 0;
        DebitersDataSet _CustomerPaymentHistory = new DebitersDataSet();
        public PrintPaymentHistoryForm()
        {
            InitializeComponent();
        }
        public void GetSaleToCustomerInvoiceNo(int InvoiceId)
        {
            _InvoiceNo = InvoiceId;
        }
        private void PrintPaymentHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadCustomerPersonalData();
                LoadCustomerPaymentData();
                CustomerPaymentHistoryCrystalReport myreport = new CustomerPaymentHistoryCrystalReport();
                myreport.SetDataSource(_CustomerPaymentHistory);
                PaymentHistoryCrystalReportViewer.ReportSource = myreport;
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("There is an Error! Please Consult To Admin." + ex.Message);
            }
        }

        private void LoadCustomerPersonalData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT       InvoiceNo, CustomerName, CustomerCellNo, CreatedDate
                                FROM            SalesCustomerDetail
                                WHERE        (InvoiceNo = @InvoiceNo)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceNo", _InvoiceNo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_CustomerPaymentHistory.DebitorCustomerDetail);
                }
            }
        }

        private void LoadCustomerPaymentData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        Discount, SubTotal, NetAmount, CashRecived, RemainingBalance, CreatedDate
                                FROM            SalesCustomerPaymentHistoryDetail
                                WHERE        (InvoiceNo = @InvoiceNo)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceNo", _InvoiceNo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_CustomerPaymentHistory.CustomerPaymentHistory);
                }
            }
        }
    }
}
