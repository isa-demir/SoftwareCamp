using System;
using System.Collections.Generic;
using System.Text;

namespace MyBankSimulation
{
    internal class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} added.");
        }
        public void Remove(Customer customer) 
        {
            Console.WriteLine($"Customer {customer.FirstName} {customer.LastName} removed.");
        }
        public void ShowCustomerInfos(Customer customer)
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine($"     Name : " + customer.FirstName);
            Console.WriteLine($"Last Name : " + customer.LastName);
            Console.WriteLine($"     City : " + customer.Address);
            Console.WriteLine("--------------------------------------");
        }
    }
}
