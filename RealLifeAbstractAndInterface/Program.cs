using RealLifeAbstractAndInterface.Abstract;
using RealLifeAbstractAndInterface.Adapters;
using RealLifeAbstractAndInterface.Concrete;
using System;

namespace RealLifeAbstractAndInterface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomerCheckService mernisCheckService =new MernisServiceAdapter();

            BaseCustomerManager customerManager = new StarbucksCustomerManager(mernisCheckService);
            customerManager.Save(new Entities.Customer 
            {
                Id= 1,
                DateOfBirth = new DateTime(2001, 2, 1),
                FirstName = "İsa",
                LastName = "Demir",
                NationalityId = "14087797272",
            });
        }
    }
}
