using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models.Expenses
{
    class DailyExpense
    {
        // public int DailyExpensesId { get; set; }
        public float OfficeExpenses { get; set; }
        public float Advertisement { get; set; }
        public float OtherExpanses { get; set; }
        public float TotalExpenses { get; set; }
        public string CurrentDay { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
