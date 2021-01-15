using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models.Sales
{
    class SalesPaymentRecord
    {
        public int SalesCustomerDetailId { get; set; }
        public int InvoiceNo { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }
        public float Loading { get; set; }
        public float NetAmount { get; set; }
        public float CashRecived { get; set; }
        public float RemainingBalance { get; set; }
        public float? DuePayment { get; set; }
        public DateTime? DuePaymentDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        
   
    }
}
