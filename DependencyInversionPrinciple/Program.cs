using System;

namespace DependencyInversionPrinciple
{
    internal class Program
    {
        /*
         * Bu prensibimiz tanım olarak “Yüksek seviyeli sınıflar,
         * düşük seviyeli sınıflara bağlı olmamalı, her ikisi de soyut
         * kavramlara bağlı olmalıdır” görüşünü savunmaktadır.
         * 
         * Soyutlamalar ayrıntılara bağlı olmamalıdır. Detaylar soyutlamalara bağlı 
         * olmalıdır. Yani alt sınıflarda yapılan bir değişiklik üst sınıfları etkilememelidir.
         */
        static void Main(string[] args)
        {
            Car renault = new Renault() {Brand = "Renault" };
            Car peugeot = new Peugeot() {Brand = "Peugeot" };

            CarManager carManager = new CarManager(peugeot);
            carManager.Start();
        }
    }
}
