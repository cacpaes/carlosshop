using CarlosShop.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarlosShop.Repositories
{
    public  class RepositoryCustomer
    {
        public void Create(Customers customerEntry) 
        {
            var customer = new Customers();

            customer.Id = customerEntry.Id;
            customer.Name = customerEntry.Name;
            customer.Email = customerEntry.Email;
            customer.Address = customerEntry.Address;
            customer.PhoneNumber = customerEntry.PhoneNumber;
            customer.DateBirth = customerEntry.DateBirth;
            customer.PublicServiceId = customerEntry.PublicServiceId;
            customer.CreditLimit = customerEntry.CreditLimit;
            customer.HasCard = customerEntry.HasCard;

            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.Name);
            Console.WriteLine(customer.Email);
            Console.WriteLine(customer.Address);
            Console.WriteLine(customer.PhoneNumber);
            Console.WriteLine(customer.DateBirth);
            Console.WriteLine(customer.PublicServiceId);
            Console.WriteLine(customer.CreditLimit);
            Console.WriteLine(customer.HasCard);

        }


    }
}
