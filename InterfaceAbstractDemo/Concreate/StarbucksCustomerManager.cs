using InterfaceAbstractDemo.Abstract;
using InterfaceAbstractDemo.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemo.Concreate
{
    public class StarbucksCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;

        public StarbucksCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }

        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                //veritabanına kayıt eden kod
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person!");
            }
        }
        
    }
}
