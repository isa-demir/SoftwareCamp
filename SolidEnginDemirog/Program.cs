using System;

namespace SolidEnginDemirog
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    class CustomerManager
    {
        //bir tabloya update - tabloya insert
        public void TransactionalOperation()
        {
            Insert();
            Update();
        }
        public void Update()
        {
            MyContext myContext = new MyContext();
            myContext.Update();
        }

        public void Insert()
        {
            MyContext myContext = new MyContext();
            myContext.Insert();
        }
    }

    class PersonManager
    {
        public void Addd()
        {
            CustomerManager customerManager = new CustomerManager();
            customerManager.Insert();
        }
    }

    internal class MyContext
    {
        internal void Insert()
        {
            throw new NotImplementedException();
        }

        internal void Update()
        {
            throw new NotImplementedException();
        }
    }
}
