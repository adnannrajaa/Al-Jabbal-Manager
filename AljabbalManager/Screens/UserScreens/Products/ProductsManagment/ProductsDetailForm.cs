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
    using ASDBFramework.Models.Products;
    using ASDBFramework.Models.Users;
    using ASDBFramework.Windows;
    using System.Data.SqlClient;
using ASDBFramework.Utillities.Lists;

    namespace ASDBFramework.Screens.UserScreens.Products
    {
        public partial class ProductsDetailForm : TemplateForm
        {
            public ProductsDetailForm()
            {
                InitializeComponent();
            }

            private void ProductsDetailForm_Load(object sender, EventArgs e)
            {
                LoadDataIntoComboBoxes();
                GenerateProductCode();
                LoadDataIntoDataGridView();
            }

            private void LoadDataIntoDataGridView()
            {
                try
                {
                    string conString = AppSetting.ConnectionString();
                    string Command = @"SELECT        ProductCode, ProductName, ProductDescription, ProductUnit
                                        FROM            ProductsDetail
                                        Order By ProductName, ProductDescription";
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(Command, conn))
                        {
                            int i = 1;
                            conn.Open();
                            SqlDataAdapter DataAdapter = new SqlDataAdapter();
                            DataAdapter.SelectCommand = cmd;
                            DataTable GetData = new DataTable();
                            DataAdapter.Fill(GetData);
                            ProductsDetailDataGridView.Rows.Clear();
                            foreach (DataRow Items in GetData.Rows)
                            {
                                ProductsDetailDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                int n = ProductsDetailDataGridView.Rows.Add();
                                ProductsDetailDataGridView.Rows[n].Cells[0].Value = i;
                                ProductsDetailDataGridView.Rows[n].Cells[1].Value = Items["ProductCode"].ToString();
                                ProductsDetailDataGridView.Rows[n].Cells[2].Value = Items["ProductName"].ToString();
                                ProductsDetailDataGridView.Rows[n].Cells[3].Value = Items["ProductDescription"].ToString();
                                ProductsDetailDataGridView.Rows[n].Cells[4].Value = Items["ProductUnit"].ToString();
                                i++;
                            }
                            ProductsDetailDataGridView.ClearSelection();

                        }
                    }
                }
                catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
            }

            private void LoadDataIntoComboBoxes()
            {
                ListData.LoadDataInToComboBox(ProductNameComboBox, "usp_ProductsDetailListProductsName");
                ListData.LoadDataInToComboBox(ProductUnitComboBox, "usp_ProductsDetailListProductsUnit");


            }

            private void GenerateProductCode()
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                ProductCodeTextBox.Text = db.GetScalarValue("usp_ProductsDetailGenerateNewProductCode").ToString();
                ProductCodeTextBox.Enabled = false;
            }

            private void AddButton_Click(object sender, EventArgs e)
            {
                if (IsFormValid())
                {
                    if (!CheckProductExist())
                    {
                        SaveRecord();
                        ASMessageBox.ShowSucessMessage("Product Added Successfully.");
                        LoadDataIntoComboBoxes();
                        GenerateProductCode();
                        ClearExistingData();
                        LoadDataIntoDataGridView();
                    }
                }
            }

            private bool CheckProductExist()
            {
                if (RecordExist())
                {
                    UpdateProductRecord();
                    ASMessageBox.ShowSucessMessage("Product Updated Successfully.");
                    LoadDataIntoComboBoxes();
                    GenerateProductCode();
                    ClearExistingData();
                    LoadDataIntoDataGridView();
                    return true;
                }
                return false;
            }

            private bool RecordExist()
            {
                string conString = AppSetting.ConnectionString();
                string _Command = "Select 1 From ProductsDetail where ProductCode=@ProductCode ";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
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

            private void UpdateProductRecord()
            {
                string conString = AppSetting.ConnectionString();
                string _Command = "Update ProductsDetail Set ProductName = @ProductName , ProductDescription = @ProductDescription , ProductUnit = @ProductUnit where ProductCode=@ProductCode ";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductName", ProductNameComboBox.Text);
                        cmd.Parameters.AddWithValue("@ProductDescription", ProductDescriptionComboBox.Text);
                        cmd.Parameters.AddWithValue("@ProductUnit", ProductUnitComboBox.Text);
                        cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }

            private void ClearExistingData()
            {
                ProductsDetailDataGridView.ClearSelection();
                ProductDescriptionComboBox.SelectedIndex = -1;
                ProductNameComboBox.SelectedIndex = -1;
                ProductUnitComboBox.SelectedIndex = -1;
                ProductDescriptionComboBox.Text = string.Empty;
                ProductNameComboBox.Text = string.Empty;
                ProductUnitComboBox.Text = string.Empty;
            }

            private bool IsFormValid()
            {
                if (ProductDescriptionComboBox.Text.Trim() == string.Empty)
                {
                    ProductDescriptionComboBox.SelectedIndex = -1;
                    ProductDescriptionComboBox.Focus();
                    ASMessageBox.ShowErrorMessage("Product Description is required");
                    return false;
                }
                if (ProductNameComboBox.Text.Trim() == string.Empty)
                {
                    ProductNameComboBox.SelectedIndex = -1;
                    ProductNameComboBox.Focus();
                    ASMessageBox.ShowErrorMessage("Product Name is required");
                    return false;
                }
                if (ProductUnitComboBox.Text.Trim() == string.Empty)
                {
                    ProductUnitComboBox.SelectedIndex = -1;
                    ProductUnitComboBox.Focus();
                    ASMessageBox.ShowErrorMessage("Product Unit is required");
                    return false;
                }

                return true;
            }

            private void SaveRecord()
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_ProductsDetailAddNewProduct", Getobject());
            }

            private ProductsDetail Getobject()
            {
                ProductsDetail _products = new ProductsDetail();
                _products.ProductName = ProductNameComboBox.Text;
                _products.ProductDescription = ProductDescriptionComboBox.Text;
                _products.ProductUnit = ProductUnitComboBox.Text;
                _products.CreatedBy = LoggedInUser.UserName;
                return _products;
            }

            private void ProductsDetailDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
            {
                try
                {
                    ProductCodeTextBox.Text = ProductsDetailDataGridView.SelectedRows[0].Cells[1].Value.ToString();
                    ProductNameComboBox.Text = ProductsDetailDataGridView.SelectedRows[0].Cells[2].Value.ToString();
                    ProductDescriptionComboBox.Text = ProductsDetailDataGridView.SelectedRows[0].Cells[3].Value.ToString();
                    ProductUnitComboBox.Text = ProductsDetailDataGridView.SelectedRows[0].Cells[4].Value.ToString();
                    ProductNameTextEffect();
                }
                catch (Exception)
                { }
            }

            private void DeleteButton_Click(object sender, EventArgs e)
            {
                if (RecordExist())
                {
                    string conString = AppSetting.ConnectionString();
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand("Delete From ProductsDetail Where ProductCode = @ProductCode", conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                            ASMessageBox.ShowSucessMessage("Product Deleted Successfully.");
                            GenerateProductCode();
                            ClearExistingData();
                            LoadDataIntoDataGridView();
                        }
                    }
                }
            }

            private void ClearButton_Click(object sender, EventArgs e)
            {
                ClearExistingData();
                GenerateProductCode();
            }

            private void ProductNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                if (ProductNameComboBox.SelectedIndex == -1)
                {
                    LoadDataIntoDataGridView();
                }
                else
                {
                    //ProductNameTextEffect();
                }
            }
            private void ProductNameComboBox_TextChanged(object sender, EventArgs e)
            {
                if (ProductNameComboBox.Text.Trim() == string.Empty)
                {
                    LoadDataIntoDataGridView();
                }
                else
                {
                    //ProductNameTextEffect();
                }
            }
            private void ProductNameTextEffect()
            {
                try
                {
                    string conString = AppSetting.ConnectionString();
                    string Command = @"SELECT ProductCode, ProductName, ProductDescription, ProductUnit FROM ProductsDetail where ProductName like('" + ProductNameComboBox.Text + "%') Order By ProductName, ProductDescription";
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(Command, conn))
                        {
                            int i = 1;
                            conn.Open();
                            SqlDataAdapter DataAdapter = new SqlDataAdapter();
                            DataAdapter.SelectCommand = cmd;
                            DataTable GetData = new DataTable();
                            DataAdapter.Fill(GetData);
                            ProductsDetailDataGridView.Rows.Clear();
                            foreach (DataRow Items in GetData.Rows)
                            {
                                ProductsDetailDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                                int n = ProductsDetailDataGridView.Rows.Add();
                                ProductsDetailDataGridView.Rows[n].Cells[0].Value = i;
                                ProductsDetailDataGridView.Rows[n].Cells[1].Value = Items["ProductCode"].ToString();
                                ProductsDetailDataGridView.Rows[n].Cells[2].Value = Items["ProductName"].ToString();
                                ProductsDetailDataGridView.Rows[n].Cells[3].Value = Items["ProductDescription"].ToString();
                                ProductsDetailDataGridView.Rows[n].Cells[4].Value = Items["ProductUnit"].ToString();
                                i++;
                            }

                        }
                    }
                }
                catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
            }
        }
    }
