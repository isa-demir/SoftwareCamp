using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;

            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[]{ 10, 20, 30};
            int[] sayilar2 = new int[] { 100, 202, 300 };

            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            sayilar1[1] = 888;
            Console.WriteLine(sayilar1[0]);
            Console.WriteLine(sayilar2[1]);


            string name1 = "İsa";
            string name2 = "Selver";

            name1 = name2;
            name2 = "İsa ve Selver";
            Console.WriteLine(name1);

        }
    }
}
