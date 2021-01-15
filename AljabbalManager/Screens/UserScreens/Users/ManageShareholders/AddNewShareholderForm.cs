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
using System.Data.SqlClient;
using ASDBFramework.Utillities;
using ASDBFramework.Models.Users;

namespace ASDBFramework.Screens.UserScreens.Users.ManageShareholders
{
    public partial class AddNewShareholderForm : TemplateForm
    {
        int SizeOfArry = 0;
        float TotalCapital = 0;
        public int ShareholderId { get; set; }
        public AddNewShareholderForm()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (this.IsUpdate)
                {
                    UpdateShareholderIntoShareholderDetail();
                    UpdateCapitalRatio();
                    this.Close();
                }
                else
                {
                    AddNewShareholderIntoShareholderDetail();
                    UpdateCapitalRatio();
                }
               
            }
        }

        private void UpdateShareholderIntoShareholderDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       ShareholdersDetail
SET                ShareholderName = @ShareholderName, FatherName = @FatherName, DOB = @DOB, CNIC = @CNIC, Email = @Email, Mobile = @Mobile, Gender = @Gender, AddressLine = @AddressLine, 
                         StartingInverstment = @StartingInverstment, CurrentBalance = @CurrentBalance, CapitalRatio = @CapitalRatio, Status = 'Active', CreatedBy = @CreatedBy, CreatedDate = @CreatedDate
WHERE        (ShareholderId = @ShareholderId)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@ShareholderId", ShareholderId);

                        cmd.Parameters.AddWithValue("@ShareholderName", ShareholderNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@FatherName", ShareholderFatherName.Text);
                        cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@CNIC", CNICTextBox.Text);

                        cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Mobile", PhoneNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@AddressLine", AddressLineTextBox.Text);

                        cmd.Parameters.AddWithValue("@StartingInverstment", StartingBalanceTextBox.Text);
                        cmd.Parameters.AddWithValue("@CurrentBalance", StartingBalanceTextBox.Text);
                        cmd.Parameters.AddWithValue("@CapitalRatio", "0");

                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("Shareholder Detail Updated Successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in updateing data into ShareholderDetail detail: " + ex.Message);

            }
        }

        private void AddNewShareholderIntoShareholderDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO ShareholdersDetail
                         (ShareholderName, FatherName, DOB, CNIC, Email, Mobile, Gender, AddressLine, StartingInverstment, CurrentBalance, CapitalRatio,Status, CreatedBy, CreatedDate)
             VALUES      (@ShareholderName, @FatherName, @DOB, @CNIC, @Email, @Mobile, @Gender, @AddressLine, @StartingInverstment, @CurrentBalance, @CapitalRatio,'Active', @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@ShareholderName", ShareholderNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@FatherName", ShareholderFatherName.Text);
                        cmd.Parameters.AddWithValue("@DOB", DOBDateTimePicker.Value.Date);
                        cmd.Parameters.AddWithValue("@CNIC", CNICTextBox.Text);

                        cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                        cmd.Parameters.AddWithValue("@Mobile", PhoneNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@Gender", GenderComboBox.Text);
                        cmd.Parameters.AddWithValue("@AddressLine", AddressLineTextBox.Text);

                        cmd.Parameters.AddWithValue("@StartingInverstment", StartingBalanceTextBox.Text);
                        cmd.Parameters.AddWithValue("@CurrentBalance", StartingBalanceTextBox.Text);
                        cmd.Parameters.AddWithValue("@CapitalRatio","0");

                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("New Shareholder Added Successfully.");
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in inserting data into ShareholderDetail detail: " + ex.Message);

            }
        }

        private void UpdateCapitalRatio()
        {

            GetSizeofArrayAndTotalCapital();
            string[] _ShareholderName = new string[SizeOfArry];
            float[] _StartingBalance = new float[SizeOfArry];
            float[] _CapitalRatio = new float[SizeOfArry];

            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT DISTINCT ShareholderName, StartingInverstment
                                    FROM            ShareholdersDetail where Status = 'Active'";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        for (int i = 0; i < SizeOfArry; i++)
                        {
                            reader.Read();
                            _ShareholderName[i] = reader["ShareholderName"].ToString();
                            _StartingBalance[i] = Convert.ToInt32(reader["StartingInverstment"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            { ASMessageBox.ShowErrorMessage("Error in getting selecting from shareholder details\n" + ex.Message); }
            for (int i = 0; i < SizeOfArry; i++)
            {
                _CapitalRatio[i] = (_StartingBalance[i] / TotalCapital) * 100;
                string conString = AppSetting.ConnectionString();
                string _Command = @"UPDATE       ShareholdersDetail
                                    SET                CapitalRatio =@CapitalRatio
                                    Where ShareholderName =@ShareholderName ";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@CapitalRatio", _CapitalRatio[i]);
                        cmd.Parameters.AddWithValue("@ShareholderName", _ShareholderName[i]);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }

        private void GetSizeofArrayAndTotalCapital()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT DISTINCT COUNT(*) AS 'TotalSize', SUM(StartingInverstment) AS TotalCapital
                                      FROM            ShareholdersDetail where Status = 'Active'";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        SizeOfArry = Convert.ToInt32(reader["TotalSize"].ToString());
                        TotalCapital = Convert.ToInt32(reader["TotalCapital"].ToString());
                    }
                }
            }
            catch (Exception ex)
            { ASMessageBox.ShowErrorMessage("Error in size of array\n" + ex.Message); }
        }

        private bool IsFormValid()
        {
            if (ShareholderNameTextBox.Text.Trim() == string.Empty)
            {
                ShareholderNameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Shareholder name is required.");
                return false;
            }
            if (ShareholderFatherName.Text.Trim() == string.Empty)
            {
                ShareholderFatherName.Focus();
                ASMessageBox.ShowErrorMessage("Father name is required.");
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
            if (StartingBalanceTextBox.Text.Trim() == string.Empty)
            {
                StartingBalanceTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Starting balance or investment is required.");
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

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (this.IsUpdate)
            {
                this.Close();
            }
            else
            {
                ShareholderNameTextBox.Text = string.Empty;
                ShareholderFatherName.Text = string.Empty;
                DOBDateTimePicker.CustomFormat = " ";
                CNICTextBox.Text = string.Empty;
                StartingBalanceTextBox.Text = string.Empty;
                EmailTextBox.Text = string.Empty;
                GenderComboBox.SelectedIndex = -1;
                PhoneNoTextBox.Text = string.Empty;
                AddressLineTextBox.Text = string.Empty;
                SizeOfArry = 0;
                TotalCapital = 0;
            }
        }

        private void AddNewShareholderForm_Load(object sender, EventArgs e)
        {
            TextBoxesEnabledDisabled(false);
            LoadDataAndBindToControlIfUpdate();
        }
       
        private void LoadDataAndBindToControlIfUpdate()
        {
            if (this.IsUpdate)
            {
                FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
                label3.Text = "Update Existing Shareholder";
                SaveButton.Text = "Update";
                ClearButton.Text = "Close";
                 TextBoxesEnabledDisabled(true);
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                DataTable dtBranch = db.GetDataList("usp_ShareholderGetDataByShareholderId", new DBParameter { Parameter = "@ShareholderId", Value = this.ShareholderId });

                DataRow row = dtBranch.Rows[0];
                ShareholderNameTextBox.Text = row["ShareholderName"].ToString();
                ShareholderFatherName.Text = row["FatherName"].ToString();
                GenderComboBox.Text = row["Gender"].ToString();
                DOBDateTimePicker.Text = row["DOB"].ToString();
                CNICTextBox.Text = row["CNIC"].ToString();
                PhoneNoTextBox.Text = row["Mobile"].ToString();
                StartingBalanceTextBox.Text = row["StartingInverstment"].ToString();
                EmailTextBox.Text = row["Email"].ToString();
                AddressLineTextBox.Text = row["AddressLine"].ToString();
                StatusComboBox.Text = row["Status"].ToString();
                CurrentBalanceTextBox.Text = row["CurrentBalance"].ToString();
            }
        }

        private void TextBoxesEnabledDisabled(bool _Value)
        {
            StatusComboBox.Visible = _Value;
            CurrentBalanceTextBox.Visible = _Value;
            label10.Visible = _Value;
            label11.Visible = _Value;
        }
    }
}
