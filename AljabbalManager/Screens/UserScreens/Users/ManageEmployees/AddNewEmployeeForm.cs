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
using ASDBFramework.Models.Users;

namespace ASDBFramework.Screens.UserScreens.Users.ManageEmployees
{
    public partial class AddNewEmployeeForm : TemplateForm
    {
        public int EmployeeId { get; set; }
        public AddNewEmployeeForm()
        {
            InitializeComponent();
        }

        private void AddNewEmployeeForm_Load(object sender, EventArgs e)
        {
            StatusComboBox.Visible = false;
            label5.Visible = false;
            LoadDataAndBindToControlIfUpdate();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (this.IsUpdate)
                {
                    UpdateExistingEmployee();
                    this.Close();
                }
                else
                {
                    AddNewEmployeeIntoEmployeeDetail();
                }
            }
        }

        private void UpdateExistingEmployee()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       EmployeesDetail
SET                FullName = @FullName, DOB = @DOB, NIC = @NIC, Email = @Email, Mobile = @Mobile, Gender = @Gender, CurrentSalary = @CurrentSalary, StartingSalary = @StartingSalary, Address = @Address, 
                         EmploymentStatus = @EmploymentStatus, CreatedBy = @CreatedBy, CreatedDate = @CreatedDate";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", FullNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@NIC", CNICTextBox.Text);

                        cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Mobile", PhoneNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@CurrentSalary", CurrentSalaryTextBox.Text);

                        cmd.Parameters.AddWithValue("@Address", AddressLineTextBox.Text);
                        cmd.Parameters.AddWithValue("@StartingSalary", StartingSalaryTextBox.Text);
                        cmd.Parameters.AddWithValue("@EmploymentStatus", StatusComboBox.Text);

                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("Employee Record Updated Successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in inserting data into Employee detail: " + ex.Message);

            }
        }

        private void AddNewEmployeeIntoEmployeeDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO EmployeesDetail
                         (FullName, DOB, NIC, Email, Mobile, Gender, CurrentSalary, StartingSalary, Address, EmploymentStatus, CreatedBy, CreatedDate)
            VALUES        (@FullName, @DOB, @NIC, @Email, @Mobile, @Gender, @CurrentSalary, @StartingSalary, @Address,@EmploymentStatus, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@FullName", FullNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@NIC", CNICTextBox.Text);

                        cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Mobile", PhoneNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@CurrentSalary", CurrentSalaryTextBox.Text);

                        cmd.Parameters.AddWithValue("@Address", AddressLineTextBox.Text);
                        cmd.Parameters.AddWithValue("@StartingSalary", StartingSalaryTextBox.Text);
                        cmd.Parameters.AddWithValue("@EmploymentStatus", "Employee");

                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("New Employee Added Successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in inserting data into Employee detail: " + ex.Message);

            }
        }

        private bool IsFormValid()
        {
            if (FullNameTextBox.Text.Trim() == string.Empty)
            {
                FullNameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Full name is required.");
                return false;
            }
            if (DOBDateTimePicker.CustomFormat == " ")
            {
                DOBDateTimePicker.Focus();
                ASMessageBox.ShowErrorMessage("Date of birth is required.");
                return false;
            }
            if (CNICTextBox.Text.Trim() == string.Empty)
            {
                CNICTextBox.Focus();
                ASMessageBox.ShowErrorMessage("NIC is required.");
                return false;
            }
            if (CurrentSalaryTextBox.Text.Trim() == string.Empty)
            {
                CurrentSalaryTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Current Salary is required.");
                return false;
            }
            if (StartingSalaryTextBox.Text.Trim() == string.Empty)
            {
                StartingSalaryTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Starting is required.");
                return false;
            }
            if (GenderComboBox.SelectedIndex == -1)
            {
                GenderComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Gender is required.");
                return false;
            }
            if (PhoneNoTextBox.Text.Trim() == string.Empty)
            {
                PhoneNoTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Mobile no is required.");
                return false;
            }
            if (AddressLineTextBox.Text.Trim() == string.Empty)
            {
                AddressLineTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Address is required.");
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
            if (this.IsUpdate)
            {
                this.Close();
            }
            else
            {
                FullNameTextBox.Text = string.Empty;
                DOBDateTimePicker.CustomFormat = " ";
                CNICTextBox.Text = string.Empty;
                CurrentSalaryTextBox.Text = string.Empty;
                StartingSalaryTextBox.Text = string.Empty;
                EmailTextBox.Text = string.Empty;
                GenderComboBox.SelectedIndex = -1;
                PhoneNoTextBox.Text = string.Empty;
                AddressLineTextBox.Text = string.Empty;
            }
        }

        private void LoadDataAndBindToControlIfUpdate()
        {
            if (this.IsUpdate)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                label3.Text = "Update Existing Employee";
                SaveButton.Text = "Update";
                ExitButton.Text = "Close";
                StatusComboBox.Visible = true;
                label5.Visible = true;
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                DataTable dtBranch = db.GetDataList("usp_EmployeeDetailGetEmployeeInfoByEmployeeId", new DBParameter { Parameter = "@EmployeeId", Value = this.EmployeeId });

                DataRow row = dtBranch.Rows[0];
                FullNameTextBox.Text = row["FullName"].ToString();
                CNICTextBox.Text = row["NIC"].ToString();
                GenderComboBox.Text = row["Gender"].ToString();
                DOBDateTimePicker.Text = row["DOB"].ToString();
                PhoneNoTextBox.Text = row["Mobile"].ToString();
                EmailTextBox.Text = row["Email"].ToString();
                CurrentSalaryTextBox.Text = row["CurrentSalary"].ToString();
                StartingSalaryTextBox.Text = row["StartingSalary"].ToString();
                AddressLineTextBox.Text = row["Address"].ToString();
                StatusComboBox.Text = row["EmploymentStatus"].ToString();

            }
        }
    }
}
