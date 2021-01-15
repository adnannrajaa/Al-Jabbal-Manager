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
using System.Data.SqlClient;
using ASDBFramework.Windows;
using ASDBFramework.Models.Products;
using ASDBFramework.Screens.UserScreens.Products;

namespace ASDBFramework.Screens.UserScreens.ModelScreens
{
    public partial class PurchasesProductForm : TemplateForm
    {
        AddNewPurchasesForm _ParentForm;
        public PurchasesProductForm(AddNewPurchasesForm obj)
        {
            InitializeComponent();
            _ParentForm = obj;
        }
        private void SelectProductForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoProductNameListBox();
            ProductNameTextBox.Focus();
        }

        
        //....................................................Product Name Session Start.................

        private void LoadDataIntoProductNameListBox()
        {
            ProductNameListBox.Items.Clear();
            string conString = AppSetting.ConnectionString();
            string _Command = @"Select Distinct ProductName From ProductsDetail";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow items in dt.Rows)
                    {
                        ProductNameListBox.Items.Add(items["ProductName"].ToString());
                    }
                }
            }
        }
        private void ProductNameTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (ProductNameTextBox.Text.Trim() == string.Empty)
            {
                LoadDataIntoProductNameListBox();
            }
            else
            {
                ProductNameListBox.Items.Clear();
                string conString = AppSetting.ConnectionString();
                string _Command = @"Select Distinct ProductName From ProductsDetail where ProductName like('" + ProductNameTextBox.Text + "%')";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        DataTable dt = new DataTable();
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(dt);
                        foreach (DataRow items in dt.Rows)
                        {
                            ProductNameListBox.Items.Add(items["ProductName"].ToString());
                        }
                    }
                }
            }
        }
        private void ProductNameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    ProductNameListBox.Focus();
                    ProductNameListBox.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
            }
        }
        private void ProductNameListBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProductNameTextBox.Text = ProductNameListBox.SelectedItem.ToString();
                    ProductNameTextBox.Focus();
                    ProductNameListBox.Items.Clear();
                }
            }
            catch (Exception)
            {
            }

        }
        private void ProductNameTextBox_TextChanged(object sender, EventArgs e)
        {
            LoadDataIntoProductDescriptionListBoxWithProductName();
        }
        
        //....................................................Product Name Session End.................
        //....................................................Product Description Session Start.................

        private void ProductDescriptionTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (ProductDescriptionTextBox.Text.Trim() == string.Empty)
            {
               
                LoadDataIntoProductDescriptionListBoxWithProductName();
            }
            else
            {
                try
                {
                    ProductDescriptionListBox.Items.Clear();
                    string conString = AppSetting.ConnectionString();
                    string _Command = @"Select Distinct ProductDescription From ProductsDetail where ProductName='" + ProductNameTextBox.Text + "' and ProductDescription like('" + ProductDescriptionTextBox.Text + "%')";
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(_Command, conn))
                        {

                            conn.Open();
                            cmd.ExecuteNonQuery();
                            DataTable dt = new DataTable();
                            SqlDataAdapter da = new SqlDataAdapter(cmd);
                            da.Fill(dt);
                            foreach (DataRow items in dt.Rows)
                            {
                                ProductDescriptionListBox.Items.Add(items["ProductDescription"].ToString());
                            }
                        }
                    }
                }
                catch (Exception)
                {
                    ASMessageBox.ShowErrorMessage("Invalid Product Description. ");

                }
            }
        }

        private void LoadDataIntoProductDescriptionListBoxWithProductName()
        {
            ProductDescriptionListBox.Items.Clear();
            string conString = AppSetting.ConnectionString();
            string _Command = @"Select Distinct ProductDescription From ProductsDetail where ProductName='" + ProductNameTextBox.Text + "'";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    da.Fill(dt);
                    foreach (DataRow items in dt.Rows)
                    {
                        ProductDescriptionListBox.Items.Add(items["ProductDescription"].ToString());
                    }
                }
            }
        }
        private void ProductDescriptionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Down)
                {
                    ProductDescriptionListBox.Focus();
                    ProductDescriptionListBox.SelectedIndex = 0;
                }
            }
            catch (Exception)
            {
            }
        }
        private void ProductDescriptionListBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {
                    ProductDescriptionTextBox.Text = ProductDescriptionListBox.SelectedItem.ToString();
                    ProductDescriptionTextBox.Focus();
                    ProductDescriptionListBox.Items.Clear();
                }
            }
            catch (Exception)
            {
            }

        }
        //....................................................Product Description Session End.................

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                try
                {
                    string conString = AppSetting.ConnectionString();
                    string _Command = @"Select ProductCode,ProductDescription,ProductUnit From ProductsDetail where ProductName=@ProductName and ProductDescription=@ProductDescription";
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(_Command, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductName", ProductNameTextBox.Text);
                            cmd.Parameters.AddWithValue("@ProductDescription", ProductDescriptionTextBox.Text);
                            conn.Open();
                            SqlDataReader reader = cmd.ExecuteReader();
                            reader.Read();
                            _ParentForm.GetProductCode(reader["ProductCode"].ToString(), reader["ProductDescription"].ToString(), reader["ProductUnit"].ToString());
                            this.Dispose();


                        }
                    }
                }
                catch (Exception)
                {
                    ASMessageBox.ShowErrorMessage("Invalid Product Description. ");

                }
            }
        }

        private bool IsFormValid()
        {
            
            if (ProductNameTextBox.Text.Trim() == string.Empty)
            {
                
                ProductNameTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Product Name is required");
                return false;
            }
            if (ProductDescriptionTextBox.Text.Trim() == string.Empty)
            {
  
                ProductDescriptionTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Product Description is required");
                return false;
            }
            return true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void ProductNameListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ProductNameTextBox.Text = ProductNameListBox.SelectedItem.ToString();
                ProductNameTextBox.Focus();
                ProductNameListBox.Items.Clear();
            }
            catch (Exception)
            {
            }
        }

        private void ProductDescriptionListBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                ProductDescriptionTextBox.Text = ProductDescriptionListBox.SelectedItem.ToString();
                ProductDescriptionTextBox.Focus();
                ProductDescriptionListBox.Items.Clear();
            }
            catch (Exception)
            {
            }
        }

        
    }
}
