using System.ComponentModel.DataAnnotations.Schema;

namespace CarlosShop.Entities
{
    [Table("Supplier")]
    public class Suppliers : People
    {
        public string? ProductTypes { get; set; }
        public int SupplierLevel { get; set; }
        public bool Sells { get; set; }

    }
}
