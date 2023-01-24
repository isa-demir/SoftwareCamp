using System;

namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //İsa Demir
            GercekMusteri musteri1= new GercekMusteri();
            musteri1.Id = 1;
            musteri1.FirstName = "İsa";
            musteri1.LastName = "Demir";
            musteri1.MusteriNo = "12345";
            musteri1.TcNo = "222222222";

            //Demir Holding
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "12345";
            musteri2.SirketAdi = "Demir Holding";
            musteri2.VergiNo = "09876";

            Customer musteri3 = new GercekMusteri();
            Customer musteri4 = new TuzelMusteri();

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(musteri1);
            customerManager.Add(musteri2);
            customerManager.Add(musteri3);
            customerManager.Add(musteri4);

        }
    }
}
