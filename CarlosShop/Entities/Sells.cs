using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarlosShop.Entities
{

    [Table("Sells")]
    public class Sells
    {
        [Key]
        public int SellsId { get; set; }
        public int TransactionId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalAmount { get; set; }
        public DateTime SellDate { get; set; }
    }
}

