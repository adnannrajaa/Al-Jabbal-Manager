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
using ASDBFramework.Windows;
using ASDBFramework.Screens.UserScreens.ModelScreens;
using System.Data.SqlClient;
using ASDBFramework.Models.Users;
using ASDBFramework.Utillities.Lists;
using ASDBFramework.Models.Sales;
using ASDBFramework.Screens.UserScreens.Sales.SaleInvoice;

namespace ASDBFramework.Screens.UserScreens
{
    public partial class SaleInvoiceForm : TemplateForm
    {
        float SubTotal = 0;
        int No = 1;
        int _SaleCustomerDetailId = 0;
        float _TotalQuantity=0;
        DataTable dtProducts = new DataTable();
        public SaleInvoiceForm()
        {
            InitializeComponent();
            EnabledDisabledControl(false);
        }
        private void GenerateBillForm_Load(object sender, EventArgs e)
        {
            dtProducts.Columns.Add("SNo").ToString();
            dtProducts.Columns.Add("ProductCode").ToString();
            dtProducts.Columns.Add("ProductName").ToString();
            dtProducts.Columns.Add("Unit").ToString();
            dtProducts.Columns.Add("Quantity").ToString();
            dtProducts.Columns.Add("RetailPrice").ToString();
            dtProducts.Columns.Add("Total").ToString();
            CustomerNameTextBox.Focus();
            GenerateInvoiceNo();
            ListTodaySales();
        }
        private void SaleTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SaleTypeComboBox.Text == "Credit")
            {
                EnabledDisabledControl(false);
                DuePaymentTextBox.Text = string.Empty;
                DueDateTimePicker.CustomFormat = " ";
            }
            if (SaleTypeComboBox.Text == "Debit")
            {
                EnabledDisabledControl(true);
                
            }
        }

        private void EnabledDisabledControl(bool value)
        {
            DuePaymentTextBox.Enabled =value;
            DueDateTimePicker.Enabled = value;
        }

        private void ListTodaySales()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        InvoiceNo AS 'Bill No', NetAmount AS 'Total', CashRecived AS 'Credit', RemainingBalance AS 'Debit'
                                            FROM            SalesCustomerPaymentDetail
                                            WHERE        (CreatedDate = @TodayDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@TodayDate", Convert.ToDateTime(DateTime.Today));
                        conn.Open();
                        SqlDataAdapter da = new SqlDataAdapter();
                        da.SelectCommand = cmd;
                        DataTable mydt = new DataTable();
                        da.Fill(mydt);
                        TodaySaleDataGridView.DataSource = mydt;
                        TodaySaleDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    }
                }

                ListTotalTodaySale();
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void ListTotalTodaySale()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        SUM(NetAmount) AS 'Total', SUM(CashRecived) AS 'Credit', SUM(RemainingBalance) AS 'Debit'
                                            FROM            SalesCustomerPaymentDetail
                                            WHERE        (CreatedDate = @TodayDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@TodayDate", Convert.ToDateTime(DateTime.Today));
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        TotalSaleLlabel.Text = reader["Total"].ToString();
                        TotalCreditSaleLabel.Text = reader["Credit"].ToString();
                        TotalDebitSaleLabel.Text = reader["Debit"].ToString();
                    }
                }


            }

            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error : " + ex);
                

            }
        }
        private void GenerateInvoiceNo()
        {
            DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
            InvoiceNoTextBox.Text = db.GetScalarValue("usp_SalesCustomerProductsDetailGenerateNewInvoiceNo").ToString();
            InvoiceNoTextBox.Enabled = false;  
        }

        private void ResetTextButton_Click(object sender, EventArgs e)
        {
            ClearCustomerInformation();
            ClearProductInformation();
            ClearPaymentInformation();
            ClearPaymentInformationLabels();
            GenerateInvoiceNo();
            SaveButton.Enabled = true;
        }

        private void ClearPaymentInformationLabels()
        {
            int _Clear = 0;
            SubTotal = 0;
            No = 1;
            SubTotalLabel.Text = _Clear.ToString();
            LoadingLabel.Text = _Clear.ToString();
            NetAmountLabel.Text = _Clear.ToString();
            DebitLabel.Text = _Clear.ToString();
            DiscountLabel.Text = _Clear.ToString();
            CreditLabel.Text = _Clear.ToString();
            dtProducts.Rows.Clear();
        }

        private void ClearPaymentInformation()
        {
            DiscountTextBox.Text = string.Empty;
            LoadingTextBox.Text = string.Empty;
            CashRecivedTextBox.Text = string.Empty;
            DuePaymentTextBox.Text = string.Empty;
            DueDateTimePicker.CustomFormat = " ";
        }

        private void ClearProductInformation()
        {
            ProductCodeTextBox.Text = string.Empty;
            ProductDescriptionTextBox.Text = string.Empty;
            UnitTextBox.Text = string.Empty;
            QuantityTextBox.Text = string.Empty;
            RetailPriceTextBox.Text = string.Empty;
            TotalTextBox.Text = string.Empty;
        }

        private void ClearCustomerInformation()
        {
            CustomerCellTextBox.Text = string.Empty;
            CustomerNameTextBox.Text = string.Empty;
            SaleTypeComboBox.SelectedIndex = -1;
        }

        private void DueDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DueDateTimePicker.CustomFormat = "dd-MM-yyyy";
        }

        private void DueDateTimePicker_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                DueDateTimePicker.CustomFormat = " ";
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerInformValid())
            {
                if (PaymentInformValid())
                {

                    SaveCustomerRecord();
                    GetLatestCustomerId();
                    SaveSaleRecord();
                    SavePaymentRecord();
                    if (SaleTypeComboBox.Text == "Debit")
                    {SaveToPaymentRecordHistory();}
                    ListTodaySales();
                    SaveButton.Enabled = false;
                    CalledToPrint();
                    //ASMessageBox.ShowSucessMessage("Stock added successfully");
                   
                }
            }
        }

        private void SaveToPaymentRecordHistory()
        {
            try
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_SalesCustomerPaymentHistoryDetailSavePaymentData", GetObject());
            }
            catch (Exception)
            {
                ASMessageBox.ShowErrorMessage("Error:\nSome invalid data enter.");

            }
        }

        private void CalledToPrint()
        {
            MakeInvoiceForm mi = new MakeInvoiceForm();
            mi.GetSaleToCustomerProductsDetailId(_SaleCustomerDetailId);
            mi.Show();
        }

        private bool PaymentInformValid()
        {
            if (SaleTypeComboBox.Text == "Debit")
            {
                if (DuePaymentTextBox.Text.Trim() == string.Empty)
                {
                    DuePaymentTextBox.Focus();
                    ASMessageBox.ShowErrorMessage("Due payment amount is required  OR\nPlease Make this invoice as credit.");
                    return false;
                }
                if (DueDateTimePicker.Text.Trim() == string.Empty)
                {
                    DueDateTimePicker.Focus();
                    ASMessageBox.ShowErrorMessage("Due payment date is required  OR\nPlease Make this invoice as credit.");
                    return false;
                }
            }
            return true;
        }

        private void SavePaymentRecord()
        {
            try
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_SalesCustomerPaymentDetailSavePaymentData", GetObject());
            }
            catch (Exception)
            {
                ASMessageBox.ShowErrorMessage("Error:\nSome invalid data enter.");

            }
        }

        private SalesPaymentRecord GetObject()
        {
            SalesPaymentRecord _SalesPayment = new SalesPaymentRecord();
            _SalesPayment.SalesCustomerDetailId = _SaleCustomerDetailId;
            _SalesPayment.InvoiceNo = Convert.ToInt32(InvoiceNoTextBox.Text);
            _SalesPayment.SubTotal = Convert.ToInt32(SubTotalLabel.Text);
            _SalesPayment.Discount = Convert.ToInt32(DiscountLabel.Text);
            _SalesPayment.Loading = Convert.ToInt32(LoadingLabel.Text);
            _SalesPayment.NetAmount = Convert.ToInt32(NetAmountLabel.Text);
            _SalesPayment.CashRecived = Convert.ToInt32(CreditLabel.Text);
            _SalesPayment.RemainingBalance = Convert.ToInt32(DebitLabel.Text);
            _SalesPayment.DuePayment = (SaleTypeComboBox.Text == "Debit")? Convert.ToInt32(DuePaymentTextBox.Text) : 0;
            _SalesPayment.DuePaymentDate = (SaleTypeComboBox.Text == "Debit")? DueDateTimePicker.Value.Date : (DateTime?)null;
            _SalesPayment.CreatedBy =LoggedInUser.UserName;
            _SalesPayment.CreatedDate = Convert.ToDateTime(DateTime.Today);
            return _SalesPayment;
        }

        private void SaveSaleRecord()
        {
            try
            {
                float quantity = 0;
                int _ProductCode = 0;
                string conString = AppSetting.ConnectionString();
                string _CommandInsert = @"INSERT INTO SalesCustomerProductsDetail
                         (SalesCustomerDetailId, ProductCode, ProductDescription, ProductUnit, ProductQuantity, RetailPrice, Total, CreatedBy, CreatedDate)
            VALUES        (@SalesCustomerDetailId, @ProductCode, @ProductDescription, @ProductUnit, @ProductQunatity, @RetailPrice, @Total, @CreatedBy, @CreatedDate)";

                string _ComandUpdate = @"UPDATE       ProductStock
                                        SET                ProductQuantity =ProductQuantity-@ProductQuantity 
                                        where ProductCode =@ProductCode";
                foreach (DataRow dr in dtProducts.Rows)
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(_CommandInsert, conn))
                        {
                            cmd.Parameters.AddWithValue("@SalesCustomerDetailId", _SaleCustomerDetailId);
                            cmd.Parameters.AddWithValue("@ProductCode", dr["ProductCode"].ToString());
                            cmd.Parameters.AddWithValue("@ProductDescription", dr["ProductName"].ToString());
                            cmd.Parameters.AddWithValue("@ProductUnit", dr["Unit"].ToString());
                            cmd.Parameters.AddWithValue("@ProductQunatity", dr["Quantity"].ToString());
                            cmd.Parameters.AddWithValue("@RetailPrice", dr["RetailPrice"].ToString());
                            cmd.Parameters.AddWithValue("@Total", dr["Total"].ToString());
                            cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                            cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                    }

                    quantity = Convert.ToInt32(dr["Quantity"].ToString());
                    _ProductCode = Convert.ToInt32(dr["ProductCode"].ToString());

                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(_ComandUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@ProductQuantity", quantity);
                            cmd.Parameters.AddWithValue("@ProductCode", _ProductCode);
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                    }

                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void GetLatestCustomerId()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        TOP (1) SalesCustomerDetailId
                        FROM            SalesCustomerDetail
                            ORDER BY SalesCustomerDetailId DESC";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        _SaleCustomerDetailId = Convert.ToInt32(reader["SalesCustomerDetailId"].ToString());
                    }
                }
               
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }
        }

        private void SaveCustomerRecord()
        {
            bool SaleType = false;
            if (SaleTypeComboBox.Text == "Credit")
            {
                SaleType = true;
            }
            if (SaleTypeComboBox.Text == "Debit")
            {
                SaleType = false;
            }
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO SalesCustomerDetail
                         (InvoiceNo, CustomerName, CustomerCellNo, SaleType, CreatedBy, CreatedDate)
                         VALUES        (@InvoiceNo, @CustomerName, @CustomerCellNo, @SaleType, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNo", InvoiceNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@CustomerName", CustomerNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@CustomerCellNo", CustomerCellTextBox.Text);
                        cmd.Parameters.AddWithValue("@SaleType", SaleType);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Today));
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

        private bool CustomerInformValid()
        {
            if (CustomerNameTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Customer Name is required. ");
                CustomerNameTextBox.Focus();
                return false;
            }
            if (Convert.ToInt32(SubTotalLabel.Text) == 0)
            {
                ASMessageBox.ShowErrorMessage("No Record Found.");
                return false;
            }
            if (SaleTypeComboBox.SelectedIndex == -1)
            {
                ASMessageBox.ShowErrorMessage("Sale Type is required. ");
                SaleTypeComboBox.Focus();
                return false;
            }
            return true;
        }

        private void AddToCartButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                SaleInvoiceDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                SaleInvoiceDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                AddToPurchaseDataGridView();
                ClearProductInformation();
            }
        }
        private void AddToPurchaseDataGridView()
        {
            float _Total = Convert.ToInt32(RetailPriceTextBox.Text) * Convert.ToInt32(QuantityTextBox.Text);
            DataRow ProductAdd = dtProducts.NewRow();
            ProductAdd["SNo"] = No;
            ProductAdd["ProductCode"] = ProductCodeTextBox.Text;
            ProductAdd["ProductName"] = ProductDescriptionTextBox.Text;
            ProductAdd["Unit"] =UnitTextBox.Text;
            ProductAdd["Quantity"] = QuantityTextBox.Text;
            ProductAdd["RetailPrice"] = RetailPriceTextBox.Text;
            ProductAdd["Total"] = _Total;
            dtProducts.Rows.Add(ProductAdd);
            SaleInvoiceDataGridView.DataSource = dtProducts;
            No = No + 1;
            SubTotal += _Total;

            SubTotalLabel.Text = SubTotal.ToString();
            NetAmountLabel.Text = SubTotal.ToString();
            DebitLabel.Text = SubTotal.ToString();
        }
        private bool IsFormValid()
        {
            if (ProductCodeTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Code is required. ");
                ProductCodeTextBox.Focus();
                return false;
            }
            if (ProductDescriptionTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Name is required. ");
                ProductDescriptionTextBox.Focus();
                return false;
            }
            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Quantity is required. ");
                QuantityTextBox.Focus();
                return false;
            }
            if (RetailPriceTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Retail Price is required. ");
                RetailPriceTextBox.Focus();
                return false;
            }
            if (TotalTextBox.Text.Trim() == string.Empty)
            {
                TotalTextBox.Focus();
                return false;
            }
            return true;
        }
        private void CashRecivedButton_Click(object sender, EventArgs e)
        {
            if (CashRecivedTextBox.Text.Trim() == string.Empty)
            {
                CashRecivedTextBox.Text = "0";
                CashRecivedTextBox.Focus();
            }
            else
            {
                if (Convert.ToInt32(CashRecivedTextBox.Text) > Convert.ToInt32(DebitLabel.Text))
                {
                    ASMessageBox.ShowSucessMessage("Amount Detected Rs: " + DebitLabel.Text + "\nPlease Return Rs: " + (Convert.ToInt32(CashRecivedTextBox.Text) - Convert.ToInt32(DebitLabel.Text)));
                    CreditLabel.Text = DebitLabel.Text;
                    DebitLabel.Text = Convert.ToString(Convert.ToInt32(DebitLabel.Text) - Convert.ToInt32(CreditLabel.Text));
                    if (Convert.ToInt32(CreditLabel.Text) == 0)
                    {
                        DebitLabel.Text = NetAmountLabel.Text;
                    }
                }
                else
                {
                    CreditLabel.Text = CashRecivedTextBox.Text;
                    DebitLabel.Text = Convert.ToString(Convert.ToInt32(DebitLabel.Text) - Convert.ToInt32(CreditLabel.Text));
                }
            }
        }
        private void DiscountButton_Click(object sender, EventArgs e)
        {
            float Loading = 0, Discount = 0, NetAmount = 0;
            if (DiscountTextBox.Text.Trim() == string.Empty)
            {
                DiscountTextBox.Text = "0";
                DiscountTextBox.Focus();  
            }
            if (LoadingTextBox.Text.Trim() == string.Empty)
            {
                LoadingTextBox.Text = "0";
                LoadingTextBox.Focus();
            }
            else
            {
            Discount = Convert.ToInt32(DiscountTextBox.Text);
            Loading = Convert.ToInt32(LoadingTextBox.Text);
            NetAmount = Convert.ToInt32(NetAmountLabel.Text);

            DiscountLabel.Text = DiscountTextBox.Text;
            LoadingLabel.Text = LoadingTextBox.Text;

            NetAmountLabel.Text = Convert.ToString((NetAmount + Loading) - Discount);

            DebitLabel.Text = Convert.ToString((Convert.ToInt32(DebitLabel.Text) + Loading) - Discount);
            }
        }
        private void ProductCodeTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            SalesProductForm pf = new SalesProductForm(this);
            pf.Show();
        }
        public void GetProductDetail(string ProductCode, string ProductName, string ProductUnit)
        {
            ClearProductInformation();
            ProductCodeTextBox.Text = ProductCode;
            ProductDescriptionTextBox.Text = ProductName;
            UnitTextBox.Text = ProductUnit;
            QuantityTextBox.Focus();
        }
        public void GetProductStock(string ProductRetailPrice, string ProductQuantity)
        {
            RetailPriceTextBox.Text = ProductRetailPrice;
            _TotalQuantity = Convert.ToInt32(ProductQuantity);
        }
        private void QuantityTextBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //if (QuantityTextBox.Text.Trim() != string.Empty)
                //{
                  if (_TotalQuantity < Convert.ToInt32(QuantityTextBox.Text))
                    {
                        ASMessageBox.ShowErrorMessage("You have only " + _TotalQuantity + " " + UnitTextBox.Text + " aviliable");
                        QuantityTextBox.Text = string.Empty;
                        TotalTextBox.Text = string.Empty;
                    }
                    else
                    {
                        TotalTextBox.Text = (Convert.ToDecimal(QuantityTextBox.Text) * Convert.ToDecimal(RetailPriceTextBox.Text)).ToString();
                    }
                //}
                //else
                //{
                //    TotalTextBox.Text = string.Empty;
                //}
            }
            catch (Exception ex)
            {
               // ASMessageBox.ShowErrorMessage("Quantity only contain number not character value.\n"+ex.Message);
            }
        }
        private void ProductCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                ClearProductInformation();
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {

                    GetDataFromProductDetail();
                    GetDataFromProductStock();

                }
            }
        }
        private void GetDataFromProductDetail()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"Select ProductDescription,ProductUnit From ProductsDetail where ProductCode=@ProductCode";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        ProductDescriptionTextBox.Text = reader["ProductDescription"].ToString();
                        UnitTextBox.Text = reader["ProductUnit"].ToString();
                    }
                }


            }

            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage(ex.Message);
                ClearProductInformation();
            }
        }
        private void GetDataFromProductStock()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        ProductQuantity, ProductRetailPrice
                                   FROM            ProductStock
                                   WHERE        (ProductCode = @ProductCode)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        RetailPriceTextBox.Text = reader["ProductRetailPrice"].ToString();
                        _TotalQuantity = Convert.ToInt32(reader["ProductQuantity"].ToString());
                    }
                }

            }

            catch (Exception)
            {
                //ASMessageBox.ShowErrorMessage("Invalid Product Code. ");
                ClearProductInformation();

            }
        }
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int Rows;
            
            SubTotal = 0;
            try
            {
                Rows = Convert.ToInt32(SaleInvoiceDataGridView.CurrentCell.RowIndex.ToString());
                dtProducts.Rows.RemoveAt(Convert.ToInt32(SaleInvoiceDataGridView.CurrentCell.RowIndex.ToString()));
                if (Rows == 0)
                {
                    No = 1;
                }
                if (Rows > 0)
                {
                    foreach (DataRow dataRow in dtProducts.Rows)
                    {

                        SubTotal += Convert.ToInt32(dataRow["Total"].ToString());
                        SubTotalLabel.Text = SubTotal.ToString();
                        NetAmountLabel.Text = SubTotal.ToString();
                        DebitLabel.Text = SubTotal.ToString();
                        

                    }
                    No = No - 1;
                }
            }
            catch (Exception)
            {
                SubTotal = 0;
                SubTotalLabel.Text = SubTotal.ToString();
                NetAmountLabel.Text = SubTotal.ToString();
                DebitLabel.Text = SubTotal.ToString();
                ASMessageBox.ShowErrorMessage("No More Row to delete");

            }
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearProductInformation();
        }

        private void ProductDescriptionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                ClearProductInformation();
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    try
                    {

                        string conString = AppSetting.ConnectionString();
                        string _Command = @"SELECT        PD.ProductCode, PD.ProductDescription, PD.ProductUnit, PS.ProductQuantity, PS.ProductRetailPrice
                                            FROM            ProductsDetail AS PD INNER JOIN
                                                                     ProductStock AS PS ON PD.ProductCode = PS.ProductCode
                                            WHERE        (PD.ProductDescription = @ProductDescription)";
                        using (SqlConnection conn = new SqlConnection(conString))
                        {
                            using (SqlCommand cmd = new SqlCommand(_Command, conn))
                            {
                                cmd.Parameters.AddWithValue("@ProductDescription", ProductDescriptionTextBox.Text);
                                conn.Open();
                                SqlDataReader reader = cmd.ExecuteReader();
                                reader.Read();
                                _TotalQuantity = Convert.ToInt32(reader["ProductQuantity"].ToString());
                                ProductCodeTextBox.Text = reader["ProductCode"].ToString();
                                ProductDescriptionTextBox.Text = reader["ProductDescription"].ToString();
                                UnitTextBox.Text = reader["ProductUnit"].ToString();
                                RetailPriceTextBox.Text = reader["ProductRetailPrice"].ToString();

                            }
                        }

                    }

                    catch (Exception)
                    {
                        //ASMessageBox.ShowErrorMessage("Invalid Product Code. ");
                    }
                }
            }

        }  
    }
}
