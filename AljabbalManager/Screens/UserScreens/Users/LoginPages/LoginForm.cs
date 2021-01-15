using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens;
using ASDBFramework;
using ASDBFramework.Utillities;
using ASDBFramework.Windows;
using ASDBFramework.Models.Users;
using System.Threading;
using ASDBFramework.Screens.SplashScreen;
using ASDBFramework.Models;
using System.Data.SqlClient;
using ASDBFramework.Screens.UserScreens.ProductLicense;
using ASDBFramework.Screens.UserScreens.Users;
using System.IO;


namespace ASDBFramework.Screens
{
    public partial class LoginForm : TemplateForm
    {
        private Form _Form;
       
        public LoginForm()
        {
            
            Thread t = new Thread(new ThreadStart(SplashScreen));
            t.Start();
            Thread.Sleep(11900);
            InitializeComponent();
            t.Abort();
        }
        public void SplashScreen()
        {
            Application.Run(new SplashScreenForm());
         }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            Directory.CreateDirectory(@"C:\\Users\\" + Environment.UserName + "\\Documents\\AljabbalManager\\AljabbalManager\\DataBase");
            CheckProductKeyDetail();
            LoadMainLoginForm();  
        }

        private void LoadMainLoginForm()
        {
            _Form = new MainLoginForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }
        private void CheckProductKeyDetail()
        {
            int totalDaysLeft = 0;
            ProductLicense proLicense = GetProductKeyDetail();
            if (proLicense.ProductKey == string.Empty)
            {
                if (proLicense.TrialExpiryDate == new DateTime(1900, 1, 1))
                {
                    UpdateTrialExpiryDate();
                    totalDaysLeft = FindTotalTrialDaysLeft(DateTime.Now.AddMonths(1), DateTime.Now);
                }
                else
                {
                    totalDaysLeft = FindTotalTrialDaysLeft(proLicense.TrialExpiryDate, DateTime.Now);
                }
                ShowLicenseForm(totalDaysLeft);
            }
        }

        private void ShowLicenseForm(int totalDaysLeft)
        {
            LicenseForm lf = new LicenseForm();
            lf.TotalDaysLeft = totalDaysLeft;
            lf.ShowDialog();

        }

        private int FindTotalTrialDaysLeft(DateTime trialExpiryDate, DateTime CurrentDate)
        {
            int TotalDaysLeft = Convert.ToInt16((trialExpiryDate - CurrentDate).TotalDays);
            if (TotalDaysLeft < 0)
                TotalDaysLeft = 0;
            return TotalDaysLeft;
        }

        private void UpdateTrialExpiryDate()
        {

            string conString = AppSetting.ConnectionString();
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Update ProductKey Set TrialExpiryDate = @TrialExpiryDate", conn))
                {
                    cmd.Parameters.AddWithValue("@TrialExpiryDate", DateTime.Now.AddMonths(1));
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
        private ProductLicense GetProductKeyDetail()
        {
            ProductLicense pl = new ProductLicense();
            string conString = AppSetting.ConnectionString();
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand("Select * from ProductKey", conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    pl.Name = reader["Name"].ToString();
                    pl.ProductKey = reader["ProductKey"].ToString();
                    pl.TrialExpiryDate = Convert.ToDateTime(reader["TrialExpiryDate"]);
                }

            }
            return pl;
        }  
        private void ChangePasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _Form.Dispose();
            _Form = new ChangePasswordForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

       

        

        

       

        
    }
}
