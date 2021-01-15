using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Screens.UserScreens;
using ASDBFramework.Screens;
using ASDBFramework.Screens.UserScreens.Income.IncomeDeshBoard;
using ASDBFramework.Screens.UserScreens.Expenses.ExpensesDeshBoard;
using ASDBFramework.Screens.UserScreens.Users;
using ASDBFramework.Models.Users;
using ASDBFramework.Screens.UserScreens.Products;
using ASDBFramework.Screens.UserScreens.Products.ProductDeshBoard;
using ASDBFramework.Screens.UserScreens.Sales.SalesDeshBoard;
using ASDBFramework.Screens.UserScreens.Sales.SaleInvoice;
using ASDBFramework.Screens.UserScreens.Debiters.DebitersDeshBoard;
using ASDBFramework.Screens.UserScreens.Users.UserDeshBoard;
using ASDBFramework.Screens.UserScreens.Income;
namespace ASDBFramework
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run( new NotificationForm());
            
            
        }
    }
}
