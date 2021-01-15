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
using System.Threading;
using ASDBFramework.Screens.UserScreens.Sales.SaleReport;

namespace ASDBFramework.Screens.UserScreens.Sales.SalesDeshBoard
{
    public partial class SalesDeshBoardForm : TemplateForm
    {
        public SalesDeshBoardForm()
        {
            InitializeComponent();
        }
        private Form _Form;
        private void SalesDeshBoardForm_Load(object sender, EventArgs e)
        {
            _Form = new SaleInvoiceForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text= "Welcome To AL-Jabbal Management System ~ Make Invoice";
        }
        private void SalesDeshBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingAction();
        }
        private void makeInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new SaleInvoiceForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.WindowState = FormWindowState.Maximized;
            this.MaximizeBox = true;
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Make Invoice";
        }

        private void salesReturnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new SalesReturnForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Sales Return";
        }

        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            FormClosingAction();
        }

        private void FormClosingAction()
        {
            //UserDeshBoardForm sho = new UserDeshBoardForm();
           // sho.Show();
            this.Hide();
        }

        private void saleReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new SaleReportForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
           // _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Sale Report";
        }

        

       

       
    }
}
