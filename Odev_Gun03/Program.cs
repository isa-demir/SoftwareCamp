using System;
using System.Linq;

namespace Odev_Gun03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1 = 20, n2 = 80;
            int n3;
            int[] nArray = { 1,2,3,4,5};

            Add();
            Divider();
            Console.WriteLine(AddNumber(n1, n2));
            Divider();
            Console.WriteLine("Eski n1 -> " + n1);
            Console.WriteLine(AddNumberWithRef(ref n1, n2));
            Console.WriteLine("Yeni n1 -> " + n1);
            Divider();
            Console.WriteLine(AddNumberWithOut(out n3,n2));
            Divider();
            Console.WriteLine(Multiply(5, 8));
            Console.WriteLine(Multiply(nArray));
        }

        static void Divider() => Console.WriteLine("------------------");

        static public void Add()
        {
            Console.WriteLine("Added.");
        }
        static public int AddNumber(int number = 10, int number2 = 15) {
            return number + number2;
        }
        /*
         * Aşağıdaki kullanım hatalıdır. Default değer alan değişkenler
         * metodların sonunda bulunmalıdır.
         *
         * 
        static public int AddNumber1(int number = 10, int number2)
        {
            return number + number2;
        }
        */

        static public int AddNumberWithRef(ref int number, int number2 = 15)
        {
            number = 100;
            return number + number2;
        }
        static public int AddNumberWithOut(out int number, int number2 = 15)
        {
            number = 100;
            return number + number2;
        }

        static public int Multiply(int n1, int n2)
        {
            return n1 * n2;
        }
        static public int Multiply(int[] array)
        {
            int result = 1;
            foreach (var item in array)
            {
                result= result * item;
            }
            return result;
        }

        static int AddWithParams(params int[] array)
        {
            return array.Sum();
        }

    }
}
