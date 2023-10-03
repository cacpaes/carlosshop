using CarlosShop.Entities;
using CarlosShop.Repositories;


RepositoryEmployee repositoryEmployee = new();

Employees employee = new();
employee.PersonName = "Wendel Pessoa";
employee.DateBirth = Convert.ToDateTime("28/10/1985");
employee.PersonAddress = "Rua Pessoa N 57";
employee.PhoneNumber = "6149843313555446";
employee.PublicServiceId = "561353121111531";
employee.Email = "pessoa@gmail.com";
employee.Salary = Convert.ToDecimal("2000,00");
employee.PersonType = "E";
employee.StartDate = Convert.ToDateTime("11/10/2021");
employee.CreatedDate = DateTime.Now;

await repositoryEmployee.Create(employee);