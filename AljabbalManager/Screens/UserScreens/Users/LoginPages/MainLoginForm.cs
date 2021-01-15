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
using ASDBFramework.Windows;
using ASDBFramework.Models.Users;
using ASDBFramework.Utillities.Lists;

namespace ASDBFramework.Screens.UserScreens.Users
{
    public partial class MainLoginForm : TemplateForm
    {
       
        public MainLoginForm()
        {
            InitializeComponent();
        }
        private void MainLoginForm_Load(object sender, EventArgs e)
        {
            ListData.LoadDataInToComboBox(UserTypeComboBox, "usp_RolesListUserRolesIntoLogin");

        }
        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                bool IsLoginDetailsCorrect = Convert.ToBoolean(db.GetScalarValue("usp_UsersCheckLoginDetails", GetParameters()));
                if (IsLoginDetailsCorrect)
                {
                    GetLoggedInUserSettings();
                    
                    Form.ActiveForm.Hide();
                    UserDeshBoardForm sho = new UserDeshBoardForm();
                    sho.Show();
                }
                else
                {
                    ASMessageBox.ShowErrorMessage("User name or Password is incorrect");
                }

            }
        }
        private void GetLoggedInUserSettings()
        {
            LoggedInUser.UserType = UserTypeComboBox.Text.Trim().ToUpper();
            LoggedInUser.UserName = UserNameTextBox.Text.Trim().ToUpper();
        }

        private DBParameter[] GetParameters()
        {
            List<DBParameter> parameters = new List<DBParameter>();

            DBParameter dbParam1 = new DBParameter();
            dbParam1.Parameter = "@UserName";
            dbParam1.Value = UserNameTextBox.Text;
            parameters.Add(dbParam1);

            DBParameter dbParam2 = new DBParameter();
            dbParam2.Parameter = "@Password";
            dbParam2.Value = PasswordTextBox.Text;
            parameters.Add(dbParam2);

            DBParameter dbParam3 = new DBParameter();
            dbParam3.Parameter = "@UserType";
            dbParam3.Value = UserTypeComboBox.Text;
            parameters.Add(dbParam3);

            return parameters.ToArray();
        }

        private bool IsFormValid()
        {
            if (UserTypeComboBox.Text.Trim() == string.Empty)
            {
                UserTypeComboBox.SelectedIndex = -1;
                UserTypeComboBox.Focus();
                ASMessageBox.ShowErrorMessage("User Type is required");
                return false;
            }
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                UserNameTextBox.Clear();
                UserNameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("User name is required");
                return false;

            }
            if (PasswordTextBox.Text == string.Empty)
            {
                PasswordTextBox.Clear();
                PasswordTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Password is required");
                return false;
            }
            return true;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       

    }
}
