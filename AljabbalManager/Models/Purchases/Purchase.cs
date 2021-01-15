using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models.Purchases
{
    public class Purchase
    {
       // public int StockId { get; set; }
        public string ProductType { get; set; }
        public string ProductName { get; set; }
        public float ProductQuantity { get; set; }
        public int ProductUnitId { get; set; }
        public float ProductCostPrice { get; set; }
        public float ProductRetailPrice { get; set; }
        public float ShortageLimit { get; set; }
        public string CreatedBy { get; set; }
    }
}
