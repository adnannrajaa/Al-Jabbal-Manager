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
using ASDBFramework.Utillities.Lists;

namespace ASDBFramework.Screens.UserScreens.Products.ManageToken
{
    public partial class ManageTokenForm : TemplateForm
    {
        public ManageTokenForm()
        {
            InitializeComponent();
        }

        private void ManageTokenForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            LoadDataIntoComboBoxes();
        }

        private void LoadDataIntoComboBoxes()
        {
            ListData.LoadDataInToComboBox(TokenBrandComboBox, "usp_TokenBrandsListBrandName");
            ListData.LoadDataInToComboBox(SaleTokenBrandComboBox, "usp_TokenBrandsListBrandName");
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        BrandId as 'Brand Id', BrandName as 'Brand Name', CreatedBy as 'Created By', CreatedDate as 'Created Date'
                                    FROM            TokenBrands";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable mydt = new DataTable();
                        da.Fill(mydt);
                        ViewTokenBrandDataGridView.DataSource = mydt;
                        ViewTokenBrandDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        ViewTokenBrandDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Load Token Brands into DataGridView:\n" + ex.Message);

            }
        }

        private void BrandAddButton_Click(object sender, EventArgs e)
        {
            
            if (IsFormValid())
            {
                if(BrandAddButton.Text == "Add")
                InsertToTokenBrands();
                if (BrandAddButton.Text == "Update")
                    UpdateTokenBrands();

            }

        }

        private void UpdateTokenBrands()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Comand = @"UPDATE       TokenBrands
                                    SET                BrandName =@BrandName, CreatedBy =@CreatedBy, CreatedDate =@CreatedDate
                                    where BrandId =@BrandId";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Comand, conn))
                    {
                        cmd.Parameters.AddWithValue("@BrandId", BrandIdTextBox.Text);
                        cmd.Parameters.AddWithValue("@BrandName", BrandNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("Brand Updated Successfully.");
                        LoadDataIntoDataGridView();
                        ClearBoxes();
                    }

                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Updateing token brands:\n" + ex.Message);
            }
        }

        private void InsertToTokenBrands()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Comand = @"INSERT INTO TokenBrands
                                                   (BrandId, BrandName, CreatedBy, CreatedDate)
                                        VALUES        (@BrandId, @BrandName, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Comand, conn))
                    {
                        cmd.Parameters.AddWithValue("@BrandId", BrandIdTextBox.Text);
                        cmd.Parameters.AddWithValue("@BrandName", BrandNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("Brand Added Successfully.");
                        LoadDataIntoDataGridView();
                        ClearBoxes();
                    }

                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in inserting to token brands:\n" + ex.Message);

            }
        }

        private bool IsFormValid()
        {
            if (BrandIdTextBox.Text.Trim() == string.Empty)
            {
                BrandIdTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Brand id is requird.");
                return false;
            }
            if (BrandNameTextBox.Text.Trim() == string.Empty)
            {
                BrandNameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Brand name is requird.");
                return false;
            }

            return true;
        }

        private void BrandClearButton_Click(object sender, EventArgs e)
        {
            ClearBoxes();
        }

        private void ClearBoxes()
        {
            BrandIdTextBox.Text = string.Empty;
            BrandNameTextBox.Text = string.Empty;
            BrandIdTextBox.Enabled = true;
            BrandAddButton.Text = "Add";
        }

        private void ViewTokenBrandDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                BrandIdTextBox.Text = ViewTokenBrandDataGridView.SelectedRows[0].Cells[0].Value.ToString();
                BrandNameTextBox.Text = ViewTokenBrandDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                BrandIdTextBox.Enabled = false;
                BrandAddButton.Text = "Update";
            }
            catch (Exception)
            { }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (IsPurchasesFormValid())
            {
                AddToTokenPurchases();
            }
        }

        private bool IsPurchasesFormValid()
        {
            if (TokenBrandComboBox.SelectedIndex == -1)
            {
                TokenBrandComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Token Brand is requird.");
                return false;
            }
            if (TotalAmountTextBox.Text.Trim() == string.Empty)
            {
                TotalAmountTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Amount is requird.");
                return false;
            }
            return true;
        }

        private void AddToTokenPurchases()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Comand = @"INSERT INTO TokenPurchases
                         ( BrandName, TotalAmount, CreatedBy, CreatedDate)
                   VALUES         (@BrandName, @TotalAmount, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Comand, conn))
                    {
                        cmd.Parameters.AddWithValue("@BrandName", TokenBrandComboBox.Text);
                        cmd.Parameters.AddWithValue("@TotalAmount", TotalAmountTextBox.Text);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("Brand Purchases Successfully.");
                    }

                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in inserting to token Purchases:\n" + ex.Message);

            }
        }

        private void SaleTokenSaveButton_Click(object sender, EventArgs e)
        {
            if (IsSaleFormValid())
            {
                AddToTokenSales();
            }
        }

        private bool IsSaleFormValid()
        {
            if (SaleTokenBrandComboBox.SelectedIndex == -1)
            {
                SaleTokenBrandComboBox.Focus();
                ASMessageBox.ShowErrorMessage("Token Brand is requird.");
                return false;
            }
            if (SaleTokenAmountTextBox.Text.Trim() == string.Empty)
            {
                SaleTokenAmountTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Amount is requird.");
                return false;
            }
            return true;
        }

        private void AddToTokenSales()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Comand = @"INSERT INTO TokenSale
                         (BrandName, TotalAmount, CreatedBy, CreatedDate)
                   VALUES         (@BrandName, @TotalAmount, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Comand, conn))
                    {
                        cmd.Parameters.AddWithValue("@BrandName", SaleTokenBrandComboBox.Text);
                        cmd.Parameters.AddWithValue("@TotalAmount", SaleTokenAmountTextBox.Text);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                        ASMessageBox.ShowSucessMessage("Brand Sale Successfully.");
                    }

                }

            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in inserting to token Sales:\n" + ex.Message);

            }
        }

        private void ViewButton_Click(object sender, EventArgs e)
        {
            if (PurchasesTokenDateTimePicker.CustomFormat != " ")
            {
                TokenPurchaseRecordLoadIntoDataGridViewWithSelectedDate();
            }
            else
            {
                TokenPurchaseRecordLoadIntoDataGridView();
            }
        }

        private void TokenPurchaseRecordLoadIntoDataGridViewWithSelectedDate()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT   BrandName AS 'Brand Name', TotalAmount AS 'Amount', CreatedDate AS 'Purchase Date'
                                    FROM            TokenPurchases Where CreatedDate=@CreatedDate";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@CreatedDate",PurchasesTokenDateTimePicker.Value.Date);
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable mydt = new DataTable();
                        da.Fill(mydt);
                        TokenPurchaseDataGridView.DataSource = mydt;
                        TokenPurchaseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        TokenPurchaseDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Load Token Purchases into DataGridView:\n" + ex.Message);

            }
        }

        private void TokenPurchaseRecordLoadIntoDataGridView()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT   TOP (20)     BrandName AS 'Brand Name', TotalAmount AS 'Amount', CreatedDate AS 'Purchase Date'
                                    FROM            TokenPurchases
                                    ORDER BY 'Purchase Date' DESC";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable mydt = new DataTable();
                        da.Fill(mydt);
                        TokenPurchaseDataGridView.DataSource = mydt;
                        TokenPurchaseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        TokenPurchaseDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Load Token Purchases into DataGridView:\n" + ex.Message);

            }
        }

        private void SaleTokenViewButton_Click(object sender, EventArgs e)
        {
            if (SaleTokenDateTimePicker.CustomFormat != " ")
            {
                TokenSaleRecordLoadIntoDataGridViewWithSelectedDate();
            }
            else
            {
                TokenSaleRecordLoadIntoDataGridView();
            }

        }

        private void TokenSaleRecordLoadIntoDataGridViewWithSelectedDate()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT  BrandName AS 'Brand Name', TotalAmount AS 'Amount', CreatedDate AS 'Purchase Date'
                                    FROM            TokenSale where CreatedDate=@CreatedDate";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@CreatedDate",SaleTokenDateTimePicker.Value.Date);
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable mydt = new DataTable();
                        da.Fill(mydt);
                        SaleTokenDataGridView.DataSource = mydt;
                        SaleTokenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        SaleTokenDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Load Token Sale into DataGridView:\n" + ex.Message);

            }
        }

        private void TokenSaleRecordLoadIntoDataGridView()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        TOP (20) BrandName AS 'Brand Name', TotalAmount AS 'Amount', CreatedDate AS 'Purchase Date'
                                    FROM            TokenSale
                                    ORDER BY 'Purchase Date' DESC";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable mydt = new DataTable();
                        da.Fill(mydt);
                        SaleTokenDataGridView.DataSource = mydt;
                        SaleTokenDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        SaleTokenDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                    }
                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error in Load Token Sale into DataGridView:\n" + ex.Message);

            }
        }

        private void PurchasesTokenDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            PurchasesTokenDateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void SaleTokenDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            SaleTokenDateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void PurchasesTokenDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                PurchasesTokenDateTimePicker.CustomFormat = " ";
            }
        }

        private void SaleTokenDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                SaleTokenDateTimePicker.CustomFormat = " ";
            }
        }

    }
}
