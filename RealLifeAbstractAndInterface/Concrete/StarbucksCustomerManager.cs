﻿using RealLifeAbstractAndInterface.Abstract;
using RealLifeAbstractAndInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealLifeAbstractAndInterface.Concrete
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
                base.Save(customer);
            }
            else
            {
                Console.WriteLine("Not a valid person!");
            }
            
        }
    }
}
