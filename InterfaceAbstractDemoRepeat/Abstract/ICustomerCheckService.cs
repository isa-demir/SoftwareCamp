using InterfaceAbstractDemoRepeat.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceAbstractDemoRepeat.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}
