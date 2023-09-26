using CarlosShop.Entities;
using CarlosShop.Repositories;

var repositoryCustomer = new RepositoryCustomer();

var customer = new Customers();

Console.WriteLine("Informe o Id");
customer.Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o Name");
customer.Name = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe o Email");
customer.Email = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe nova data");
customer.DateBirth = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Informe o Adress");
customer.Address = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe se tem Cartão");
customer.HasCard = Convert.ToBoolean(Console.ReadLine());
Console.WriteLine("Informe o Credit Limit");
customer.CreditLimit = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe o Phone Number");
customer.PhoneNumber = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe o Public Service Id");
customer.PublicServiceId = Convert.ToString(Console.ReadLine());

repositoryCustomer.Create(customer);


var repositoryEmployee = new RepositoryEmployee();

var employee = new Employees();

Console.WriteLine("Informe o Id");
employee.Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o Name");
employee.Name = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe o Email");
employee.Email = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe a Data do Aniversario");
employee.DateBirth = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Informe o Adress");
employee.Address = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe Quanto e o Salario");
employee.Salary = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe a Data data de Inicio");
employee.StartDate = Convert.ToDateTime(Console.ReadLine());
Console.WriteLine("Informe o Phone Number");
employee.PhoneNumber = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe o Public Service Id");
employee.PublicServiceId = Convert.ToString(Console.ReadLine());

repositoryEmployee.Create(employee);

