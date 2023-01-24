using System;

namespace LiskovSubstitionPrinciple
{
    internal class Program
    {
        //Bir class ta bulunan özellikler, kendisinden kalıtım alan
        //class’larda kullanılmayacaksa bu durum LSP’ye aykırı bir durumdur.
        static void Main(string[] args)
        {
            Tavuk2 tavuk = new Tavuk2();
            MuhabbetKusu muhabbetKusu = new MuhabbetKusu();

            tavuk.Yuru();
            muhabbetKusu.Yuru();
            muhabbetKusu.Uc();
        }
    }
    //Yani kalıtım alınan class’ın içindeki özellikler kalıtımı alan
    //class ta kullanılmalıdır. Aşığıdaki örnekte İlgili metod Guvercin
    //için düzgün çalışmakta olup, tavuk için sorun olacaktır. Bu yüzden
    //ilgili metodları aşağıdaki şekilde 2 ye bölmeliyiz.
    public abstract class Kus
    {
        public abstract string Uc();
        public abstract string Yuru();
    }
    //KÖTÜ KOD
    public class Tavuk : Kus
    {
        public override string Uc()
        {
            //hata döndürür
            throw new NotImplementedException();
        }
        public override string Yuru()
        {
            return "Yürüdü..";
        }
    }
    public class Guvercin : Kus
    {
        public override string Uc()
        {
            return "Uçtu..";
        }
        public override string Yuru()
        {
            return "Yürüdü..";
        }
    }

}
