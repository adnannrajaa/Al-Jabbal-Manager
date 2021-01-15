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
using ASDBFramework.Utillities;
using System.Data.SqlClient;

namespace ASDBFramework.Screens.UserScreens.Sales.SaleReport
{
    public partial class SaleReportForm : TemplateForm
    {
        public SaleReportForm()
        {
            InitializeComponent();
        }

        private void SaleReportForm_Load(object sender, EventArgs e)
        {
            LoadSaleReporstsIntoDataGridViews();
        }

        private void LoadSaleReporstsIntoDataGridViews()
        {
            ListData.LoadDataInToDataGridView(WeaklySalesDataGridView, "usp_SalesWeaklySalesReport");
            ListData.LoadDataInToDataGridView(MonthlySalesDataGridView, "usp_SalesMonthlySalesReport");
            ListData.LoadDataInToDataGridView(YearlySalesDataGridView, "usp_SalesYearlySalesReport");
        }

        private void LoadToWeakChartButton_Click(object sender, EventArgs e)
        {
            WeaklySaleChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            WeaklySaleChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            WeaklySaleChart.Series["Total Sales"].XValueMember = "Date";
            WeaklySaleChart.Series["Total Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            WeaklySaleChart.Series["Total Credit Sales"].XValueMember = "Date";
            WeaklySaleChart.Series["Total Credit Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            WeaklySaleChart.Series["Total Debit Sales"].XValueMember = "Date";
            WeaklySaleChart.Series["Total Debit Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

            WeaklySaleChart.Series["Total Sales"].YValueMembers = "TotalSales";
            WeaklySaleChart.Series["Total Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            WeaklySaleChart.Series["Total Credit Sales"].YValueMembers = "CreditSales";
            WeaklySaleChart.Series["Total Credit Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            WeaklySaleChart.Series["Total Debit Sales"].YValueMembers = "DebitSales";
            WeaklySaleChart.Series["Total Debit Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            WeaklySaleChart.Series["Total Expenses"].YValueMembers = "TotalExpenses";
            WeaklySaleChart.Series["Total Expenses"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            WeaklySaleChart.DataManipulator.IsStartFromFirst = true;

            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        SUM(SPD.NetAmount) AS 'TotalSales', SUM(SPD.CashRecived) AS 'CreditSales', SUM(SPD.RemainingBalance) AS 'DebitSales', SUM(ISNULL(ED.TotalExpenses, 0)) AS 'TotalExpenses', 
                         SPD.CreatedDate AS 'Date'
FROM            SalesCustomerPaymentDetail AS SPD INNER JOIN
                         ExpensesDaily AS ED ON SPD.CreatedDate = ED.CreatedDate
WHERE        (DATEDIFF(Day, SPD.CreatedDate, { fn CURDATE() }) BETWEEN 1 AND 7)
GROUP BY SPD.CreatedDate, ED.TotalExpenses";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {

                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        WeaklySaleChart.DataSource = GetData;
                        WeaklySaleChart.DataBind();
                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void LoadToMonthlyChartButton_Click(object sender, EventArgs e)
        {
            MonthlySalesChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            MonthlySalesChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            MonthlySalesChart.Series["Total Sales"].XValueMember = "Month";
            MonthlySalesChart.Series["Total Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            MonthlySalesChart.Series["Total Credit Sales"].XValueMember = "Month";
            MonthlySalesChart.Series["Total Credit Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            MonthlySalesChart.Series["Total Debit Sales"].XValueMember = "Month";
            MonthlySalesChart.Series["Total Debit Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            MonthlySalesChart.Series["Total Sales"].YValueMembers = "TotalSales";
            MonthlySalesChart.Series["Total Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            MonthlySalesChart.Series["Total Credit Sales"].YValueMembers = "TotalCredit";
            MonthlySalesChart.Series["Total Credit Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            MonthlySalesChart.Series["Total Debit Sales"].YValueMembers = "TotalDebit";
            MonthlySalesChart.Series["Total Debit Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            MonthlySalesChart.DataManipulator.IsStartFromFirst = true;

            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        SUM(NetAmount) AS 'TotalSales', SUM(CashRecived) AS 'TotalCredit', SUM(RemainingBalance) AS 'TotalDebit', MONTH(CreatedDate) AS 'Month'
                                    FROM            SalesCustomerPaymentDetail
                                    WHERE        (DATEDIFF(Month, CreatedDate, { fn CURDATE() }) BETWEEN 1 AND 5)
                                    GROUP BY MONTH(CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {

                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        MonthlySalesChart.DataSource = GetData;
                        MonthlySalesChart.DataBind();
                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void LoadToYearlyChartButton_Click(object sender, EventArgs e)
        {
            YearlySalesChart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineWidth = 0;
            YearlySalesChart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineWidth = 0;
            YearlySalesChart.Series["Total Sales"].XValueMember = "Year";
            YearlySalesChart.Series["Total Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            YearlySalesChart.Series["Total Credit Sales"].XValueMember = "Year";
            YearlySalesChart.Series["Total Credit Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            YearlySalesChart.Series["Total Debit Sales"].XValueMember = "Year";
            YearlySalesChart.Series["Total Debit Sales"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;

            YearlySalesChart.Series["Total Sales"].YValueMembers = "TotalSales";
            YearlySalesChart.Series["Total Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            YearlySalesChart.Series["Total Credit Sales"].YValueMembers = "TotalCredit";
            YearlySalesChart.Series["Total Credit Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

            YearlySalesChart.Series["Total Debit Sales"].YValueMembers = "TotalDebit";
            YearlySalesChart.Series["Total Debit Sales"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            YearlySalesChart.DataManipulator.IsStartFromFirst = true;

            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        SUM(NetAmount) AS 'TotalSales', SUM(CashRecived) AS 'TotalCredit', SUM(RemainingBalance) AS 'TotalDebit', YEAR(CreatedDate) AS 'Year'
                                    FROM            SalesCustomerPaymentDetail
                                    WHERE        (DATEDIFF(Year, CreatedDate, { fn CURDATE() }) BETWEEN 1 AND 5)
                                    GROUP BY YEAR(CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {

                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        YearlySalesChart.DataSource = GetData;
                        YearlySalesChart.DataBind();
                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }
        
    }
}
