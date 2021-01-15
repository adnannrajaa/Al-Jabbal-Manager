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
using CrystalDecisions.Windows.Forms;
using ASDBFramework.Windows;
using ASDBFramework.Screens.UserScreens.Expenses.Daily;

namespace ASDBFramework.Screens.UserScreens.Expenses.DailyExpenses
{
    public partial class PrintDailyExpensesForm : TemplateForm
    {
        ExpensesDataSet _DailyExpenses = new ExpensesDataSet();
        public PrintDailyExpensesForm()
        {
            InitializeComponent();
        }

        private void PrintDailyExpensesForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadDailyExpensesData();
                DailyExpensesCrystalReport myreport = new DailyExpensesCrystalReport();
                myreport.SetDataSource(_DailyExpenses);
                DailyExpensesCrystalReportViewer.ReportSource = myreport;
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("There is an Error! Please Consult To Admin." + ex.Message);
            }
        }

        private void LoadDailyExpensesData()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        OfficeExpenses, Advertisement, OtherExpanses, TotalExpenses, CreatedDate, CurrentDay
                                FROM            ExpensesDaily
                                WHERE        (DATEDIFF(Day, CreatedDate, GETDATE()) BETWEEN 0 AND 9)
                                ORDER BY CreatedDate DESC";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(_DailyExpenses.ExpensesDaily);
                }
            }
        }
    }
}
