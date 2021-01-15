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

namespace ASDBFramework.Screens.UserScreens.Expenses.Monthly
{
    public partial class PrintMonthlyExpensesForm : TemplateForm
    {
        ExpensesDataSet _MonthlyExpenses = new ExpensesDataSet();
        public PrintMonthlyExpensesForm()
        {
            InitializeComponent();
        }

        private void PrintMonthlyExpensesForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadMonthlyExpensesData();

                MonthlyExpensesCrystalReport myreport = new MonthlyExpensesCrystalReport();
                myreport.SetDataSource(_MonthlyExpenses);
                MonthlyExpensesCrystalReportViewer.ReportSource = myreport;
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("There is an Error! Please Consult To Admin." + ex.Message);
            }
        }

        private void LoadMonthlyExpensesData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"	SELECT        TelephoneBill, ElectricityBill, BuildingRent, InternetCharges, TotalExpenses, CurrentMonth, CurrentYear
                                    FROM            ExpensesMonthly
                                    WHERE        (DATEDIFF(Month, CreatedDate, GETDATE()) BETWEEN 0 AND 11)
                                    ORDER BY CurrentMonth DESC, CurrentYear DESC";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_MonthlyExpenses.ExpensesMonthly);
                }
            }
        }
    }
}
