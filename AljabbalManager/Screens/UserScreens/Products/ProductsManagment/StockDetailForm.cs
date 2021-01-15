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
using ASDBFramework.Models.Products;
using ASDBFramework.Models.Users;
using ASDBFramework.Windows;
using ASDBFramework.Screens.UserScreens.ModelScreens;

namespace ASDBFramework.Screens.UserScreens.Products
{
    public partial class StockDetailForm : TemplateForm
    {
                int _ProductCode = 0;
                float _ProductQuantity = 0;
                float _ProductCostPrice = 0;
        public StockDetailForm()
        {
            InitializeComponent();
            OpeningInventoryButton.Visible = false;
        }

        private void StockDetailForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            if (IsOpeningInventoryEmpty())
            {
                OpeningInventoryButton.Visible = true;
            }
        }

        private bool IsOpeningInventoryEmpty()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = "Select * from ProductsOpeningInventory";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    conn.Open();
                    SqlDataReader reader = cmd.ExecuteReader();
                    reader.Read();
                    if (reader.HasRows)
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        ProductsDetail.ProductCode, ProductsDetail.ProductDescription AS 'ProductName', ProductStock.ProductQuantity, ProductStock.ProductCostPrice, ProductStock.ProductRetailPrice, ProductStock.OutOfStock, 
                                                             ProductStock.CreatedDate AS 'Date'
                                    FROM            ProductsDetail INNER JOIN
                                                             ProductStock ON ProductsDetail.ProductCode = ProductStock.ProductCode
                                    ORDER BY 'ProductName'";
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
                        StockDetailDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            StockDetailDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            int n = StockDetailDataGridView.Rows.Add();
                            StockDetailDataGridView.Rows[n].Cells[0].Value = i;
                            StockDetailDataGridView.Rows[n].Cells[1].Value = Items["ProductCode"].ToString();
                            StockDetailDataGridView.Rows[n].Cells[2].Value = Items["ProductName"].ToString();
                            StockDetailDataGridView.Rows[n].Cells[3].Value = Items["ProductQuantity"].ToString();
                            StockDetailDataGridView.Rows[n].Cells[4].Value = Items["ProductCostPrice"].ToString();
                            StockDetailDataGridView.Rows[n].Cells[5].Value = Items["ProductRetailPrice"].ToString();
                            StockDetailDataGridView.Rows[n].Cells[6].Value = Items["OutOfStock"].ToString();
                            StockDetailDataGridView.Rows[n].Cells[7].Value = Items["Date"].ToString();
                            i++;
                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                if (!CheckProductExist())
                {
                    if (!RecordExistInProdustDetail())
                    {
                        ASMessageBox.ShowErrorMessage("Invalid Product Code.");
                    }
                    else
                    {
                        AddProductsIntoStock();
                        ASMessageBox.ShowSucessMessage("Product Added successfully.");
                        ClearTextBoxesData();
                        LoadDataIntoDataGridView();

                    }
                }
                ProductCodeTextBox.Enabled = true;
            }

        }

        private bool CheckProductExist()
        {
            if (RecordExist())
            {
                UpdateProductRecord();
                LoadDataIntoDataGridView();
                ClearTextBoxesData();
                ASMessageBox.ShowSucessMessage("Product Updated Successfully.");
                return true;
            }
            return false;
        }

        private void UpdateProductRecord()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"Update ProductStock Set
                                                            ProductQuantity = @ProductQuantity ,
                            ProductCostPrice = @ProductCostPrice , 
                            ProductRetailPrice = @ProductRetailPrice ,
                            OutOfStock=@OutOfStock,
                            CreatedBy=@CreatedBy,
                            CreatedDate=@CreatedDate
                                                 where ProductCode=@ProductCode ";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductQuantity", QuantityTextBox.Text);
                    cmd.Parameters.AddWithValue("@ProductCostPrice", CostPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@ProductRetailPrice", RetailPriceTextBox.Text);
                    cmd.Parameters.AddWithValue("@OutOfStock", OutOfStockTextBox.Text);
                    cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                    cmd.Parameters.AddWithValue("@CreatedDate",Convert.ToDateTime( DateTime.Today).ToString());
                    cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private bool RecordExist()
        {
            if (RecordExistInProdustDetail())
            {
                if (RecordExistInStock())
                {
                    return true;
                }
            }
            return false;
        }

        private bool RecordExistInStock()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = "Select 1 From ProductStock where ProductCode=@ProductCode ";
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

        private bool RecordExistInProdustDetail()
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

        private void ClearTextBoxesData()
        {
            ProductCodeTextBox.Enabled = true;
            ProductCodeTextBox.Text = string.Empty;
            QuantityTextBox.Text = string.Empty;
            CostPriceTextBox.Text = string.Empty;
            RetailPriceTextBox.Text = string.Empty;
            OutOfStockTextBox.Text = string.Empty; 
        }

        private void AddProductsIntoStock()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            db.SaveOrUpdateRecord("usp_ProductsStockAddNewStock", Getobject());
        }

        private ProductStock Getobject()
        {
            ProductStock ps = new ProductStock();
            ps.ProductCode = Convert.ToInt32(ProductCodeTextBox.Text);
            ps.ProductQuantity = Convert.ToInt32(QuantityTextBox.Text);
            ps.ProductCostPrice = Convert.ToInt32(CostPriceTextBox.Text);
            ps.ProductRetailPrice = Convert.ToInt32(RetailPriceTextBox.Text);
            ps.OutOfStock = Convert.ToInt32(OutOfStockTextBox.Text);
            ps.CreatedBy = LoggedInUser.UserName;
            return ps;
        }

        private bool IsFormValid()
        {
            if (ProductCodeTextBox.Text.Trim() == string.Empty)
            {
                ProductCodeTextBox.Clear();
                ProductCodeTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Product Code is required");
                return false;

            }
            if (QuantityTextBox.Text == string.Empty)
            {
                QuantityTextBox.Clear();
                QuantityTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Product Quantity is required");
                return false;
            }

            if (CostPriceTextBox.Text.Trim() == string.Empty)
            {
                CostPriceTextBox.Clear();
                CostPriceTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Cost Price is required");
                return false;

            }
            if (RetailPriceTextBox.Text == string.Empty)
            {
                RetailPriceTextBox.Clear();
                RetailPriceTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Product Retail Price is required");
                return false;
            }
            if (OutOfStockTextBox.Text == string.Empty)
            {
                OutOfStockTextBox.Clear();
                OutOfStockTextBox.Focus();
                ASMessageBox.ShowErrorMessage("Out of stock or minimum qunatity is required");
                return false;
            }
            return true;
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearTextBoxesData();
        }

        private void StockDetailDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ProductCodeTextBox.Enabled = false;
            ProductCodeTextBox.Text = StockDetailDataGridView.SelectedRows[0].Cells[1].Value.ToString();
            QuantityTextBox.Text = StockDetailDataGridView.SelectedRows[0].Cells[3].Value.ToString();
            CostPriceTextBox.Text = StockDetailDataGridView.SelectedRows[0].Cells[4].Value.ToString();
            RetailPriceTextBox.Text = StockDetailDataGridView.SelectedRows[0].Cells[5].Value.ToString();
            OutOfStockTextBox.Text = StockDetailDataGridView.SelectedRows[0].Cells[6].Value.ToString();
           
        }

        private void ProductCodeTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SelectProductForm pf = new SelectProductForm(this);
            pf.Show();
        }

        public void GetProductCode(string ProductCode)
        {
            ProductCodeTextBox.Text = ProductCode;
        }

        private void OpeningInventoryButton_Click(object sender, EventArgs e)
        {
            DialogResult _Dialog;
            _Dialog = MessageBox.Show("Notice:\nThis button can be used only one time you can save all data in fornt of you as your opening inventory after saving this, data can not be changed or modified.\n\nDo you realy want to make this data as opening inventory??", "Information", MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning);
            if (_Dialog == DialogResult.Yes)
            {
                if (SaveToOpeningInventory())
                {
                    LoadDataIntoDataGridView();
                    ASMessageBox.ShowSucessMessage("Record added to openning inventoery successfully.");
                    OpeningInventoryButton.Visible = false;
                    
                }
            }
            if (_Dialog == DialogResult.No)
            {
               
            }
            
        }

        private bool SaveToOpeningInventory()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _CommandSelectFormStock = @"SELECT        ProductCode, ProductQuantity, ProductCostPrice
                                                   FROM            ProductStock";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_CommandSelectFormStock, conn))
                    {
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        foreach (DataRow Items in GetData.Rows)
                        {
                            _ProductCode = Convert.ToInt32(Items["ProductCode"].ToString());
                            _ProductQuantity = Convert.ToInt32(Items["ProductQuantity"].ToString());
                            _ProductCostPrice = Convert.ToInt32(Items["ProductCostPrice"].ToString());
                            InsertToOpeningInventory();
                        }

                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);
                return false;

            }
        }

        private void InsertToOpeningInventory()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _ComandInsertToOpeningInventory = @"INSERT INTO ProductsOpeningInventory
                                                 (ProductCode, ProductQuantity, ProductCostPrice, CreatedBy, CreatedDate)
                                    VALUES        (@ProductCode, @ProductQuantity, @ProductCostPrice, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_ComandInsertToOpeningInventory, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", _ProductCode);
                        cmd.Parameters.AddWithValue("@ProductQuantity", _ProductQuantity);
                        cmd.Parameters.AddWithValue("@ProductCostPrice", _ProductCostPrice);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
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
    }
}
