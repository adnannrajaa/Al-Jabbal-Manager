using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ASDBFramework.Models
{
    public class ProductLicense
    {
        public string Name { get; set; }
        public string ProductKey { get; set; }
        public DateTime TrialExpiryDate { get; set; }
    }
}
