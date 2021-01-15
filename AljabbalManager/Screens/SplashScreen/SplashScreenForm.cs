using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ASDBFramework.Screens.Templates;
using ASDBFramework.Models;
using ASDBFramework.Utillities;
using System.Data.SqlClient;
using ASDBFramework.Screens.UserScreens.ProductLicense;

namespace ASDBFramework.Screens.SplashScreen
{
    public partial class SplashScreenForm : TemplateForm
    {

        public SplashScreenForm()
        {
           
            InitializeComponent();
        }
        private void SplashScreenForm_Load(object sender, EventArgs e)
        {
           
            this.SplashScreenProgressBarTimer.Start();
          
        }
        private void SplashScreenProgressBarTimer_Tick(object sender, EventArgs e)
        {
            this.SplashScreenProgressBar.Increment(1);
        }


       
    }
}
