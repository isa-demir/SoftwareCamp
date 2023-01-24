using InterfaceAbstractDemoRepeat.Abstract;
using InterfaceAbstractDemoRepeat.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemoRepeat.Concrete
{
    internal class NeroCustomerManager : BaseCustomerManager
    {
        ICustomerCheckService _customerCheckService;
        public NeroCustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public override void Save(Customer customer)
        {
            if (_customerCheckService.CheckIfRealPerson(customer))
            {
                Console.WriteLine("--Nero--");
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person!");
            }
            
        }
    }
}
