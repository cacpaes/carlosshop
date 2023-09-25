using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop
{
    public class Product
    {
        // Attributes of the Product class
        public int Id { get; set; }
        public string? Name { get; set; }
        public decimal Weight { get; set; }
        public string? Type { get; set; }
        public decimal Height { get; set; }
        public decimal Width { get; set; }
        public decimal Depth { get; set; }
        public decimal PurchaseValue { get; set; }
        public decimal SaleValue { get; set; }
        public decimal PurchaseVatRate { get; set; }
        public decimal SaleVatRate { get; set; }
    }
}
