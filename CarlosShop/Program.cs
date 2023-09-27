using CarlosShop.Entities;
using CarlosShop.Repositories;


//Repository Customer

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



//Repository  Employee

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


//Repository Supplier

var repositorySupplier = new RepositorySupplier();

var supplier = new Suppliers();

Console.WriteLine("Informe o Id");
supplier.Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o Name");
supplier.Name = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe o Email");
supplier.Email = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe seu endereço");
supplier.Address = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe seu numero");
supplier.PhoneNumber = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe seu CNPJ/CPF");
supplier.PublicServiceId = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe o Tipo de produto");
supplier.ProductTypes = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe o Level ");
supplier.Level = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe se foi vendido");
supplier.Sells = Convert.ToBoolean(Console.ReadLine());

repositorySupplier.Create(supplier);


//Repository Product

var repositoryProdcut = new RepositoryProduct();

var product = new Product();

Console.WriteLine("Informe o Id");
product.Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o Name");
product.Name = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe o Email");
product.Type = Convert.ToString(Console.ReadLine());
Console.WriteLine("Informe seu endereço");
product.Weight = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe seu numero");
product.Height = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe seu CNPJ/CPF");
product.Width = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe o Tipo de produto");
product.Depth = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe o Level ");
product.PurchaseValue = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe se foi vendido");
product.SaleValue = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe se foi vendido");
product.PurchaseVatRate = Convert.ToDecimal(Console.ReadLine());
Console.WriteLine("Informe se foi vendido");
product.SaleVatRate = Convert.ToDecimal(Console.ReadLine());

repositorySupplier.Create(supplier);


//Repository Stock

var repositoryStock = new RepositoryStock();

var stock = new Stock();

Console.WriteLine("Informe o Id");
stock.Id = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o Name");
stock.ProductId = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe o Email");
stock.UnitQuantity = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Informe seu endereço");

repositoryStock.Create(stock);