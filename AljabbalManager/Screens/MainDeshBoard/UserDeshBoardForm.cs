using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens.Sales.SalesDeshBoard;
using ASDBFramework.Screens.UserScreens.Products.ProductDeshBoard;
using ASDBFramework.Screens.UserScreens.Expenses.ExpensesDeshBoard;
using ASDBFramework.Screens.UserScreens.Debiters.DebitersDeshBoard;
using ASDBFramework.Screens.UserScreens.Income.IncomeDeshBoard;
using ASDBFramework.Models.Users;
using ASDBFramework.Windows;
using ASDBFramework.Utillities;
using System.Data.SqlClient;
using ASDBFramework.Screens.UserScreens.Users.UserDeshBoard;

namespace ASDBFramework.Screens.UserScreens
{
    public partial class UserDeshBoardForm : TemplateForm
    {
        public UserDeshBoardForm()
        {
            InitializeComponent();
            TodayDateAndTime.Start();
        }
        private void UserDeshBoardForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoggedinAsToolStripStatusLabel.Text = "Logged in as = " + (LoggedInUser.UserName).ToLower() + "  ";
            }
            catch (Exception)
            {
            }
            CheckFormMessages();
        } 
        private void SalesPictureBox_Click(object sender, EventArgs e)
        {
            
            SalesDeshBoardForm sale = new SalesDeshBoardForm();
            sale.Show();
           
        }

         private void ItemsPictureBox_Click(object sender, EventArgs e)
        {
               //this.Hide();
                ProductDeshBoardForm products = new ProductDeshBoardForm();
                products.Show(); 
        }

        private void ExpensesPictureBox_Click(object sender, EventArgs e)
        {
            //this.Hide();
            ExpensesDeshBoardForm Expenses = new ExpensesDeshBoardForm();
            Expenses.Show();
        }

        private void DebitersPictureBox_Click(object sender, EventArgs e)
        {
            if (IsUserTypeCorrect())
            {
                //this.Hide();
                DebiterDeshBoardForm Debiter = new DebiterDeshBoardForm();
                Debiter.Show();
            }
        }

        private void IncomePictureBox_Click(object sender, EventArgs e)
        {
            if (IsUserTypeCorrect())
            {
                //this.Hide();
                FinicalTransactionForm Income = new FinicalTransactionForm();
                Income.Show();
            }
           
        }
        private void TodayDateAndTime_Tick(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            if (!AnyMessage())
            {
                this.DateToolStripStatusLabel.Text = "  " + dateTime.ToString() + "  ";
            }
            
           

        }
        private void CheckFormMessages()
        {
            if (AnyMessage())
            {
                ShowMessage.Text = "                                                                                                                              You have some important messages";
                View.Text = "||Click here to view||";
            }
            else
            {
                ShowMessage.Text = string.Empty;
                View.Text = string.Empty;
            }
        }

        private bool AnyMessage()
        {
            if (CheckStockMessage())
            {
                return true;
            }
            if (CheckCustomerDebitorMessage())
            {
                return true;
            }
            if (CheckCompannyPayableMessage())
            {
                return true;
            }
            return false;
        }

        private bool CheckCompannyPayableMessage()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        *
                                FROM            PurchasesPaymentDetail
                                WHERE        (DuePayment > 0) AND (DuePaymentDate <= @DuePaymentDate)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@DuePaymentDate", DateTime.Today);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckCustomerDebitorMessage()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        *
                                FROM            SalesCustomerPaymentDetail
                                WHERE        (DuePayment > 0) AND (DuePaymentDate <= @DuePaymentDate)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@DuePaymentDate",DateTime.Today);
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private bool CheckStockMessage()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"SELECT        *
                                FROM            ProductStock
                                WHERE        (ProductQuantity < OutOfStock)";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (AnyMessage())
            {
                NotificationForm _Form = new NotificationForm();
                  _Form.Show();
                 this.WindowState = FormWindowState.Minimized;
            }

        }

        private void UsersPictureBox_Click(object sender, EventArgs e)
        {
            if (IsUserTypeCorrect())
            {
                //this.Hide();
                UserInterfaceForm us = new UserInterfaceForm();
                us.Show();
            }

        }

        private bool IsUserTypeCorrect()
        {
            if (LoggedInUser.UserType != "DIRECTOR(MD)")
            {
                ASMessageBox.ShowSucessMessage("Access Denied!\nPlease contact to server administrator.","Information");
                return false;
            }
            return true;
        }

        private void UserDeshBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult Dialog = MessageBox.Show("Do you realy want to close the application ?", "Exit", MessageBoxButtons.YesNo);
            if (Dialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            if (Dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        

        
        
    
    }
}
