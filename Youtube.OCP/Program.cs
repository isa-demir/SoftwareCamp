using System;

namespace Youtube.OCP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager(new DapperCustomerDal());
            customerManager.Add();
        }
    }
    //Loosely Coupled -> Gevşek Bağ
    //IOC Container --> Ninject, AutoFac, Structure Map, Castle Windsor
    class CustomerManager
    {
        ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public void Add()
        {
            _customerDal.Add();
        }
    }
    class EFCustomerDal : ICustomerDal
    {
        public void Add()
        {
            //EF kodları varsayalım.
            Console.WriteLine("Added by EF to db.");
        }
    }
    class DapperCustomerDal : ICustomerDal
    {
        public void Add()
        {
            //Dapper kodları varsayalım.
            Console.WriteLine("Added by Dapper to db.");
        }
    }

    internal interface ICustomerDal
    {
        void Add();
    }
}
