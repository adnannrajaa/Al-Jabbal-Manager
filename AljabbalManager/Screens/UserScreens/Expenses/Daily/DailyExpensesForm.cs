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
using ASDBFramework.Screens.UserScreens.Expenses.DailyExpenses;

namespace ASDBFramework.Screens.UserScreens.Expenses
{
    public partial class DailyExpensesForm : TemplateForm
    {
        public DailyExpensesForm()
        {
            InitializeComponent();
        }
        private void DailyExpensesForm_Load(object sender, EventArgs e)
        {
            OfficeExpensesTextBox.Text = "0";
            AdvertismentTextBox.Text = "0";
            OtherExpensesTextBox.Text = "0";
        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_ExpensesAddNewDailyExpenses", GetObject());
                ASMessageBox.ShowSucessMessage("Record Inserted Successfully");
            }
        }

        private DailyExpense GetObject()
        {
            float Total = 0;
            DailyExpense Expenses = new DailyExpense();
            Expenses.OfficeExpenses = Convert.ToInt32(OfficeExpensesTextBox.Text);
            Expenses.Advertisement= Convert.ToInt32(AdvertismentTextBox.Text);
            Expenses.OtherExpanses= Convert.ToInt32(OtherExpensesTextBox.Text);
            Total = Convert.ToInt32(OfficeExpensesTextBox.Text) + Convert.ToInt32(AdvertismentTextBox.Text) + Convert.ToInt32(OtherExpensesTextBox.Text);
            Expenses.TotalExpenses = Total;
            Expenses.CurrentDay = DayComboBox.Text;
            Expenses.CreatedBy = LoggedInUser.UserName;
            Expenses.CreatedDate = DateTime.Today;
            return Expenses;
        }

        private bool IsFormValid()
        {
            if (DayComboBox.Text.Trim() == string.Empty)
            {
                DayComboBox.SelectedIndex = -1;
                DayComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Please Select Current Day");
                return false;
            }
            if (OfficeExpensesTextBox.Text.Trim() == string.Empty)
            {
                OfficeExpensesTextBox.Clear();
                OfficeExpensesTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Office expenses cannot be empty it must contain at least '0'");
                OfficeExpensesTextBox.Text = "0";

                return false;
               

            }
            if (AdvertismentTextBox.Text == string.Empty)
            {
                AdvertismentTextBox.Clear();
                AdvertismentTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Advertisement cannot be empty it must contain at least '0'");
                AdvertismentTextBox.Text = "0";
                return false;
            }
            if (OtherExpensesTextBox.Text == string.Empty)
            {
                OtherExpensesTextBox.Clear();
                OtherExpensesTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Other Expenses cannot be empty it must contain at least '0'");
                OtherExpensesTextBox.Text = "0";
                return false;
            }
            return true;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ListData.LoadDataInToDataGridView(DailyExpenseDataGridView, "usp_ExpensesDailyExpensesListData");

        }

        private void PrintButton_Click(object sender, EventArgs e)
        {
            PrintDailyExpensesForm PE = new PrintDailyExpensesForm();
            PE.Show();
        }

        
    }
}
