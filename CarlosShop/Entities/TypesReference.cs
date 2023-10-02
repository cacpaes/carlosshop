
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarlosShop.Entities
{
    [Table("TypesReference")]
    public class TypesReference
    {
        [Key]
        //[Column("TypeId")] 
        public int TypeId { get; set; }
        public string? TypeSimbol { get; set; }
        public string? TypeName { get; set; }
        public string? TypeEntity { get; set; }
        public string? TypeDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
