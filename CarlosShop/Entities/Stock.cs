using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop.Entities
{
    public class Stock
    {
        // Attributes of the Stock class
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UnitQuantity { get; set; }
    }
}
