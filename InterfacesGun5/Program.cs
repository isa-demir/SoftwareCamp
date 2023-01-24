using System;

namespace InterfacesGun5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //InterfacesV1();
            IWorker[] workers = new IWorker[] {new Manager(), new Robot(), new Worker() };
            IPersonWorker[] personWorkers = new IPersonWorker[] { new Manager(), new Worker()};
            
            foreach (var worker in workers)
            {
                worker.Work();
            }

            foreach (var worker in personWorkers)
            {
                worker.Eat();
                worker.GetSalary();
            }

        }

        private static void InterfacesV1()
        {
            ICustomerDal[] customerDals = new ICustomerDal[] { new OracleCustomerDal(), new SqlServerCustomerDal() };

            foreach (var customerDal in customerDals)
            {
                customerDal.Add();
                customerDal.Update();
                customerDal.Delete();
            }
        }
    }
    interface IWorker
    {
        void Work();
    }

    interface IPersonWorker
    {
        void Eat();
        void GetSalary();
    }

    class Manager : IWorker, IPersonWorker
    {
        public void Eat()
        {
            Console.WriteLine("Manager eating.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Manager getting salary.");
        }

        public void Work()
        {
            Console.WriteLine("Manager working"); 
        }
    }
    class Worker : IWorker, IPersonWorker
    {
        public void Eat()
        {
            Console.WriteLine("Worker eating.");
        }

        public void GetSalary()
        {
            Console.WriteLine("Worker getting salary.");
        }

        public void Work()
        {
            Console.WriteLine("Worker working");
        }
    }
    class Robot : IWorker
    {
        public void Work()
        {
            Console.WriteLine("Robot is working.");
        }
    }
}
