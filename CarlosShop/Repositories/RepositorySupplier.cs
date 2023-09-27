using CarlosShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop.Repositories
{
    public class RepositorySupplier
    {
        public void Create(Suppliers supplierEntry)
        {
            var supplier = new Suppliers();

            supplier.Id = supplierEntry.Id;
            supplier.Name = supplierEntry.Name;
            supplier.Email = supplierEntry.Email;
            supplier.Address = supplierEntry.Address;
            supplier.PhoneNumber = supplierEntry.PhoneNumber;
            supplier.PublicServiceId = supplierEntry.PublicServiceId;
            supplier.ProductTypes = supplierEntry.ProductTypes;
            supplier.Sells = supplierEntry.Sells;
            supplier.Level = supplierEntry.Level;

            Console.WriteLine(supplier.Id);
            Console.WriteLine(supplier.Name);
            Console.WriteLine(supplier.Email);
            Console.WriteLine(supplier.Address);
            Console.WriteLine(supplier.PhoneNumber);
            Console.WriteLine(supplier.PublicServiceId);
            Console.WriteLine(supplier.ProductTypes);
            Console.WriteLine(supplier.Sells);
            Console.WriteLine(supplier.Level);

        }
    }
}
