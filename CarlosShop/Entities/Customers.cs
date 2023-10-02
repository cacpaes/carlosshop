
using System.ComponentModel.DataAnnotations.Schema;

namespace CarlosShop.Entities
{
    [Table("Customer")]
    public class Customers : People
    {
        // Additional attributes specific to Customers
        public decimal CreditLimit { get; set; }
        public bool HasCard { get; set; }
    }
}
