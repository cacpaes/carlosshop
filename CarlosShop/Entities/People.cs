using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarlosShop.Entities
{
    [Table("People")]
    public abstract class People
    {
        // Attributes of the Person class

        [Key]
        public int PersonID { get; set; }
        public string? PersonName { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? PersonAddress { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PublicServiceId { get; set; }
        public string? Email { get; set; }
        public string? PersonType { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
