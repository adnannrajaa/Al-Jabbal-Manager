using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace ASDBFramework.Utillities
{
    public class AppSetting
    {
        public static string ConnectionString()
        {
           return ConfigurationManager.ConnectionStrings["dbcon"].ConnectionString;
        }
    }
}
