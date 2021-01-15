using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models.Expenses
{
    class MonthlyExpenses
    {

        public float TelephoneBill { get; set; }
        public float ElectricityBill { get; set; }
        public float BuildingRent { get; set; }
        public float InternetCharges { get; set; }
        public float TotalExpenses { get; set; }
        public string CurrentMonth { get; set; }
        public string CurrentYear { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
