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

namespace ASDBFramework.Screens.UserScreens.Expenses
{
    public partial class FreightInForm : TemplateForm
    {
        public FreightInForm()
        {
            InitializeComponent();
        }

        private void FreightInForm_Load(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_ExpensesAddDataIntoFreightIn", GetObject());
                ASMessageBox.ShowSucessMessage("Record Inserted Successfully");
            }
        }

        private FreightIn GetObject()
        {
            FreightIn _FreightIn = new FreightIn();
            _FreightIn.InvoiceNo = Convert.ToInt32(BillNoTextBox.Text);
            _FreightIn.TotalAmount = Convert.ToInt32(TotalAmountTextBox.Text);
            _FreightIn.CreatedBy = LoggedInUser.UserName;
            _FreightIn.CreatedDate = DateTime.Today;
            return _FreightIn;
        }

        private bool IsFormValid()
        {
            if (BillNoTextBox.Text.Trim() == string.Empty)
            {
                TotalAmountTextBox.Clear();
                BillNoTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Invoice No is required");
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
            return true;
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            ListData.LoadDataInToDataGridView(FreightInDataGridView, "usp_ExpensesFreightInExpensesListData");
        }

        
    }
}
