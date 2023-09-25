using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop
{
    public class Employees : People
    {
        // Additional attributes specific to Employees
        public decimal Salary { get; set; }
        public DateTime StartDate { get; set; }
    }
}
