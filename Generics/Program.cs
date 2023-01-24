using System;
using System.Collections.Generic;

namespace Generics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ordu");

            MyList<string> sehirler2 = new MyList<string>();
            Console.WriteLine(sehirler2.Count);
            
            sehirler2.Add("Ankara");
            sehirler2.Add("Ordu");
            sehirler2.Add("Ordu");
            sehirler2.Add("Ordu");
            sehirler2.Add("Ordu");
            Console.WriteLine(sehirler2.Count);

            Dictionary<int, string> plakaKodlari = new Dictionary<int, string>();
            plakaKodlari.Add(01, "Adana");
            plakaKodlari.Add(34, "İstanbul");
            plakaKodlari.Add(06, "Ankara");
            plakaKodlari.Add(42, "Konya");
            plakaKodlari.Add(52, "Ordu");
            plakaKodlari.Add(55, "Samsun");

            Console.Write("Merak ettiğiniz plaka kodunu giriniz : ");
            int plakaKodu;
            plakaKodu = int.Parse(Console.ReadLine());
            Console.WriteLine($"{plakaKodu} : {plakaKodlari[plakaKodu]}");

            
        }
    }
    class MyList<T>
    {
        T[] _array;

        public int Count
        {
            get { return _array.Length; }
        }

        public MyList()
        {
            _array = new T[0];
        }
        public void Add(T item)
        {
            T[] _tempList = _array;
            _array = new T[_tempList.Length + 1];
            for (int i = 0; i < _tempList.Length; i++)
            {
                _array[i] = _tempList[i];
            }
            _array[_array.Length - 1] = item;
        }
    }
}
