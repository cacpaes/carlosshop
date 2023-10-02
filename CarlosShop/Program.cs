using CarlosShop.Entities;
using CarlosShop.Repositories;


RepositoryCustomer repositoryCustomer = new();

Customers customer = new();
customer.PersonName = "Allen Prado";
customer.DateBirth = Convert.ToDateTime("19/06/1987");
customer.PersonAddress = "Rua do Some e Desce, N 52";
customer.PhoneNumber = "707070707070";
customer.PublicServiceId = "855854478";
customer.Email = "allenprado@gmail.com";
customer.PersonType = "C";
customer.HasCard = true;
customer.CreditLimit = Convert.ToDecimal("50000.50");
customer.CreatedDate = DateTime.Now;

await repositoryCustomer.Create(customer);