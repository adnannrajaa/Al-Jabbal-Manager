using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens.Users.ManageEmployees;
using ASDBFramework.Screens.UserScreens.Users.ManageShareholders;

namespace ASDBFramework.Screens.UserScreens.Users.UserDeshBoard
{
    public partial class UserInterfaceForm : TemplateForm
    {
        private Form _Form;
        public UserInterfaceForm()
        {
            InitializeComponent();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            _Form = new ManageUserForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Manage Users";
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
        private void UserForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingAction();
        }
        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new AddNewUserForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Add New User";
        }

        private void manageUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new ManageUserForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Manage User";
        }

        private void addNewEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new AddNewEmployeeForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Add New Employee";
        }

        private void manageEmployeesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new ManageEmployeesForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Manage Employees";
        }

        private void addNewShareholderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new AddNewShareholderForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Add New Shareholder";
        }

        private void manageShareholdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new ManageShareholdersForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
            ToolStripStatusLabel.Text = "Welcome To AL-Jabbal Management System ~ Manage Shareholder";
        }
    }
}
