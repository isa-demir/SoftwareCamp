using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovSubstitionPrinciple
{
    internal interface IUcanlar
    {
        void Uc();
    }
    internal interface IYuruyenler
    {
        void Yuru();
    }

    class Tavuk2 : IYuruyenler
    {
        public void Yuru()
        {
            Console.WriteLine("Tavuk Yurudu");
        }
    }
    class MuhabbetKusu : IUcanlar, IYuruyenler
    {
        public void Uc()
        {
            Console.WriteLine("Kuş uçtu");
        }

        public void Yuru()
        {
            Console.WriteLine("Kuş yürüdü");
        }
    }
}
