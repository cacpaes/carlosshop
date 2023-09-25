using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop
{
    public class Suppliers : People
    {
        // Additional attributes specific to Suppliers
        public string? ProductTypes { get; set; }
        public int Level { get; set; }
        public bool Sells { get; set; }

    }
}
