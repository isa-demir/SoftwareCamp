using A101.Absract;
using A101.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Concreate
{
    public class CustomerManager :BaseManager, ICustomerService
    {
        public CustomerManager(IPersonCheckService personCheckService) : base(personCheckService)
        {
        }

        public void DeleteAccount(Customer customer)
        {
            Console.WriteLine(customer.Name + " has been deleted from db.");
        }

        public void RegisterApp(Customer customer)
        {
            if (CheckIfRealPerson(customer) == true)
            {
                Console.WriteLine(customer.Name + " registered successfully.");
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulaması başarısız.");
            }
            
        }
    }
}
