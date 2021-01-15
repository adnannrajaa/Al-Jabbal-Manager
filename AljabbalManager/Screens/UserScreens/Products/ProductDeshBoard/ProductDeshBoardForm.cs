using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens.Products.ViewProducts;
using ASDBFramework.Screens.UserScreens.Products.ManageToken;

namespace ASDBFramework.Screens.UserScreens.Products.ProductDeshBoard
{
    public partial class ProductDeshBoardForm : TemplateForm
    {
        private Form _Form;
        public ProductDeshBoardForm()
        {
            InitializeComponent();
        }

        private void ProductDeshBoardForm_Load(object sender, EventArgs e)
        {
            _Form = new AddNewPurchasesForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this._Form.Location = new System.Drawing.Point(3, 3);
            this.Size = new System.Drawing.Size(1033, 675);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }
        private void ProductDeshBoardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormClosingAction();
        }

        private void productsPurchasesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new AddNewPurchasesForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this._Form.Location = new System.Drawing.Point(3, 3);
            this.Size = new System.Drawing.Size(1033, 675);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }
        private void productsDetailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new ProductsDetailForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(1033, 675);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void stockDetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new StockDetailForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(1033, 675);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void allProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new ViewAllProductsForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(1033, 675);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();

        }

        private void shortProductsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            _Form = new ShortProductsForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(1033, 675);
           

            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void applyFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            this.StartPosition = FormStartPosition.CenterScreen;
            _Form = new ViewByFilterForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(1033, 675);
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

        private void ManageTokensToolStripButton_Click(object sender, EventArgs e)
        {
            _Form.Dispose();
            this.StartPosition = FormStartPosition.CenterScreen;
            _Form = new ManageTokenForm();
            _Form.TopLevel = false;
            this.MainPanel.Controls.Add(_Form);
            this.Size = new System.Drawing.Size(1033, 675);
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        

       
    }
}
