using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Utillities.Lists;
using System.Data.SqlClient;
using ASDBFramework.Windows;
using ASDBFramework.Utillities;

namespace ASDBFramework.Screens.UserScreens.Users.ManageShareholders
{
    public partial class ManageShareholdersForm : TemplateForm
    {
        int SizeOfArry = 0;
        float TotalCapital = 0;
        public ManageShareholdersForm()
        {
            InitializeComponent();
        }

        private void ManageShareholdersForm_Load(object sender, EventArgs e)
        {
            ListAllShareholderData();  
        }

        private void ListAllShareholderData()
        {
            try
            {
                string conString = AppSetting.ConnectionString();
                string Command = @"SELECT        ShareholderId,ShareholderName, CNIC, Mobile, Email, StartingInverstment, CurrentBalance, CapitalRatio,Status, CreatedDate
                                   FROM            ShareholdersDetail WHERE Status = 'Active'";
                using (SqlConnection conn = new SqlConnection(conString))
                {
                    using (SqlCommand cmd = new SqlCommand(Command, conn))
                    {

                        conn.Open();
                        SqlDataAdapter DataAdapter = new SqlDataAdapter();
                        DataAdapter.SelectCommand = cmd;
                        DataTable GetData = new DataTable();
                        DataAdapter.Fill(GetData);
                        ManageShareholderDataGridView.Rows.Clear();
                        foreach (DataRow Items in GetData.Rows)
                        {
                            ManageShareholderDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                            int n = ManageShareholderDataGridView.Rows.Add();
                            ManageShareholderDataGridView.Rows[n].Cells[0].Value = Items["ShareholderId"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[1].Value = Items["ShareholderName"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[2].Value = Items["StartingInverstment"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[3].Value = Items["CurrentBalance"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[4].Value = Items["CapitalRatio"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[5].Value = Items["Mobile"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[6].Value = Items["Email"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[7].Value = Items["CNIC"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[8].Value = Items["Status"].ToString();
                            ManageShareholderDataGridView.Rows[n].Cells[9].Value = Items["CreatedDate"].ToString();

                        }

                    }
                }
            }
            catch (Exception ex) { ASMessageBox.ShowErrorMessage("Error: " + ex.Message); }
        }

        private void ManageShareholderDataGridView_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int rowIndex = ManageShareholderDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
                int ShareholderId = Convert.ToInt32(ManageShareholderDataGridView.Rows[rowIndex].Cells["Id"].Value);
                ShowAddNewShareholderForm(ShareholderId, true);
            }
            catch (Exception)
            { }
        }

        private void ShowAddNewShareholderForm(int _ShareholderId, bool isUpdate)
        {
            AddNewShareholderForm anuf = new AddNewShareholderForm();
            anuf.ShareholderId = _ShareholderId;
            anuf.IsUpdate = isUpdate;
            anuf.ShowDialog();
            ListAllShareholderData();
        }
    }
}
