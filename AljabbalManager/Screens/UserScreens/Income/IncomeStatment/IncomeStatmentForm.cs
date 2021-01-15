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
using ASDBFramework.Models.Users;
using ASDBFramework.Screens.UserScreens.Income.IncomeStatment;

namespace ASDBFramework.Screens.UserScreens.Income
{
    public partial class IncomeStatmentForm : TemplateForm
    {
        float OtherExpensesDaily = 0;
        float OtherExpensesMonthly = 0;
        int _ProductCode = 0;
        float _ProductQuantity = 0;
        float _ProductCostPrice = 0;

        public IncomeStatmentForm()
        {
            InitializeComponent();
            EnterButton.Text = "Enter";
        }

        private void StartDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            StartDateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void EndDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            EndDateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void StartDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                StartDateTimePicker.CustomFormat = " ";
            }
        }

        private void EndDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                EndDateTimePicker.CustomFormat = " ";
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            if (StartDateTimePicker.CustomFormat != " " && EndDateTimePicker.CustomFormat != " ")
            {
                string option = EnterButton.Text;
                switch (option)
                {
                    case "Enter":
                        ReveneusAndGains();
                        Costofgoodsold();
                        ExpensesAndLosses();
                        NetIncome();
                        EnterButton.Text = "Print";
                        break;
                    case "Save":
                        DialogResult _Dialog;
                        _Dialog = MessageBox.Show("Notice:\nBy pressing this button, your ending inventory becomes opening inventory for next income statment.\n\nDo you realy want to make this ending inventory as opening inventory??", "Information", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        if (_Dialog == DialogResult.Yes)
                        {
                            if (IsDeletingComplete())
                            {
                                if (IsOpeningDataInsertedCompleted())
                                {
                                    ASMessageBox.ShowSucessMessage("Your Opening Inventory is now been enterd completed with " + DateTime.Today);
                                    EnterButton.Text = "Print";
                                }

                            }
                        }
                        if (_Dialog == DialogResult.No)
                        {

                        }
                        break;
                    case "Print":
                        CalledToPrintForm();
                        break;
                }
            }
        }

        //<!.........................................Button Enter Click Event Start ........................!>

        //..................................................................Session ReveneusAndGains Start .......................

        private void ReveneusAndGains()
        {
            GetGrossSales();
            GetAmountOfTokenSale();
            GetNetSalesReturn();
            NetSales();
        }

        private void GetGrossSales()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(NetAmount), 0) AS GrossSales
                                    FROM            SalesCustomerPaymentDetail
                                    WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        GrossSalesLabel.Text = Convert.ToString(reader["GrossSales"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Gross Profit:\n" + ex.Message);

            }
        }

        private void GetAmountOfTokenSale()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(TotalAmount), 0) AS 'TotalAmountOfTokenSale'
                                    FROM            TokenSale
                                    WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        TokenSaleLabel.Text = Convert.ToString(reader["TotalAmountOfTokenSale"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Token Sale:\n" + ex.Message);

            }
        }

        private void GetNetSalesReturn()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(NetAmount), 0) AS SalesReturn
                                    FROM            SaleReturnCustomerPaymentDetail
                                    WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", StartDateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@EndDate", EndDateTimePicker.Value.Date);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        LessSaleReturnLabel.Text = Convert.ToString(reader["SalesReturn"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in sales return:\n" + ex.Message);

            }
        }

        private void NetSales()
        {
            NetSalesLabel.Text = Convert.ToString((Convert.ToInt32(GrossSalesLabel.Text) - Convert.ToInt32(LessSaleReturnLabel.Text)) + Convert.ToInt32(TokenSaleLabel.Text));
            TotalNetSaleLabel.Text = NetSalesLabel.Text;
        }

        //..................................................................Session ReveneusAndGains End .......................

        //..................................................................Session Costofgoodsold Start .......................

        private void Costofgoodsold()
        {
            GetTotalPurchases();
            GetOpeningInventory();
            GetTotalFreightIn();
            GetAmountOfTokenPurchase();
            GetEndingInventory();
            AmountOfGoodsSold();
        }

        private void GetTotalFreightIn()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(TotalAmount), 0) AS 'TotalFreightIn'
                                    FROM            ExpensesFreightInId
                                    WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        FreightInLabel.Text = Convert.ToString(reader["TotalFreightIn"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in total Freight in:\n" + ex.Message);
            }
        }

        private void GetTotalPurchases()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(NetAmount), 0) AS 'TotalPurchases'
                                    FROM            PurchasesPaymentDetail
                                    WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        PurchasesLabel.Text = Convert.ToString(reader["TotalPurchases"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in total purchases:\n" + ex.Message);

            }
        }

        private void GetOpeningInventory()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(ProductQuantity * ProductCostPrice), 0) AS 'TotalAmountOfOpeningInventory'
                                    FROM            ProductsOpeningInventory
                                    WHERE        (CreatedDate <= @StartDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        OpeningInventoryLabel.Text = Convert.ToString(reader["TotalAmountOfOpeningInventory"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Opening Inventory\n: " + ex.Message);

            }
        }

        private void GetAmountOfTokenPurchase()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(TotalAmount), 0) AS 'TotalAmountOfTokenPurchase'
                                    FROM            TokenPurchases
                                    WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        TokenPurchasesLabel.Text = Convert.ToString(reader["TotalAmountOfTokenPurchase"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Token Purchase:\n" + ex.Message);

            }
        }

        private void GetEndingInventory()
        {
            if (IsEndingInventoryEmpty())
            {
                if (GetAvailableStock())
                {
                    TotalEndingInventory();
                }
            }
        }

        private bool IsEndingInventoryEmpty()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _ComandInsertToOpeningInventory = @"DELETE FROM ProductsEndingInventory";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_ComandInsertToOpeningInventory, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in deleting from Ending Inventory:\n" + ex.Message);
                return false;

            }
        }

        private bool GetAvailableStock()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _CommandSelectFormStock = @"SELECT        ProductCode, ProductQuantity, ProductCostPrice
                                                   FROM            ProductStock";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_CommandSelectFormStock, conn))
                    {
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        foreach (DataRow Items in GetData.Rows)
                        {
                            _ProductCode = Convert.ToInt32(Items["ProductCode"].ToString());
                            _ProductQuantity = Convert.ToInt32(Items["ProductQuantity"].ToString());
                            _ProductCostPrice = Convert.ToInt32(Items["ProductCostPrice"].ToString());
                            if (EnterButton.Text == "Enter")
                            {
                                InsertToEndingInventory();
                            }
                            if (EnterButton.Text == "Save")
                            {
                                InsertToOpeningInventory();
                            }
                        }

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in retriving data from stock:\n " + ex.Message);
                return false;

            }
        }

        private void TotalEndingInventory()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(ProductQuantity * ProductCostPrice), 0) AS 'TotalAmountOfEndingInventory'
                                    FROM            ProductsEndingInventory
                                    WHERE        (CreatedDate <= @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        EndingInventoryLabel.Text = Convert.ToString(reader["TotalAmountOfEndingInventory"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Ending Inventory\n: " + ex.Message);

            }
        }

        private void AmountOfGoodsSold()
        {
            GoodsAvailableForSaleLabel.Text = Convert.ToString(Convert.ToInt32(OpeningInventoryLabel.Text) + Convert.ToInt32(PurchasesLabel.Text) + Convert.ToInt32(TokenPurchasesLabel.Text) + Convert.ToInt32(FreightInLabel.Text));
            AmountOfGoodsSoldLabel.Text = Convert.ToString(Convert.ToInt32(GoodsAvailableForSaleLabel.Text) - Convert.ToInt32(EndingInventoryLabel.Text));
            TotalAmountOfGoodsSoldLabel.Text = AmountOfGoodsSoldLabel.Text;
        }

        //..................................................................Session Costofgoodsold End .......................

        //..................................................................Session ExpensesAndLosses Start .......................

        private void ExpensesAndLosses()
        {
            GetDailyExpenses();
            GetMonthlyExpenses();
            GetTotalWagesExpenses();
            OtherExpensesLabel.Text = Convert.ToString(OtherExpensesDaily + OtherExpensesMonthly);
            TotalExpenses();
        }

        private void GetDailyExpenses()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(OfficeExpenses), 0) AS 'OfficeExpenses', ISNULL(SUM(Advertisement), 0) AS Advertisment,
                                                           ISNULL(SUM(OtherExpanses), 0) AS 'OtherExpenses'
                                            FROM            ExpensesDaily
                                            WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        AdvertismentLabel.Text = Convert.ToString(reader["Advertisment"].ToString());
                        OfficeExpensesLabel.Text = Convert.ToString(reader["OfficeExpenses"].ToString());
                        OtherExpensesDaily = Convert.ToInt32(reader["OtherExpenses"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in daily expenses:\n" + ex.Message);

            }
        }

        private void GetMonthlyExpenses()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(TelephoneBill), 0) AS 'TelephoneBill', ISNULL(SUM(InternetCharges), 0) AS 'InternetExpenses',
                                                  ISNULL(SUM(BuildingRent), 0) AS 'Rent', ISNULL(SUM(ElectricityBill), 0) AS 'OtherExpenses'
                                    FROM            ExpensesMonthly
                                    WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        TelephoneExpensesLabel.Text = Convert.ToString(reader["TelephoneBill"].ToString());
                        InternetExpensesLabel.Text = Convert.ToString(reader["InternetExpenses"].ToString());
                        RentLabel.Text = Convert.ToString(reader["Rent"].ToString());
                        OtherExpensesMonthly = Convert.ToInt32(reader["OtherExpenses"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in monthly expenses:\n " + ex.Message);

            }
        }

        private void GetTotalWagesExpenses()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ISNULL(SUM(TotalAmount), 0) AS 'Wages'
                                    FROM            ExpensesWages
                                    WHERE        (CreatedDate BETWEEN @StartDate AND @EndDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@StartDate", Convert.ToDateTime(StartDateTimePicker.Value.Date));
                        cmd.Parameters.AddWithValue("@EndDate", Convert.ToDateTime(EndDateTimePicker.Value.Date));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        WagesLabel.Text = Convert.ToString(reader["Wages"].ToString());
                    }
                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in wages:\n" + ex.Message);

            }
        }

        private void TotalExpenses()
        {
            float LeftExpenses = 0;
            float RightExpenses = 0;
            LeftExpenses = Convert.ToInt32(RentLabel.Text) + Convert.ToInt32(WagesLabel.Text) + Convert.ToInt32(AdvertismentLabel.Text) + Convert.ToInt32(OfficeExpensesLabel.Text);
            RightExpenses = Convert.ToInt32(InternetExpensesLabel.Text) + Convert.ToInt32(TelephoneExpensesLabel.Text) + Convert.ToInt32(BedDebtLabel.Text) + Convert.ToInt32(OtherExpensesLabel.Text);
            TotalExpensesLabel.Text = Convert.ToString(LeftExpenses + RightExpenses);
            TotalExpensesAndLossesLabel.Text = TotalExpensesLabel.Text;
        }

        //..................................................................Session ExpensesAndLosses End .......................

        //..................................................................Session FindNetIncome Start .......................

        private void NetIncome()
        {
            GrossProfitLabel.Text = Convert.ToString(Convert.ToInt32(TotalNetSaleLabel.Text) - Convert.ToInt32(TotalAmountOfGoodsSoldLabel.Text));
            TotalGrossProfitLabel.Text = GrossProfitLabel.Text;
            NetIncomeLabel.Text = Convert.ToString(Convert.ToInt32(TotalGrossProfitLabel.Text) - Convert.ToInt32(TotalExpensesAndLossesLabel.Text));
            if (Convert.ToInt32(NetIncomeLabel.Text) < 0)
            {
                label26.Text = "Net Loss";
            }
        }

        //..................................................................Session FindNetIncome End .......................

        //<!.........................................Button Enter Click Event End ........................!>

        private bool IsOpeningDataInsertedCompleted()
        {
            if (GetAvailableStock())
            {
                return true;
            }
            return false;
        }

        private bool IsDeletingComplete()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Comand = @"DELETE FROM ProductsOpeningInventory";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Comand, conn))
                    {
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }

                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in deleting from Opening Inventory:\n" + ex.Message);
                return false;

            }
        }

        private void InsertToOpeningInventory()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _ComandInsertToOpeningInventory = @"INSERT INTO ProductsOpeningInventory
                                                 (ProductCode, ProductQuantity, ProductCostPrice, CreatedBy, CreatedDate)
                                    VALUES        (@ProductCode, @ProductQuantity, @ProductCostPrice, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_ComandInsertToOpeningInventory, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", _ProductCode);
                        cmd.Parameters.AddWithValue("@ProductQuantity", _ProductQuantity);
                        cmd.Parameters.AddWithValue("@ProductCostPrice", _ProductCostPrice);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in inserting to Ending Inventory:\n" + ex.Message);

            }
        }

        private void InsertToEndingInventory()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _ComandInsertToOpeningInventory = @"INSERT INTO ProductsEndingInventory
                                                 (ProductCode, ProductQuantity, ProductCostPrice, CreatedBy, CreatedDate)
                                    VALUES        (@ProductCode, @ProductQuantity, @ProductCostPrice, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_ComandInsertToOpeningInventory, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", _ProductCode);
                        cmd.Parameters.AddWithValue("@ProductQuantity", _ProductQuantity);
                        cmd.Parameters.AddWithValue("@ProductCostPrice", _ProductCostPrice);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }

                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in inserting to Ending Inventory:\n" + ex.Message);

            }
        }

        private void CalledToPrintForm()
        {
            PrintIncomeStatmentForm PI = new PrintIncomeStatmentForm();
            PI.GetDatesAndNetIcome(StartDateTimePicker.Value.Date, EndDateTimePicker.Value.Date, NetIncomeLabel.Text);
            PI.GetRevenueAndGains(GrossSalesLabel.Text, LessSaleReturnLabel.Text, TokenSaleLabel.Text, NetSalesLabel.Text);
            PI.GetCostOfGoodsSold(OpeningInventoryLabel.Text, PurchasesLabel.Text, TokenPurchasesLabel.Text, FreightInLabel.Text, GoodsAvailableForSaleLabel.Text, EndingInventoryLabel.Text, AmountOfGoodsSoldLabel.Text);
            PI.GetExpensesAndLosses(RentLabel.Text, WagesLabel.Text, AdvertismentLabel.Text, OfficeExpensesLabel.Text, InternetExpensesLabel.Text, TelephoneExpensesLabel.Text, BedDebtLabel.Text, OtherExpensesLabel.Text, TotalExpensesLabel.Text);
            PI.Show();
        }
       
    }
}
