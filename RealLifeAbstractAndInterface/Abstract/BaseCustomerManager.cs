using RealLifeAbstractAndInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealLifeAbstractAndInterface.Abstract
{
    public abstract class BaseCustomerManager : ICustomerService
    {
        public virtual void Save(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " saved to db.");
        }
    }
}
