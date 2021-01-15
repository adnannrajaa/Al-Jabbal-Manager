using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens.Debiters.CompanyPayable;
using ASDBFramework.Utillities.Lists;
using System.Data.SqlClient;
using ASDBFramework.Windows;
using ASDBFramework.Utillities;

namespace ASDBFramework.Screens.UserScreens.Debiters
{
    public partial class CompanyPayableForm : TemplateForm
    {
        public CompanyPayableForm()
        {
            InitializeComponent();
        }

        private void CompanyPayableForm_Load(object sender, EventArgs e)
        {
            ListData.LoadDataInToComboBox(PartyNameComboBox, "usp_PurchasePayablePartyName");
            LoadAllPayables();
        }

        private void LoadAllPayables()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        PurchasesCompanyDetail.InvoiceNo, PurchasesCompanyDetail.CompanyName, PurchasesCompanyDetail.CompanyCellNo, PurchasesPaymentDetail.NetAmount, PurchasesPaymentDetail.CashPayed, 
                         PurchasesPaymentDetail.RemainingBalance, PurchasesPaymentDetail.CreatedDate, PurchasesPaymentDetail.DuePayment, PurchasesPaymentDetail.DuePaymentDate
FROM            PurchasesCompanyDetail INNER JOIN
                         PurchasesPaymentDetail ON PurchasesCompanyDetail.PurchasesCompanyDetailId = PurchasesPaymentDetail.PurchasesCompanyDetailId
WHERE        (PurchasesCompanyDetail.PurchaseType = 'False') AND (PurchasesPaymentDetail.RemainingBalance > 0)
ORDER BY PurchasesPaymentDetail.CreatedDate";
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
                            int n = PartyDebtorsDataGridView.Rows.Add();
                            PartyDebtorsDataGridView.Rows[n].Cells[0].Value = Items["InvoiceNo"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[1].Value = Items["CompanyName"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[2].Value = Items["CompanyCellNo"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[3].Value = Items["NetAmount"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[4].Value = Items["CashPayed"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[5].Value = Items["RemainingBalance"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[6].Value = Items["CreatedDate"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[7].Value = Items["DuePayment"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[8].Value = Items["DuePaymentDate"].ToString();

                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            GetDataWithPartyName();
        }

        private void GetDataWithPartyName()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        PurchasesCompanyDetail.InvoiceNo, PurchasesCompanyDetail.CompanyName, PurchasesCompanyDetail.CompanyCellNo, PurchasesPaymentDetail.NetAmount, PurchasesPaymentDetail.CashPayed, 
                         PurchasesPaymentDetail.RemainingBalance, PurchasesPaymentDetail.CreatedDate, PurchasesPaymentDetail.DuePayment, PurchasesPaymentDetail.DuePaymentDate
FROM            PurchasesCompanyDetail INNER JOIN
                         PurchasesPaymentDetail ON PurchasesCompanyDetail.PurchasesCompanyDetailId = PurchasesPaymentDetail.PurchasesCompanyDetailId
WHERE        (PurchasesCompanyDetail.PurchaseType = 'False') AND (PurchasesPaymentDetail.RemainingBalance > 0) And PurchasesCompanyDetail.CompanyName =@CompanyName
ORDER BY PurchasesPaymentDetail.CreatedDate";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@CompanyName", PartyNameComboBox.Text);
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        PartyDebtorsDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            int n = PartyDebtorsDataGridView.Rows.Add();
                            PartyDebtorsDataGridView.Rows[n].Cells[0].Value = Items["InvoiceNo"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[1].Value = Items["CompanyName"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[2].Value = Items["CompanyCellNo"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[3].Value = Items["NetAmount"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[4].Value = Items["CashPayed"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[5].Value = Items["RemainingBalance"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[6].Value = Items["CreatedDate"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[7].Value = Items["DuePayment"].ToString();
                            PartyDebtorsDataGridView.Rows[n].Cells[8].Value = Items["DuePaymentDate"].ToString();

                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }
    }
}
