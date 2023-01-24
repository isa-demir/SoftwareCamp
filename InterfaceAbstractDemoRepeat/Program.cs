using InterfaceAbstractDemoRepeat.Abstract;
using InterfaceAbstractDemoRepeat.Adapters;
using InterfaceAbstractDemoRepeat.Concrete;
using System;

namespace InterfaceAbstractDemoRepeat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICustomerCheckService customerCheckServiceMernis = new MernisAdapterService();
            ICustomerCheckService customerCheckServicePhone = new PhoneCheckService();

            BaseCustomerManager starbucksCustomerManager = new StarbucksCustomerManager(customerCheckServicePhone);
            BaseCustomerManager neroCustomerManager = new NeroCustomerManager(customerCheckServiceMernis);

            starbucksCustomerManager.Save(new Entities.Customer { Id = 1, FirstName = "İsa", LastName = "Demir", DateOfBirth = new DateTime(2001, 2, 1), NationalityId = "1234567890" });
            neroCustomerManager.Save(new Entities.Customer { Id = 2, FirstName = "Barış Ali", LastName = "Kazankaya", DateOfBirth = new DateTime(1998,12 , 26), NationalityId = "35677638140" });
            neroCustomerManager.Save(new Entities.Customer { Id = 3, FirstName = "Volkan", LastName = "Dinç", DateOfBirth = new DateTime(2003,4,19),NationalityId = "32530818336"});

        }
    }
}
