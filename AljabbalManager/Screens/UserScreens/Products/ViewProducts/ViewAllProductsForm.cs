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

namespace ASDBFramework.Screens.UserScreens.Products.ViewProducts
{
    public partial class ViewAllProductsForm :TemplateForm
    {
        public ViewAllProductsForm()
        {
            InitializeComponent();
        }

        private void ViewAllProductsForm_Load(object sender, EventArgs e)
        {
            
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        ProductsDetail.ProductCode AS 'PID', ProductsDetail.ProductDescription AS 'Product Description', ProductsDetail.ProductUnit AS 'Unit', ProductStock.ProductQuantity AS 'Quantity', 
                                                             ProductStock.ProductRetailPrice AS 'Price', ProductStock.OutOfStock AS 'Shortage Limit', ProductStock.CreatedDate AS 'Date'
                                    FROM            ProductsDetail INNER JOIN
                          ProductStock ON ProductsDetail.ProductCode = ProductStock.ProductCode
                                    ORDER BY 'Product Description'";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {
                       
                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        AllProductsDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            AllProductsDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            int n = AllProductsDataGridView.Rows.Add();
                            AllProductsDataGridView.Rows[n].Cells[0].Value = Items["PID"].ToString();
                            AllProductsDataGridView.Rows[n].Cells[1].Value = Items["Product Description"].ToString();
                            AllProductsDataGridView.Rows[n].Cells[2].Value = Items["Unit"].ToString();
                            AllProductsDataGridView.Rows[n].Cells[3].Value = Items["Quantity"].ToString();
                            AllProductsDataGridView.Rows[n].Cells[4].Value = Items["Price"].ToString();
                            AllProductsDataGridView.Rows[n].Cells[5].Value = Items["Shortage Limit"].ToString();
                            AllProductsDataGridView.Rows[n].Cells[6].Value = Items["Date"].ToString();

                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }


    }
}
