using System;

namespace Youtube.ISP
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }

    //interface IWorker
    //{
    //    void PaySalary(); //maaş verilir
    //    void ProvideFood(); //Yemek ödenir
    //    void Work(); //çalıştırılır
    //}

    interface IPayable
    {
        void Pay();
    }
    interface IEatable
    {
        void Eat();
    }
    interface IWorkable
    {
        void Work();
    }

    class CompanyWorker : IPayable, IWorkable, IEatable
    {
        public void Eat()
        {
            throw new NotImplementedException();
        }

        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class OutsourceWorker : IWorkable, IPayable
    {
        public void Pay()
        {
            throw new NotImplementedException();
        }

        public void Work()
        {
            throw new NotImplementedException();
        }
    }

    class Robot : IWorkable
    {
        public void Work()
        {
            throw new NotImplementedException();
        }
    }

}
