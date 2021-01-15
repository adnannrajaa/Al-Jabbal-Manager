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
using CrystalDecisions.CrystalReports.Engine;
using ASDBFramework.Windows;

namespace ASDBFramework.Screens.UserScreens.Sales.SaleInvoice
{
    public partial class MakeInvoiceForm : TemplateForm
    {
        int saleCustomerId = 0;
        float _SubTotal = 0;
        float _Discount = 0, _Loading = 0, _NetAmount = 0, _CashRecived = 0, _RemainingBalance = 0, _DuePayment = 0;
        string _DuePaymentDate = null;
        MakeInvoiceDataSet PrintInvoiceDataSet = new MakeInvoiceDataSet();
        public MakeInvoiceForm()
        {
            InitializeComponent();
        }

        public void GetSaleToCustomerProductsDetailId(int SaleId)
        {
            saleCustomerId = SaleId;
        }
        private void MakeInvoiceForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadSaleCustomerData();
                LoadSaleProductData();
                LoadSalePaymentData();
                MakeInvoiceCrystalReport myreport = new MakeInvoiceCrystalReport();
                myreport.SetDataSource(PrintInvoiceDataSet);
                myreport.SetParameterValue("SubTotal",_SubTotal.ToString());
                myreport.SetParameterValue("Discount", _Discount.ToString());
                myreport.SetParameterValue("Loading", _Loading.ToString());
                myreport.SetParameterValue("NetAmount", _NetAmount.ToString());
                myreport.SetParameterValue("Credit", _CashRecived.ToString());
                myreport.SetParameterValue("Debit", _RemainingBalance.ToString());
                myreport.SetParameterValue("DuePayment", _DuePayment.ToString());
                myreport.SetParameterValue("DuePaymentDate", _DuePaymentDate.ToString());
                MakeInvoiceCrystalReportViewer.ReportSource = myreport;
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("There is an Error! Please Consult To Admin." + ex.Message);
            }
        }
        private void LoadSaleCustomerData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        SalesCustomerDetailId, InvoiceNo, CustomerName, CustomerCellNo, SaleType, CreatedBy, CreatedDate
                         FROM            SalesCustomerDetail
                         WHERE        (SalesCustomerDetailId = @SalesCustomerDetailId)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@SalesCustomerDetailId", saleCustomerId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(PrintInvoiceDataSet.SaleCustomer);
                }
            }
        }
        private void LoadSaleProductData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        *   FROM            SalesCustomerProductsDetail
                               WHERE        (SalesCustomerDetailId = @SalesCustomerDetailId)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@SalesCustomerDetailId", saleCustomerId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(PrintInvoiceDataSet.SaleCustomerProducts);
                    da.Fill(dt);
                }
            }
        }

        private void LoadSalePaymentData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        SubTotal, Discount, Loading, NetAmount, CashRecived, RemainingBalance, DuePayment, DuePaymentDate
                               FROM            SalesCustomerPaymentDetail
                               WHERE        (SalesCustomerDetailId = @SalesCustomerDetailId)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@SalesCustomerDetailId", saleCustomerId);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(PrintInvoiceDataSet.SaleCustomerProducts);
                    da.Fill(dt);

                    foreach (DataRow dr in dt.Rows)
                    {
                        _SubTotal = Convert.ToInt32(dr["SubTotal"].ToString());
                        _Discount = Convert.ToInt32(dr["Discount"].ToString());
                        _Loading = Convert.ToInt32(dr["Loading"].ToString());
                        _NetAmount = Convert.ToInt32(dr["NetAmount"].ToString());
                        _CashRecived = Convert.ToInt32(dr["CashRecived"].ToString());
                        _RemainingBalance = Convert.ToInt32(dr["RemainingBalance"].ToString());
                        _DuePayment = Convert.ToInt32(dr["DuePayment"].ToString());
                        _DuePaymentDate = dr["DuePaymentDate"].ToString();
                    }
                }
            }
        }
    }
}
