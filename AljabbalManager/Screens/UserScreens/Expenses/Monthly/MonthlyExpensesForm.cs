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
using ASDBFramework.Models.Expenses;
using ASDBFramework.Models.Users;
using ASDBFramework.Utillities.Lists;
using ASDBFramework.Screens.UserScreens.Expenses.Monthly;

namespace ASDBFramework.Screens.UserScreens.Expenses
{
    public partial class MonthlyExpensesForm : TemplateForm
    {
        public MonthlyExpensesForm()
        {
            InitializeComponent();
        }

        private void MonthlyExpensesForm_Load(object sender, EventArgs e)
        {
            TelephoneBillTextBox.Text = "0";
            ElectricityBillTextBox.Text = "0";
            BuildingRentTextBox.Text = "0";
            InternetChargesTextBox.Text = "0";
            YearTextBox.Text = "0";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_ExpensesAddNewMonthlyExpenses", GetObject());
                ASMessageBox.ShowSucessMessage("Record Inserted Successfully");
            }
        }

        private MonthlyExpenses GetObject()
        {
            float Total = 0;
            MonthlyExpenses Expenses = new MonthlyExpenses();
            Expenses.TelephoneBill = Convert.ToInt32(TelephoneBillTextBox.Text);
            Expenses.BuildingRent= Convert.ToInt32(BuildingRentTextBox.Text);
            Expenses.ElectricityBill = Convert.ToInt32(ElectricityBillTextBox.Text);
            Expenses.InternetCharges = Convert.ToInt32(InternetChargesTextBox.Text);
            Total = Convert.ToInt32(TelephoneBillTextBox.Text) + Convert.ToInt32(BuildingRentTextBox.Text) + Convert.ToInt32(ElectricityBillTextBox.Text) + Convert.ToInt32(InternetChargesTextBox.Text);
            Expenses.TotalExpenses = Total;
            Expenses.CurrentMonth = MonthComboBox.Text;
            Expenses.CurrentYear = YearTextBox.Text;
            Expenses.CreatedBy = LoggedInUser.UserName;
            Expenses.CreatedDate = DateTime.Today;
            return Expenses;
        }
        private bool IsFormValid()
        {
            if (MonthComboBox.Text.Trim() == string.Empty)
            {
                MonthComboBox.SelectedIndex = -1;
                MonthComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Please Select Current Month");
                return false;
            }
            if (TelephoneBillTextBox.Text.Trim() == string.Empty)
            {
                TelephoneBillTextBox.Clear();
                TelephoneBillTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Telephone Bill cannot be empty it must contain at least '0'");
                TelephoneBillTextBox.Text = "0";

                return false;


            }
            if (ElectricityBillTextBox.Text == string.Empty)
            {
                ElectricityBillTextBox.Clear();
                ElectricityBillTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Electricity Bill cannot be empty it must contain at least '0'");
                ElectricityBillTextBox.Text = "0";
                return false;
            }
            if (BuildingRentTextBox.Text == string.Empty)
            {
                BuildingRentTextBox.Clear();
                BuildingRentTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Building Rent cannot be empty it must contain at least '0'");
                BuildingRentTextBox.Text = "0";
                return false;
            }
            if (InternetChargesTextBox.Text == string.Empty)
            {
                InternetChargesTextBox.Clear();
                InternetChargesTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Internet Charges cannot be empty it must contain at least '0'");
                InternetChargesTextBox.Text = "0";
                return false;
            }
            if (YearTextBox.Text == string.Empty)
            {
                YearTextBox.Clear();
                YearTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Please Enter Current Year");
                YearTextBox.Text = "0";
                return false;
            }
            return true;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ListData.LoadDataInToDataGridView(MonthlyExpenseDataGridView, "usp_ExpensesMonthlyExpensesListData");
        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintMonthlyExpensesForm PM = new PrintMonthlyExpensesForm();
            PM.Show();
        }
    }
}
