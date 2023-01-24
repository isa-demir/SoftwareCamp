using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    //IFubolcu
    internal interface IDogruKod
    {
        void OrtaAc();
        void PasAt();
    }
    interface IForvet
    {
        void GolAt();
    }
    internal interface IKaleci
    {
        void PenaltiKurtar();
    }
    class Kaleci2 : IDogruKod, IKaleci
    {
        public void OrtaAc()
        {
            throw new NotImplementedException();
        }

        public void PasAt()
        {
            throw new NotImplementedException();
        }

        public void PenaltiKurtar()
        {
            throw new NotImplementedException();
        }
    }



    public class Forvet2 : IDogruKod, IForvet
    {
        public void PasAt()
        {
            Console.WriteLine("Pas at..");
        }

        public void GolAt()
        {
            Console.WriteLine("Çok iyi şut çekti..");
        }

        public void OrtaAc()
        {
            Console.WriteLine("Orta açtı..");
        }

    }
}
