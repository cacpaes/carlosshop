using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarlosShop.Entities
{
    [Table("Transactions")]
    public class Transactions
    {

        [Key]
        public int TransactionId { get; set; }
        public int PersonId { get; set; }
        public decimal TotalAmount { get; set; }
        public string? TransactionType { get; set; }
        public DateTime TransactionDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
