using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Adapters;
using InterfaceAbstractDemo.Concreate;
using InterfaceAbstractDemo.Entities;
using System;

namespace InterfaceAbstractDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new StarbucksCustomerManager(new MernisServiceAdapter());
            customerManager.Save(new Customer { DateOfBirth = new DateTime(2001, 2, 1), FirstName = "İsa", LastName = "Demir", NationalityId = "14087797272"});

        }
    }

    
}
