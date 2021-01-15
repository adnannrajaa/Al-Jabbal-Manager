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
using System.Data.SqlClient;
using ASDBFramework.Utillities;

namespace ASDBFramework.Screens.UserScreens.Debiters.CompanyPayable
{
    public partial class PrintCompanyPaymentHistoryForm : TemplateForm
    {
        int _InvoiceNo = 0;
        DebitersDataSet _CompanyPayments = new DebitersDataSet();
        public PrintCompanyPaymentHistoryForm()
        {
            InitializeComponent();
        }
        public void GetPurchasesToCompanyInvoiceNo(int InvoiceId)
        {
            _InvoiceNo = InvoiceId;
        }

        private void PrintCompanyPaymentHistoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadPartyPersonalData();
                LoadCompanyPaymentData();
                CompanyPaymentCrystalReport myreport = new CompanyPaymentCrystalReport();
                myreport.SetDataSource(_CompanyPayments);
                CompanyPaymentHistoryCrystalReportViewer.ReportSource = myreport;
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("There is an Error! Please Consult To Admin." + ex.Message);
            }
        }

        private void LoadPartyPersonalData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        InvoiceNo, CompanyName, CompanyCellNo, CreatedDate
                                FROM            PurchasesCompanyDetail
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
                    da.Fill(_CompanyPayments.PartyPersonalDetails);
                }
            }
        }

        private void LoadCompanyPaymentData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        PurchasesPaymentHistoryDetail.SubTotal as 'SubTotal', PurchasesPaymentHistoryDetail.Discount, PurchasesPaymentHistoryDetail.NetAmount, PurchasesPaymentHistoryDetail.CashPayed, 
                         PurchasesPaymentHistoryDetail.RemainingBalance, PurchasesPaymentHistoryDetail.CreatedDate
                        FROM            PurchasesCompanyDetail INNER JOIN
                                                 PurchasesPaymentHistoryDetail ON PurchasesCompanyDetail.PurchasesCompanyDetailId = PurchasesPaymentHistoryDetail.PurchasesCompanyDetailId
                        WHERE        (PurchasesCompanyDetail.InvoiceNo = @InvoiceNo)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@InvoiceNo", _InvoiceNo);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_CompanyPayments.CompanyPayableHistory);
                }
            }
        }

        
    }
}
