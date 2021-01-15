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
    public partial class DrawingsForm : TemplateForm
    {
        public DrawingsForm()
        {
            InitializeComponent();
        }

        private void DrawingsForm_Load(object sender, EventArgs e)
        {
            ListData.LoadDataInToComboBox(ShareholderNameComboBox, "usp_ShareholdersDetailListAllShareholdersName");
            TotalAmountTextBox.Text = "0";
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_ExpensesAddDataIntoDrawings", GetObject());
                ASMessageBox.ShowSucessMessage("Record Inserted Successfully");
            }
        }

        private Drawings GetObject()
        {
            Drawings _Drawings = new Drawings();
            _Drawings.StackHolderName = ShareholderNameComboBox.Text;
            _Drawings.DrawingAmount = Convert.ToInt32(TotalAmountTextBox.Text);
            _Drawings.CreatedBy = LoggedInUser.UserName;
            _Drawings.CreatedDate = DateTime.Today;
            return _Drawings;
        }
        private bool IsFormValid()
        {
            if (ShareholderNameComboBox.Text.Trim() == string.Empty)
            {
                ShareholderNameComboBox.SelectedIndex = -1;
                ShareholderNameComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Stack holder name is required");
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
            ListData.LoadDataInToDataGridView(DrawingsDataGridView, "usp_ExpensesDrawingsExpensesListData");

        }
    }
}
