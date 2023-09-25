using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop.Entities
{
    public class Customers : People
    {
        // Additional attributes specific to Customers
        public decimal CreditLimit { get; set; }
        public bool HasCard { get; set; }
    }
}
