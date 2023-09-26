using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CarlosShop.Entities;

namespace CarlosShop.Repositories
{
    public class RepositoryEmployee
    {
        public void Create(Employees employeeEntry)
        {
            var employee = new Employees();

            employee.Id = employeeEntry.Id;
            employee.Name = employeeEntry.Name;
            employee.Email = employeeEntry.Email;
            employee.Address = employeeEntry.Address;
            employee.PhoneNumber = employeeEntry.PhoneNumber;
            employee.DateBirth = employeeEntry.DateBirth;
            employee.PublicServiceId = employeeEntry.PublicServiceId;
            employee.Salary = employeeEntry.Salary;
            employee.StartDate = employeeEntry.StartDate;

            Console.WriteLine(employee.Id);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Email);
            Console.WriteLine(employee.Address);
            Console.WriteLine(employee.PhoneNumber);
            Console.WriteLine(employee.DateBirth);
            Console.WriteLine(employee.PublicServiceId);
            Console.WriteLine(employee.Salary);
            Console.WriteLine(employee.StartDate);

        }


    }
}
