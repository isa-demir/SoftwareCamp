using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    //Bu interface'i implement eden her sınıf penaltıkurtar'ı da implement edecektir.
    //Fakat sadece kaleci için bu söz konusudur.
    public interface IFutbolcu
    {
        void DefansYap();
        void PenaltiKurtar();
        void PasAt();
        void GolAt();
    }

    class Kaleci : IFutbolcu
    {
        public void DefansYap()
        {
            Console.WriteLine("Defans yap!");
        }

        public void GolAt()
        {
            Console.WriteLine();
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
    class Forvet : IFutbolcu
    {
        public void DefansYap()
        {
            throw new NotImplementedException();
        }

        public void GolAt()
        {
            throw new NotImplementedException();
        }

        public void PasAt()
        {
            throw new NotImplementedException();
        }
        //??????
        public void PenaltiKurtar()
        {
            throw new NotImplementedException();
        }
    }
}
