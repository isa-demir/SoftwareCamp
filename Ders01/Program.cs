using System;

namespace Ders01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string k1 = "C#";
            string k2 = "Java";
            string k3 = "Python";

            string[] kurslar = new string[] { "C#", "Java", k3 };

            foreach (var item in kurslar)
            {
                Console.WriteLine("Kurs adı : " + item);
            }
        }
    }
}
