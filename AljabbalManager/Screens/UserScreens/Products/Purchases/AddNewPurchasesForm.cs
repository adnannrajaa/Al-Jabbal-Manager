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
using ASDBFramework.Models.Purchases;
using ASDBFramework.Models.Users;
using ASDBFramework.Screens.UserScreens.ModelScreens;
using System.Data.SqlClient;

namespace ASDBFramework.Screens.UserScreens
{
    public partial class AddNewPurchasesForm : TemplateForm
    {
        float SubTotal = 0;
        int No = 1;
        string ProductUnit = null;
        string _RetailPrice = null;
        int _ProductCode = 0;
        int ProductCompanyDetailId = 0;
        int shortageLimit = 0;
        DataTable dtProducts = new DataTable();
        public AddNewPurchasesForm()
        {
            InitializeComponent();
            EnabledDisabledControl(false);
        }
        private void AddNewPurchasesForm_Load(object sender, EventArgs e)
        {
            dtProducts.Columns.Add("SNo").ToString();
            dtProducts.Columns.Add("ProductCode").ToString();
            dtProducts.Columns.Add("ProductName").ToString();
            dtProducts.Columns.Add("Unit").ToString();
            dtProducts.Columns.Add("Quantity").ToString();
            dtProducts.Columns.Add("CostPrice").ToString();
            dtProducts.Columns.Add("RetailPrice").ToString();
            dtProducts.Columns.Add("Total").ToString();
        }
        private void AddToStockButton_Click(object sender, EventArgs e)
        {
            if (IsFormValid())
            {
                PurchaseDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                PurchaseDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                AddToPurchaseDataGridView();
                ClearProductInformationTextBoxes();
            }
        }

        private void AddToPurchaseDataGridView()
        {
            float _Total = Convert.ToInt32(CostPriceTextBox.Text) * Convert.ToInt32(QuantityTextBox.Text);
            DataRow ProductAdd = dtProducts.NewRow();
            ProductAdd["SNo"] = No;
            ProductAdd["ProductCode"] = ProductCodeTextBox.Text;
            ProductAdd["ProductName"] = ProductDescriptionTextBox.Text;
            ProductAdd["Unit"] = ProductUnit;
            ProductAdd["Quantity"] = QuantityTextBox.Text;
            ProductAdd["CostPrice"] = CostPriceTextBox.Text;
            ProductAdd["RetailPrice"] = RetailPriceTextBox.Text;
            ProductAdd["Total"] = _Total;
            dtProducts.Rows.Add(ProductAdd);
            PurchaseDataGridView.DataSource = dtProducts;
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
            if (QuantityTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Quantity is required. ");
                QuantityTextBox.Focus();
                return false;
            }
            if (CostPriceTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Cost Price is required. ");
                CostPriceTextBox.Focus();
                return false;
            }
            if (RetailPriceTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Product Retail Price is required. ");
                RetailPriceTextBox.Focus();
                return false;
            }
            return true;
        }
        private void DiscountButton_Click(object sender, EventArgs e)
        {
            if (DiscountTextBox.Text.Trim() == string.Empty)
            {
                DiscountTextBox.Text = "0";
                DiscountTextBox.Focus();
            }
            else
            {
                DiscountLabel.Text = DiscountTextBox.Text;
                NetAmountLabel.Text = Convert.ToString(Convert.ToInt32(NetAmountLabel.Text) - Convert.ToInt32(DiscountLabel.Text));
                DebitLabel.Text = Convert.ToString(Convert.ToInt32(DebitLabel.Text) - Convert.ToInt32(DiscountLabel.Text));
            }
        }

        private void CashPayedButton_Click(object sender, EventArgs e)
        {
            if (AmountPayedTextBox.Text.Trim() == string.Empty)
            {
                AmountPayedTextBox.Text = "0";
                AmountPayedTextBox.Focus();
            }
            else
            {
                if (Convert.ToInt32(AmountPayedTextBox.Text) > Convert.ToInt32(DebitLabel.Text))
                {
                    ASMessageBox.ShowSucessMessage("Amount Detected Rs: " + DebitLabel.Text + "\nPlease Return Rs: " + (Convert.ToInt32(AmountPayedTextBox.Text) - Convert.ToInt32(DebitLabel.Text)));
                    CreditLabel.Text = DebitLabel.Text;
                    DebitLabel.Text = Convert.ToString(Convert.ToInt32(DebitLabel.Text) - Convert.ToInt32(CreditLabel.Text));
                    if (Convert.ToInt32(CreditLabel.Text) == 0)
                    {
                        DebitLabel.Text = NetAmountLabel.Text;
                    }
                }
                else
                {
                    CreditLabel.Text = AmountPayedTextBox.Text;
                    DebitLabel.Text = Convert.ToString(Convert.ToInt32(DebitLabel.Text) - Convert.ToInt32(CreditLabel.Text));
                }
            }
        }
        private void ProductCodeTextBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
           PurchasesProductForm pf = new PurchasesProductForm(this);
           pf.Show();
        }
        public void GetProductCode(string ProductCode, string ProductName ,string _ProductUnit)
        {
            ProductCodeTextBox.Text = ProductCode;
            ProductDescriptionTextBox.Text = ProductName;
            ProductUnit=_ProductUnit;
            QuantityTextBox.Focus();
        }
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearProductInformationTextBoxes();
        }

        private void ClearProductInformationTextBoxes()
        {
            ProductCodeTextBox.Text = string.Empty;
            ProductDescriptionTextBox.Text = string.Empty;
            QuantityTextBox.Text = string.Empty;
            CostPriceTextBox.Text = string.Empty;
            RetailPriceTextBox.Text = string.Empty;
            ProductUnit = string.Empty;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CompanyInformValid())
            {
                if (PaymentFormValid())
                {
                    
                    SaveCompanyRecord();
                    GetLatestCompanyId();
                    SavePurchaseRecord();
                    SavePaymentRecord();
                    SaveButton.Enabled = false;
                    if(PurchaseTypeComboBox.Text == "Debit")
                    {
                        SavePaymentRecordIntoHistory();
                    }
                    ASMessageBox.ShowSucessMessage("Stock added successfully");
                }
            }
           
        }

        private void SavePaymentRecordIntoHistory()
        {
            try
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_PurchaseCompanyPaymentHistoryDetailSavePaymentData", GetObject());
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage(ex.Message);

            }
        }

       

        private bool PaymentFormValid()
        {
            if (PurchaseTypeComboBox.Text == "Debit")
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
        private bool RecordExistInStock(int PCode)
        {
            string conString = AppSetting.ConnectionString();
            string _Command = "Select 1 From ProductStock where ProductCode=@ProductCode ";
            using (SqlConnection conn = new SqlConnection(conString))
            {
                using (SqlCommand cmd = new SqlCommand(_Command, conn))
                {
                    cmd.Parameters.AddWithValue("@ProductCode", PCode);
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
        private void UpdateStock()
        {
            string conString = AppSetting.ConnectionString();
            string _Command = @"Update ProductStock Set
                                                            ProductQuantity = @ProductQuantity ,
                            ProductCostPrice = @ProductCostPrice , 
                            ProductRetailPrice = @ProductRetailPrice ,
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
                    cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                    cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Now).ToString());
                    cmd.Parameters.AddWithValue("@ProductCode", ProductCodeTextBox.Text);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void SavePaymentRecord()
        {
            try
            {
                DbSQLServer db = new DbSQLServer(AppSetting.ConnectionString());
                db.SaveOrUpdateRecord("usp_PurchaseCompanyPaymentDetailSavePaymentData", GetObject());
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage(ex.Message);

            }
        }

        private PurchasesPaymentRecord GetObject()
        {
            PurchasesPaymentRecord _PurchasesPaymentRecord = new PurchasesPaymentRecord();
            _PurchasesPaymentRecord.PurchasesCompanyDetailId=ProductCompanyDetailId;
            _PurchasesPaymentRecord.SubTotal=Convert.ToInt32(SubTotalLabel.Text);
            _PurchasesPaymentRecord.Discount=Convert.ToInt32(DiscountLabel.Text);
            _PurchasesPaymentRecord.NetAmount=Convert.ToInt32(NetAmountLabel.Text);
            _PurchasesPaymentRecord.CashPayed=Convert.ToInt32(CreditLabel.Text);
            _PurchasesPaymentRecord.RemainingBalance=Convert.ToInt32(DebitLabel.Text);
            _PurchasesPaymentRecord.DuePayment=(PurchaseTypeComboBox.Text == "Debit")? Convert.ToInt32(DuePaymentTextBox.Text) : 0;
            _PurchasesPaymentRecord.DuePaymentDate=(PurchaseTypeComboBox.Text == "Debit")? DueDateTimePicker.Value.Date : (DateTime?)null;
            _PurchasesPaymentRecord.CreatedBy=LoggedInUser.UserName;
            _PurchasesPaymentRecord.CreatedDate = Convert.ToDateTime(DateTime.Today);


            return _PurchasesPaymentRecord;
            
        }
        private bool CompanyInformValid()
        {
            if (BillNoTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Invoice No is required. ");
                BillNoTextBox.Focus();
                return false;
            }
            if (CompanyNameTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Party Name is required. ");
                CompanyNameTextBox.Focus();
                return false;
            }
            if (CompanyCellTextBox.Text.Trim() == string.Empty)
            {
                ASMessageBox.ShowErrorMessage("Party Phone No is required. ");
                CompanyCellTextBox.Focus();
                return false;
            }
            if (PurchaseTypeComboBox.SelectedIndex == -1)
            {
                ASMessageBox.ShowErrorMessage("Purchase Type is required. ");
                PurchaseTypeComboBox.Focus();
                return false;
            }
            return true;
        }

        private void GetLatestCompanyId()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"SELECT        TOP (1) PurchasesCompanyDetailId
                        FROM            PurchasesCompanyDetail
                            ORDER BY PurchasesCompanyDetailId DESC";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        conn.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        reader.Read();
                        ProductCompanyDetailId = Convert.ToInt32(reader["PurchasesCompanyDetailId"].ToString());
                    }
                }
            }
            catch (Exception)
            {
                ASMessageBox.ShowErrorMessage("Error:\nSome invalid data enter.");

            }


        }

        private void SavePurchaseRecord()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO PruchasesProductDetail
                                    (PurchasesCompanyDetailId, ProductCode, Description, Unit, Quantity, CostPrice, Total, CreatedBy, CreatedDate)
                      VALUES        (@PurchasesCompanyDetailId, @ProductCode, @Description, @Unit, @Quantity, @CostPrice, @Total, @CreatedBy, @CreatedDate)";

                string _ComandUpdate = @"UPDATE       ProductStock
                                            SET                ProductQuantity =ProductQuantity+@ProductQuantity, ProductCostPrice=@ProductCostPrice, 
                                                               ProductRetailPrice =@ProductRetailPrice,
                                                               CreatedBy =@CreatedBy, CreatedDate =@CreatedDate
                                        where ProductCode=@ProductCode";

                String _CommandInsert = @"INSERT INTO ProductStock
                                         (ProductCode, ProductQuantity, ProductCostPrice, ProductRetailPrice, OutOfStock, CreatedBy, CreatedDate)
                            VALUES       (@ProductCode, @ProductQuantity,@ProductCostPrice, @ProductRetailPrice, @OutOfStock, @CreatedBy, @CreatedDate)";
                foreach (DataRow dr in dtProducts.Rows)
                {
                    using (SqlConnection conn = new SqlConnection(conString))
                    {
                        using (SqlCommand cmd = new SqlCommand(_Command, conn))
                        {
                            cmd.Parameters.AddWithValue("@PurchasesCompanyDetailId", ProductCompanyDetailId);
                            cmd.Parameters.AddWithValue("@ProductCode", dr["ProductCode"].ToString());
                            cmd.Parameters.AddWithValue("@Description", dr["ProductName"].ToString());
                            cmd.Parameters.AddWithValue("@Unit", dr["Unit"].ToString());
                            cmd.Parameters.AddWithValue("@Quantity", dr["Quantity"].ToString());
                            cmd.Parameters.AddWithValue("@CostPrice", dr["CostPrice"].ToString());
                            cmd.Parameters.AddWithValue("@Total", dr["Total"].ToString());
                            cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                            cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Now));
                            conn.Open();
                            cmd.ExecuteNonQuery();
                        }

                    }

                    _RetailPrice = dr["RetailPrice"].ToString();
                    _ProductCode = Convert.ToInt32(dr["ProductCode"].ToString());

                    if (RecordExistInStock(_ProductCode))
                    {
                        using (SqlConnection conn = new SqlConnection(conString))
                        {
                            using (SqlCommand cmd = new SqlCommand(_ComandUpdate, conn))
                            {
                                cmd.Parameters.AddWithValue("@ProductQuantity", dr["Quantity"].ToString());
                                cmd.Parameters.AddWithValue("@ProductCostPrice", dr["CostPrice"].ToString());
                                cmd.Parameters.AddWithValue("@ProductRetailPrice", _RetailPrice);
                                cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                                cmd.Parameters.AddWithValue("@ProductCode", dr["ProductCode"].ToString());
                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    if (!RecordExistInStock(_ProductCode))
                    {
                        using (SqlConnection conn = new SqlConnection(conString))
                        {
                            using (SqlCommand cmd = new SqlCommand(_CommandInsert, conn))
                            {
                                cmd.Parameters.AddWithValue("@ProductQuantity", dr["Quantity"].ToString());
                                cmd.Parameters.AddWithValue("@ProductCostPrice", dr["CostPrice"].ToString());
                                cmd.Parameters.AddWithValue("@ProductRetailPrice", _RetailPrice);
                                cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                                cmd.Parameters.AddWithValue("@CreatedDate", DateTime.Today);
                                cmd.Parameters.AddWithValue("@ProductCode", dr["ProductCode"].ToString());
                                cmd.Parameters.AddWithValue("@OutOfStock", shortageLimit.ToString());
                                conn.Open();
                                cmd.ExecuteNonQuery();
                            }
                        }
                    }
                    

                }
            }
            catch (Exception ex)
            {
                ASMessageBox.ShowErrorMessage("Error: " + ex.Message);

            }

        }

        private void SaveCompanyRecord()
        {
            bool PurchasesType = false;
            if(PurchaseTypeComboBox.Text == "Credit")
            {
                PurchasesType = true;
            }
            if (PurchaseTypeComboBox.Text == "Debit")
            {
                PurchasesType = false;
            }
            try
            {
                string conString = AppSetting.ConnectionString();
                string _Command = @"INSERT INTO PurchasesCompanyDetail
                    (InvoiceNo, CompanyName, CompanyCellNo, PurchaseType, CreatedBy, CreatedDate)
                    VALUES         (@InvoiceNo, @CompanyName, @CompanyCellNo, @PurchaseType, @CreatedBy, @CreatedDate)";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(_Command, conn))
                    {
                        cmd.Parameters.AddWithValue("@InvoiceNo", BillNoTextBox.Text);
                        cmd.Parameters.AddWithValue("@CompanyName", CompanyNameTextBox.Text);
                        cmd.Parameters.AddWithValue("@CompanyCellNo", CompanyCellTextBox.Text);
                        cmd.Parameters.AddWithValue("@PurchaseType", PurchasesType);
                        cmd.Parameters.AddWithValue("@CreatedBy", LoggedInUser.UserName);
                        cmd.Parameters.AddWithValue("@CreatedDate", Convert.ToDateTime(DateTime.Now));
                        conn.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception)
            {
                ASMessageBox.ShowErrorMessage("Error:\nSome invalid data enter.");

            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            int Rows;

            SubTotal = 0;
            try
            {
                Rows = Convert.ToInt32(PurchaseDataGridView.CurrentCell.RowIndex.ToString());
                dtProducts.Rows.RemoveAt(Convert.ToInt32(PurchaseDataGridView.CurrentCell.RowIndex.ToString()));
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

        private void ResetTextButton_Click(object sender, EventArgs e)
        {
            ClearProductInformationTextBoxes();
            ClearCompanyInformationTextBoxes();
            ClearPaymentInformationTextBoxes();
            ClearPaymentInformationLabels();
            No = 1;
        }

        private void ClearPaymentInformationLabels()
        {
            int Clear = 0;
            SaveButton.Enabled = true;
            SubTotalLabel.Text = Clear.ToString();
            NetAmountLabel.Text = Clear.ToString();
            DebitLabel.Text = Clear.ToString();
            DiscountLabel.Text = Clear.ToString();
            CreditLabel.Text = Clear.ToString();
            dtProducts.Rows.Clear();
        }

        private void ClearPaymentInformationTextBoxes()
        {
            DiscountTextBox.Text = string.Empty;
            DuePaymentTextBox.Text = string.Empty;
            AmountPayedTextBox.Text = string.Empty;
            DueDateTimePicker.CustomFormat = " ";
            
        }

        private void ClearCompanyInformationTextBoxes()
        {
            BillNoTextBox.Text = string.Empty;
            CompanyNameTextBox.Text = string.Empty;
            CompanyCellTextBox.Text = string.Empty;
            PurchaseTypeComboBox.SelectedIndex = -1;
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

        private void ProductCodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Back) || (e.KeyCode == Keys.Delete))
            {
                ClearProductInformationTextBoxes();
            }
            else
            {
                if (e.KeyCode == Keys.Enter)
                {
                    GetDataFromProductDetail();
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
                        ProductUnit = reader["ProductUnit"].ToString();
                        QuantityTextBox.Focus();
                    }
                }
            }

            catch (Exception)
            {
                ASMessageBox.ShowErrorMessage("Invalid Product Code. ");
                ClearProductInformationTextBoxes();
            }
        }

        private void PurchaseTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (PurchaseTypeComboBox.Text == "Credit")
            {
                EnabledDisabledControl(false);
                DuePaymentTextBox.Text = string.Empty;
                DueDateTimePicker.CustomFormat = " ";
            }
            if (PurchaseTypeComboBox.Text == "Debit")
            {
                EnabledDisabledControl(true);

            }
        }

        private void EnabledDisabledControl(bool value)
        {
            DuePaymentTextBox.Enabled = value;
            DueDateTimePicker.Enabled = value;
        }






    }
}
