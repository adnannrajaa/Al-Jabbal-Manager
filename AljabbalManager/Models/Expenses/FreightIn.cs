using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models.Expenses
{
    class FreightIn
    {
        public int InvoiceNo { get; set; }
        public float TotalAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
