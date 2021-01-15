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
using ASDBFramework.Models.Users;
using System.Data.SqlClient;
using ASDBFramework.Utillities;

namespace ASDBFramework.Screens.UserScreens.Users.ManageEmployees
{
    public partial class ManageEmployeesForm : TemplateForm
    {
        public ManageEmployeesForm()
        {
            InitializeComponent();
        }

        private void ManageEmployeesForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeDataIntoDataGridView(); 
        }

        private void LoadEmployeeDataIntoDataGridView()
        {
            ListData.LoadDataInToDataGridView(ManageEmployeeDataGridView, "usp_EmployeeDetailListAllEmployees");
        }

        private void ManageEmployeeDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = ManageEmployeeDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int _EmployeeId = Convert.ToInt32(ManageEmployeeDataGridView.Rows[rowIndex].Cells["EmployeeId"].Value);
                ShowAddNewEmployeeForm(_EmployeeId, true);

            }
            catch (Exception)
            { }
        }

        private void ShowAddNewEmployeeForm(int _EmployeeId, bool isUpdate)
        {
            AddNewEmployeeForm anuf = new AddNewEmployeeForm();
            anuf.EmployeeId = _EmployeeId;
            anuf.IsUpdate = isUpdate;
            anuf.ShowDialog();
            LoadEmployeeDataIntoDataGridView();
        }
    }
}
