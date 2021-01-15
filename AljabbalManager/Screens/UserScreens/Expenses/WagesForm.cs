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
using System.Data.SqlClient;

namespace ASDBFramework.Screens.UserScreens.Expenses
{
    public partial class WagesForm : TemplateForm
    {
        public WagesForm()
        {
            InitializeComponent();
        }

        private void WagesForm_Load(object sender, EventArgs e)
        {
            ListData.LoadDataInToComboBox(EmployeeNameComboBox, "usp_EmployeeDetailListAllEmployeesName");
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_ExpensesAddDataIntoWages", GetObject());
                ASMessageBox.ShowSucessMessage("Record Inserted Successfully");
            }
        }

        private Wages GetObject()
        {
            Wages _wages = new Wages();
            _wages.EmployeeName = EmployeeNameComboBox.Text;
            _wages.CurrentMonth = MonthComboBox.Text;
            _wages.CurrentYear = YearTextBox.Text;
            _wages.TotalAmount = Convert.ToInt32(TotalAmountTextBox.Text);
            _wages.CreatedBy = LoggedInUser.UserName;
            _wages.CreatedDate = DateTime.Today;
            return _wages;
        }

        private bool IsFormValid()
        {
            if (EmployeeNameComboBox.Text.Trim() == string.Empty)
            {
                EmployeeNameComboBox.SelectedIndex = -1;
                EmployeeNameComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Employee name is required");
                return false;
            }
            if (TotalAmountTextBox.Text.Trim() == string.Empty)
            {
                TotalAmountTextBox.Clear();
                TotalAmountTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Total Amount is required");
                TotalAmountTextBox.Text = "0";
                return false;

            }
            if (MonthComboBox.Text.Trim() == string.Empty)
            {
                MonthComboBox.SelectedIndex = -1;
                MonthComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Please Select Current Month");
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
            ListData.LoadDataInToDataGridView(SaleriesDataGridView, "usp_ExpensesWagesExpensesListData");
        }

        private void EmployeeNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EmployeeNameComboBox.SelectedIndex == -1)
            {CurrentSalaryTextBox.Text = string.Empty; }
            else
            {
                ChangeCurrentSalaryTextBox();
            }  
        }

        private void ChangeCurrentSalaryTextBox()
        {
            try
            {

                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        CurrentSalary
                                    FROM            EmployeesDetail
                                    WHERE        (FullName = @FullName)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", EmployeeNameComboBox.Text);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        CurrentSalaryTextBox.Text = reader["CurrentSalary"].ToString();
                    }
                }
            }
            catch (Exception)
            {
                // ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void EmployeeNameComboBox_TextChanged(object sender, EventArgs e)
        {
            if (EmployeeNameComboBox.Text.Trim() == string.Empty)
            { CurrentSalaryTextBox.Text = string.Empty; }
            else
            {
                ChangeCurrentSalaryTextBox();
            }
        }
    }
}
