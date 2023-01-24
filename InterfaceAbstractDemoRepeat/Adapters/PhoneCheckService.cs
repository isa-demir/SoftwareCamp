using InterfaceAbstractDemoRepeat.Abstract;
using InterfaceAbstractDemoRepeat.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemoRepeat.Adapters
{
    public class PhoneCheckService : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            //Console.WriteLine("Telefon doğrulaması başarılı. " + customer.FirstName);
            return false;
        }
    }
}
