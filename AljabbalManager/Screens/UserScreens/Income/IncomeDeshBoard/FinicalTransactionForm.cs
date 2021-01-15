using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens.Income.ShareholderEquity;

namespace ASDBFramework.Screens.UserScreens.Income.IncomeDeshBoard
{
    public partial class FinicalTransactionForm : TemplateForm
    {
        private Form _Form;
        public FinicalTransactionForm()
        {
            InitializeComponent();
        }
        private void FinicalTransactionForm_Load(object sender, EventArgs e)
        {
            _Form = new IncomeStatmentForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }
        private void BackToolStripButton_Click(object sender, EventArgs e)
        {
            FormClosingAction();
        }
        private void FormClosingAction()
        {
            //UserDeshBoardForm sho = new UserDeshBoardForm();
            //sho.Show();
            this.Hide();
        }

        private void FinicalTransactionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingAction();
        }

        private void IncomeStatmentToolStripButton_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new IncomeStatmentForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Income Statment";
        }

        private void BalanceSheetToolStripButton_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new BalanceSheetForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Balance Sheet";
        }

        private void EndingBalanceToolStripButton_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new CapitalStock();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Capital Stock";
        }

      
    }
}
