using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop
{
    public abstract class People
    {
        // Attributes of the Person class
        public int Id { get; set; }
        public string? Name { get; set; }
        public DateTime? DateBirth { get; set; }
        public string? Address { get; set; }
        public string? PhoneNumber { get; set; }
        public string? PublicServiceId { get; set; }
        public string? Email { get; set; }
    }
}
