using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models.Expenses
{
    class Wages
    {

        public string EmployeeName { get; set; }
        public string CurrentMonth { get; set; }
        public string CurrentYear { get; set; }
        public float TotalAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
