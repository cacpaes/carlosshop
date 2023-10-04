using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarlosShop.Entities
{
    [Table("Stock")]
    public class Stock
    {
        
        [Key]
        public int StockId { get; set; }
        public int ProductId { get; set; }
        public int UnitQuantity { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? PersonType { get; set; }
    }
}
