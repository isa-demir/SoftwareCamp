using A101.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Absract
{
    public interface ICustomerService
    {
        void RegisterApp(Customer customer);
        void DeleteAccount(Customer customer);
    }
}
