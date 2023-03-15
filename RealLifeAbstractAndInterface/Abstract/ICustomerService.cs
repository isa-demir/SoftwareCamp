using RealLifeAbstractAndInterface.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RealLifeAbstractAndInterface.Abstract
{
    public interface ICustomerService
    {
        void Save(Customer customer);
    }
}
