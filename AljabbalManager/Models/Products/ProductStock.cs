using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models.Products
{
    public class ProductStock
    {
        public int ProductCode { get; set; }
        public float ProductQuantity { get; set; }
        public float ProductCostPrice { get; set; }
        public float ProductRetailPrice { get; set; }
        public float OutOfStock { get; set; }
        public string CreatedBy { get; set; }
    }
}
