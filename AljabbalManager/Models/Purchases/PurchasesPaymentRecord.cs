using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models.Purchases
{
    class PurchasesPaymentRecord
    {
        public int PurchasesCompanyDetailId { get; set; }
        public float SubTotal { get; set; }
        public float Discount { get; set; }
        public float NetAmount { get; set; }
        public float CashPayed { get; set; }
        public float RemainingBalance { get; set; }
        public float? DuePayment { get; set; }
        public DateTime? DuePaymentDate { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
