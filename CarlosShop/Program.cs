using CarlosShop.Entities;
using CarlosShop.Repositories;

var repositoryCustomer = new RepositoryCustomer();

var customer = new Customers();

Console.WriteLine("Informe o Id");
customer.Id = Convert.ToInt32(Console.ReadLine());

customer.Name = "Carlos Carvalho";
customer.Email = "cacarvalho.paes@gmail.com";
Console.WriteLine("Informe nova data");
customer.DateBirth = Convert.ToDateTime(Console.ReadLine());
customer.Address = "41 Temple Place";
customer.HasCard = true;
customer.CreditLimit = 100;
customer.PhoneNumber = "0834187086";
customer.PublicServiceId = "13809837709";

repositoryCustomer.Create(customer);

