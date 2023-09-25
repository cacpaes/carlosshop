using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop
{
    public class Transactions
    {
        // Attributes of the Transactions class
        public int Id { get; set; }
        public int EntityId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public string? Type { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
