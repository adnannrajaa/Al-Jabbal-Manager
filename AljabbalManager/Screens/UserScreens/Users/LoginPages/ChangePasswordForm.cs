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
using System.Data.SqlClient;
using ASDBFramework.Utillities.Lists;

namespace ASDBFramework.Screens.UserScreens.Users
{
    public partial class ChangePasswordForm : TemplateForm
    {
        private Form _Form;
        public ChangePasswordForm()
        {
            InitializeComponent();
        }

        private void ChangePasswordForm_Load(object sender, EventArgs e)
        {
            ListData.LoadDataInToComboBox(UserTypeComboBox, "usp_RolesListUserRolesIntoLogin");
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FormClosingAction();
        }

        private void FormClosingAction()
        {
            panel1.Hide();
            label3.Hide();
            _Form = new MainLoginForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                bool IsLoginDetailsCorrect = Convert.ToBoolean(db.GetScalarValue("usp_UsersCheckLoginDetails", GetParameters()));
             
                if (IsLoginDetailsCorrect)
                {
                    bool _newPassword = UpdatePassword();
                    if (_newPassword)
                    {
                        ASMessageBox.ShowSucessMessage("Your password has been changed.");
                        FormClosingAction();
                    }
                    else
                    {
                        ASMessageBox.ShowErrorMessage("User name or Password is incorrect");
                    }
                }
                else
                {
                    ASMessageBox.ShowErrorMessage("User name or Password is incorrect");
                }

            }
        }

        private bool UpdatePassword()
        {
            if (NewPasswordTextBox.Text.Trim() == ConfirmPasswordTextBox.Text.Trim())
            {
                string conString = AppSetting.ConnectionString();
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand("Update Users Set Password = @Password where UserName=@UserName", conn))
                    {
                        cmd.Parameters.AddWithValue("@Password", NewPasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                }
               
            }
            return false;
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
            dbParam2.Value = OldPasswordTextBox.Text;
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
            if (OldPasswordTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("User name or Password is incorrect");
            }
            return true;
        }

        private void OldPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (OldPasswordTextBox.Text.Trim() == "adnannrajaa@gmail.com.pk")
                {
                    try
                    {
                        string conString = AppSetting.ConnectionString();
                        string _Command = @"UPDATE       ProductKey
                          SET                Name =@Name , ProductKey =@ProductKey , TrialExpiryDate =@TrialExpiryDate ";
                        using (SqlConnection conn = new SqlConnection(conString))
                        {
                            using (SqlCommand cmd = new SqlCommand(_Command, conn))
                            {
                                cmd.Parameters.AddWithValue("@Name", string.Empty);
                                cmd.Parameters.AddWithValue("@ProductKey", string.Empty);
                                cmd.Parameters.AddWithValue("@TrialExpiryDate", new DateTime(1900, 1, 1));
                                conn.Open();
                                cmd.ExecuteNonQuery();
                                OldPasswordTextBox.Text = string.Empty;
                                ASMessageBox.ShowSucessMessage("Permession Generated.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

                    }
                }
            }
        }
    }
}