using RealLifeAbstractAndInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealLifeAbstractAndInterface.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
