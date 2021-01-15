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
using ASDBFramework.Models.Users;

namespace ASDBFramework.Screens.UserScreens.Income.IncomeStatment
{
    public partial class PrintIncomeStatmentForm : TemplateForm
    {
        string GrossSales = string.Empty, SalesReturn = string.Empty, TokenSale = string.Empty, NetSales = string.Empty;
        string OpeningI = string.Empty, Purchases = string.Empty, TokenP = string.Empty, FreightIn = string.Empty, GoodsA = string.Empty, EndingI = string.Empty, AmountOfGoodsSold = string.Empty;
        string Rent = string.Empty, Wages = string.Empty, Advertisement = string.Empty, OfficeE = string.Empty, InternetE = string.Empty, TelephoneE = string.Empty, BedDept = string.Empty, OthersE = string.Empty, TotalE = string.Empty;
        DateTime DateStart ; DateTime DateEnd; string NetIncome=string.Empty;

        public PrintIncomeStatmentForm()
        {
            InitializeComponent();
        }

        public void GetRevenueAndGains(string V1,string V2,string V3,string V4)
        {
            GrossSales = V1; SalesReturn = V2; TokenSale = V3; NetSales = V4;
        }
        public void GetCostOfGoodsSold(string V1, string V2, string V3, string V4, string V5, string V6, string V7)
        {
            OpeningI = V1; Purchases = V2; TokenP = V3; FreightIn = V4; GoodsA = V5; EndingI = V6; AmountOfGoodsSold = V7;
        }
        public void GetExpensesAndLosses(string V1, string V2, string V3, string V4, string V5, string V6, string V7,string V8,string V9)
        {
            Rent = V1; Wages = V2; Advertisement = V3; OfficeE = V4; InternetE = V5; TelephoneE = V6; BedDept = V7; OthersE = V8; TotalE = V9;
        }
        public void GetDatesAndNetIcome(DateTime DateS, DateTime DateE, string NetI)
        {
            DateStart = DateS; DateEnd = DateE; NetIncome = NetI;
        }

        private void PrintIncomeStatmentForm_Load(object sender, EventArgs e)
        {
            try
            {
                PrintIncomeStatmentCrystalReport myreport = new PrintIncomeStatmentCrystalReport();
                myreport.SetParameterValue("DateStart", DateStart.ToString());
                myreport.SetParameterValue("DateEnd", DateEnd.ToString());

                myreport.SetParameterValue("GrossSales", GrossSales.ToString());
                myreport.SetParameterValue("LessSalesReturn", SalesReturn.ToString());
                myreport.SetParameterValue("TokenSale", TokenSale.ToString());
                myreport.SetParameterValue("NetSales", NetSales.ToString());

                myreport.SetParameterValue("OpeningI", OpeningI.ToString());
                myreport.SetParameterValue("Purchases", Purchases.ToString());
                myreport.SetParameterValue("TokenP", TokenP.ToString());
                myreport.SetParameterValue("FreightIn", FreightIn.ToString());
                myreport.SetParameterValue("GoodsA", GoodsA.ToString());
                myreport.SetParameterValue("EndingI", EndingI.ToString());
                myreport.SetParameterValue("AmountOfGoodsSold", AmountOfGoodsSold.ToString());

                myreport.SetParameterValue("Rent", Rent.ToString());
                myreport.SetParameterValue("Wages", Wages.ToString());
                myreport.SetParameterValue("Advertisement", Advertisement.ToString());
                myreport.SetParameterValue("OfficeE", OfficeE.ToString());
                myreport.SetParameterValue("InternetE", InternetE.ToString());
                myreport.SetParameterValue("TelephoneE", TelephoneE.ToString());
                myreport.SetParameterValue("BedDept", BedDept.ToString());
                myreport.SetParameterValue("OtherE", OthersE.ToString());
                myreport.SetParameterValue("TotalE", TotalE.ToString());

                myreport.SetParameterValue("NetIncome", NetIncome.ToString());

                myreport.SetParameterValue("LoggedInUserName",LoggedInUser.UserName.ToLower());
                myreport.SetParameterValue("CompileDate", DateTime.Now);
                myreport.SetParameterValue("CompileTime", DateTime.Now);

                IncomeStatmentCrystalReportViewer.ReportSource = myreport;
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("There is an Error! Please Consult To Admin." + ex.Message);
            }
        }

        private void IncomeStatmentCrystalReportViewer_Load(object sender, EventArgs e)
        {

        }

    }
}
