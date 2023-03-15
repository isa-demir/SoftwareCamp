using RealLifeAbstractAndInterface.Abstract;
using RealLifeAbstractAndInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealLifeAbstractAndInterface.Concrete
{
    //The class coded for test!
    public class CustomerCheckManager : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}
