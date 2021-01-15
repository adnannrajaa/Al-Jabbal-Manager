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

namespace ASDBFramework.Screens.UserScreens.ProductLicense
{
    public partial class LicenseForm : TemplateForm
    {
        public int TotalDaysLeft { get; set; }
        public LicenseForm()
        {
            InitializeComponent();
        }

        private void LicenseForm_Load(object sender, EventArgs e)
        {
            TrialDaysLeftLabel.Text = "You have " + TotalDaysLeft + " days left in your trial Period.";
            if (TotalDaysLeft > 0)
            {
                ExitButton.Text = "Continue Trial";

            }
        }

        private void EnterLicenseKeyButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                try
                {
                    EnterNameAndProductKeyToDB();
                    ASMessageBox.ShowSucessMessage("Product Key is added to the system Successfully.");
                    this.Close();
                }
                catch (ApplicationException ex)
                { ASMessageBox.ShowErrorMessage("Error: "+ ex.Message); }
            }
        }

        private void EnterNameAndProductKeyToDB()
        {
            string conString = AppSetting.ConnectionString();
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Update ProductKey Set Name = @Name , ProductKey=@ProductKey", conn))
                {
                    cmd.Parameters.AddWithValue("@Name",NameTextBox.Text);
                    cmd.Parameters.AddWithValue("@ProductKey",ProductKeyMaskedTextBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool IsFormValid()
        {
            if (NameTextBox.Text.Trim() == string.Empty)
            {
                NameTextBox.Clear();
                NameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Name is required");
                return false;

            }
            if (!ProductKeyMaskedTextBox.MaskCompleted)
            {
                ProductKeyMaskedTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Product key should be 25 characters long.");
                return false;

            }
            else
            {
                bool isValid = CheckIsProductKeyValid(ProductKeyMaskedTextBox.Text);

                if (!isValid)
                {
                    ASMessageBox.ShowErrorMessage("Product key is not valid.");
                    return false;
                }
            }
            return true;
        }

        private bool CheckIsProductKeyValid(string productKey)
        {
            //Z45MA-6DN4T-AN6T4-KSH8U-OR4AN
            string part1 = productKey.Substring(3, 2);//MA
            string part2 = productKey.Substring(7, 2);//DN
            string part3 = productKey.Substring(12, 2);//AN
            string part4 = productKey.Substring(19, 2);//SH
            string part5 = productKey.Substring(27, 2);//AN
            productKey = part1 + part2 + part3 + part4 + part5;
            if (productKey != "MADNANSHAN")
            {
                return false;
            }
            return true;  
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            FormClosingAction();
        }

        private void LicenseForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingAction();
        }

        private void FormClosingAction()
        {
            if (TotalDaysLeft == 0)
            {
                Application.Exit();
            }
            else
            {
                this.Hide();   
            }
            
        }
    }
}
