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

namespace ASDBFramework.Screens.UserScreens.Users.UserDeshBoard
{
    public partial class AddNewUserForm : TemplateForm
    {
        string RoleId = null;
        public AddNewUserForm()
        {
            InitializeComponent();
        }
        public string UserName { get; set; }
        private void AddNewUserForm_Load(object sender, EventArgs e)
        {
            ListData.LoadDataInToComboBox(UserTypeComboBox, "usp_RolesListUserRolesIntoLogin");
            LoadDataAndBindToControlIfUpdate();
        }

        private void LoadDataAndBindToControlIfUpdate()
        {
            if (this.IsUpdate)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                label3.Text = "Update Existing User";
                SaveButton.Text = "Update";
                ExitButton.Text = "Close";
                UserNameTextBox.Enabled=false;
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                DataTable dtBranch = db.GetDataList("usp_UsersGetUserDataByUserName", new DBParameter { Parameter = "@UserName", Value = this.UserName });

                DataRow row = dtBranch.Rows[0];
                FirstNameTextBox.Text = row["FirstName"].ToString();
                LastNameTextBox.Text = row["LastName"].ToString();
                GenderComboBox.Text = row["Gender"].ToString();
                DOBDateTimePicker.Text = row["DateOfBirth"].ToString();
                UserTypeComboBox.Text = row["RoleId"].ToString();
                PhoneNoTextBox.Text = row["PhoneNo"].ToString();
                CellNoTextBox.Text = row["CellNo"].ToString();
                EmailTextBox.Text = row["Email"].ToString();
                UserNameTextBox.Text = row["UserName"].ToString();
                PasswordTextBox.Text = row["Password"].ToString();

            }
        }

        private void LoadNotes()
        {
            try
            {

                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        RoleId,Notes
                                    FROM            Roles
                                    WHERE        (Description = @Description)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@Description", UserTypeComboBox.Text);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        LabelUserTypeDescription.Text = reader["Notes"].ToString();
                        RoleId = reader["RoleId"].ToString();
                    }
                }
            }
            catch (Exception)
            {
               // ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (this.IsUpdate)
                {
                    UpdateUserAccount();
                    ASMessageBox.ShowSucessMessage("User Account Updated Successfully.");
                    this.Close();
                }
                else
                {
                    AddUserAccount();
                    ASMessageBox.ShowSucessMessage("User Account Added Successfully.");
                }
                
            }

        }

        private void UpdateUserAccount()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       Users
SET                Password = @Password, RoleId = @RoleId, FirstName = @FirstName, LastName = @LastName, Gender = @Gender, DateOfBirth = @DateOfBirth, PhoneNo = @PhoneNo, CellNo = @CellNo, Email = @Email, 
                         CreatedBy = @CreatedBy, CreatedDate = @CreatedDate
WHERE        (UserName = @UserName)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("@RoleId", RoleId);

                        cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DOBDateTimePicker.Value);

                        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@CellNo", CellNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);

                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void AddUserAccount()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO Users
                         (UserName, Password, RoleId, FirstName, LastName, Gender, DateOfBirth, PhoneNo, CellNo, Email, CreatedBy, CreatedDate)
           VALUES        (@UserName, @Password, @RoleId, @FirstName, @LastName, @Gender, @DateOfBirth, @PhoneNo, @CellNo, @Email, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@UserName", UserNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                        cmd.Parameters.AddWithValue("@RoleId", RoleId);

                        cmd.Parameters.AddWithValue("@FirstName", FirstNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@LastName", LastNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@DateOfBirth", DOBDateTimePicker.Value);

                        cmd.Parameters.AddWithValue("@PhoneNo", PhoneNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@CellNo", CellNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);

                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
                        cmd.Parameters.AddWithValue("@CreatedBy",LoggedInUser.UserName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private bool IsFormValid()
        {
            if (FirstNameTextBox.Text.Trim() == string.Empty)
            {
                FirstNameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("First name is required.");
                return false;
            }
            if (LastNameTextBox.Text.Trim() == string.Empty)
            {
                LastNameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Last name is required.");
                return false;
            }
            if (GenderComboBox.SelectedIndex == -1)
            {
                GenderComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Gender is required.");
                return false;
            }
            if (DOBDateTimePicker.CustomFormat == " ")
            {
                DOBDateTimePicker.Focus();
                ASMessageBox.ShowErrorMessage("Date of Birth is required.");
                return false;
            }
            if (PhoneNoTextBox.Text.Trim() == string.Empty)
            {
                PhoneNoTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Phone no is required.");
                return false;
            }
            if (UserTypeComboBox.SelectedIndex == -1)
            {
                UserTypeComboBox.Focus();
                ASMessageBox.ShowErrorMessage("User type is required.");
                return false;
            }
            if (UserNameTextBox.Text.Trim() == string.Empty)
            {
                UserNameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("UserName is required.");
                return false;
            }
            if (PasswordTextBox.Text.Trim() == string.Empty)
            {
                PasswordTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Password is required.");
                return false;
            }
            if (PasswordTextBox.Text.Trim() !=ConfirmPasswordTextBox.Text.Trim())
            {
                ConfirmPasswordTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Password not matched.");
                return false;
            }
            return true;
        }

        private void DOBDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DOBDateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (ExitButton.Text == "Close")
            {
                this.Close();
            }
            else
            {
                FirstNameTextBox.Text = string.Empty;
                LastNameTextBox.Text = string.Empty;
                GenderComboBox.SelectedIndex = -1;
                DOBDateTimePicker.CustomFormat = " ";
                PhoneNoTextBox.Text = string.Empty;
                CellNoTextBox.Text = string.Empty;
                UserTypeComboBox.SelectedIndex = -1;
                EmailTextBox.Text = string.Empty;
                UserNameTextBox.Text = string.Empty;
                PasswordTextBox.Text = string.Empty;
                ConfirmPasswordTextBox.Text = string.Empty;
            }
        }

        private void UserTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (UserTypeComboBox.SelectedIndex == -1)
            { LabelUserTypeDescription.Text = " "; }
            else
            {
                LoadNotes();
            }
        }

        private void UserTypeComboBox_TextChanged(object sender, EventArgs e)
        {
            if (UserTypeComboBox.Text.Trim() == string.Empty)
            { LabelUserTypeDescription.Text = " "; }
            else
            { LoadNotes(); }
        }
    }
}
