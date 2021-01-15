using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;

namespace ASDBFramework.Screens.UserScreens.Expenses.ExpensesDeshBoard
{
    public partial class ExpensesDeshBoardForm : TemplateForm
    {
        private Form _Form;
        public ExpensesDeshBoardForm()
        {
            InitializeComponent();
        }

       
        private void ExpensesDeshBoardForm_Load(object sender, EventArgs e)
        {
            this.ExpensesDeshBoradTreeView.Nodes[0].ExpandAll();

            _Form = new DailyExpensesForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(977, 538);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void ExpensesDeshBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingAction();
        }
        private void FormClosingAction()
        {
            //UserDeshBoardForm sho = new UserDeshBoardForm();
            //sho.Show();
            this.Hide();
        }
        private void ExpansesDeshBoradTreeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            ManageExpenses();
            OtherExpenses();
        }

        private void OtherExpenses()
        {
           TreeNode node = ExpensesDeshBoradTreeView.SelectedNode;
           switch (node.Text)
           {
               case "Freight in":
                   _Form.Dispose();
                   _Form = new FreightInForm();
                   _Form.TopLevel = false;
                   this.MainPanel.Controls.Add(_Form);
                   this.Size = new System.Drawing.Size(814, 480);
                   _Form.Dock = DockStyle.Fill;
                   _Form.Show();

                   break;
               case "Wages":
                   _Form.Dispose();
                   _Form = new WagesForm();
                   _Form.TopLevel = false;
                   this.MainPanel.Controls.Add(_Form);
                   this.Size = new System.Drawing.Size(814, 482);
                   _Form.Dock = DockStyle.Fill;
                   _Form.Show();
                   break;
           }
        }

        private void ManageExpenses()
        {
            TreeNode node = ExpensesDeshBoradTreeView.SelectedNode;
            switch (node.Text)
            {
                case "Daily Expenses":
                    _Form.Dispose();
                    _Form = new DailyExpensesForm();
                    _Form.TopLevel = false;
                    this.MainPanel.Controls.Add(_Form);
                    this.Size = new System.Drawing.Size(977, 538);
                    _Form.Dock = DockStyle.Fill;
                    _Form.Show();

                    break;
                case "Monthly Expenses":
                    _Form.Dispose();
                    _Form = new MonthlyExpensesForm();
                    _Form.TopLevel = false;
                    this.MainPanel.Controls.Add(_Form);
                    this.Size = new System.Drawing.Size(977, 538);
                    _Form.Dock = DockStyle.Fill;
                    _Form.Show();
                    break;
                case "Drawings":
                    _Form.Dispose();
                    _Form = new DrawingsForm();
                    _Form.TopLevel = false;
                    this.MainPanel.Controls.Add(_Form);
                    this.Size = new System.Drawing.Size(790, 480);
                    _Form.Dock = DockStyle.Fill;
                    _Form.Show();
                    break;
            }

        }

        
    }
}
