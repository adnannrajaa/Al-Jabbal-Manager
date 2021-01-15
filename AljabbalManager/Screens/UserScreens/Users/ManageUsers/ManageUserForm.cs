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
using System.Data.SqlClient;
using ASDBFramework.Utillities;
using ASDBFramework.Models.Users;
using ASDBFramework.Screens.UserScreens.Users.UserDeshBoard;

namespace ASDBFramework.Screens.UserScreens.Users
{
    public partial class ManageUserForm : TemplateForm
    {
        public ManageUserForm()
        {
            InitializeComponent();
        }

        private void ManageUserForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            ListData.LoadDataInToDataGridView(ManageUserDataGridView, "usp_UserListAllUsers");
        }

        private void ManageUserDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = ManageUserDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                string UserName = Convert.ToString(ManageUserDataGridView.Rows[rowIndex].Cells["UserName"].Value);
                ShowAddNewUserForm(UserName, true);

            }
            catch (Exception)
            { }
        }

        private void ShowAddNewUserForm(string _UserName, bool isUpdate)
        {
            AddNewUserForm anuf = new AddNewUserForm();
            anuf.UserName = _UserName;
            anuf.IsUpdate = isUpdate;
            anuf.ShowDialog();
            LoadDataIntoDataGridView();
        }
    }
}
