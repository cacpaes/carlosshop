
using System.ComponentModel.DataAnnotations.Schema;

namespace CarlosShop.Entities
{
    [Table("Employee")]
    public class Employees : People
    {
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
}
