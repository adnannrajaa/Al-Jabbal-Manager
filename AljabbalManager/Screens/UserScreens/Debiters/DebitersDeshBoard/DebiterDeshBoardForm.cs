using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens.Debiters.CustomerDebtors;
using ASDBFramework.Screens.UserScreens.Debiters.CompanyPayable;

namespace ASDBFramework.Screens.UserScreens.Debiters.DebitersDeshBoard
{
    public partial class DebiterDeshBoardForm : TemplateForm
    {
        private Form _Form;
        public DebiterDeshBoardForm()
        {
            InitializeComponent();
        }

        private void DebiterDeshBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingAction();
        }

        private void FormClosingAction()
        {
            //UserDeshBoardForm sho = new UserDeshBoardForm();
            //sho.Show();
            this.Hide();
        }

        private void DebiterDeshBoardForm_Load(object sender, EventArgs e)
        {
            _Form = new CustomerDebtorsForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(960, 503);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }
        private void listAllDebtorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new CustomerDebtorsForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(960, 503);
            this.MaximizeBox = true;
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void showPaymentsDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new CustomerPaymentHistoryForm();
            this.Size = new System.Drawing.Size(960, 503);;
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void payableToPartyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new CompanyPayableForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
       
            this.MaximizeBox = false;
            this.Size = new System.Drawing.Size(960, 503);;
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void partyPaymentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new CompanyPaymentHistoryForm();
           
            this.MaximizeBox = false;
            this.Size = new System.Drawing.Size(960, 503);;
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();

        }

        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            FormClosingAction();
        }

       


    }
}
