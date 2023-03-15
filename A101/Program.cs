using A101.Absract;
using A101.Concreate;
using A101.Entities;
using System;

namespace A101
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IPersonCheckService personCheckService = new MernisValidationService();

            CustomerManager customerManager = new CustomerManager(personCheckService);
            EmployeeManager employeeManager = new EmployeeManager(personCheckService);


            Customer customer1 = new Customer {Id = 1, Name = "İsa", CustomerAppNumber = "1234", PhoneNumber = "05537391552", Wallet = 120.9};
            Customer customer2 = new Customer {Id = 2, Name = "Veli", CustomerAppNumber = "4231", PhoneNumber = "05537391555", Wallet = 200};

            customerManager.RegisterApp(customer1);
            customerManager.RegisterApp(customer2);

            Employee employee1 = new Employee { Id = 1, Department = "kasa", Name = "Zül", NationalityID = "231413424", PhoneNumber = "34234232423" };
            Employee employee2 = new Employee { Id = 2, Department = "müdür", Name = "Kal", NationalityID = "231413424", PhoneNumber = "05537391552" };

            employeeManager.Hire(employee1);
            employeeManager.Hire(employee2);

            employeeManager.Update(employee2, "Ahmet");
            Console.WriteLine(employee2.Name);

            employeeManager.CalculateSalary(employee2);
        }
    }
}
