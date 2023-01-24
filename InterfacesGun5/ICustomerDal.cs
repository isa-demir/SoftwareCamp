using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesGun5
{
    internal interface ICustomerDal
    {
        void Add();
        void Update();
        void Delete();
    }

    class SqlServerCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Sql added!");
        }

        public void Delete()
        {
            Console.WriteLine("Sql deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Sql updated!");
        }
    }
    class OracleCustomerDal : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine("Oracle added!");
        }

        public void Delete()
        {
            Console.WriteLine("Oracle deleted!");
        }

        public void Update()
        {
            Console.WriteLine("Oracle updated!");
        }
    }
    class CustomerManager
    {
        public void Add(ICustomerDal customer)
        {
            customer.Add();
        }
        public void Delete(ICustomerDal customer)
        {
            customer.Delete();
        }
        public void Update(ICustomerDal customer)
        {
            customer.Update();
        }
    }
}
