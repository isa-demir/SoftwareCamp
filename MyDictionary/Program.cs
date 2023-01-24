using System;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> plakaKodlari = new MyDictionary<int, string>();
            plakaKodlari.Add(34, "İstanbul");
            plakaKodlari.Add(06, "Ankara");
            plakaKodlari.Add(52, "Ordu");
            plakaKodlari.Add(55, "Samsun");
            plakaKodlari.Add(35, "İzmir");

            Console.WriteLine(plakaKodlari.LastValue);
            plakaKodlari.Listele();
        }
    }

    class MyDictionary<K,V>
    {
        K[] keys;
        V[] values;

        public MyDictionary()
        {
            keys= new K[0];
            values= new V[0];
        }

        public V LastValue
        {
            get { return values[values.Length-1]; }
            
        }


        public void Add(K key,V value)
        {
            K[] tempKeys = keys;
            V[] tempValues= values;

            keys = new K[tempKeys.Length+1];
            values = new V[tempValues.Length+1];


            for (int i = 0; i < tempKeys.Length; i++)
            {
                keys[i] = tempKeys[i];
                values[i] = tempValues[i];
            }
            keys[keys.Length-1] = key;
            values[keys.Length - 1] = value;
        }

        public void Listele()
        {
            for (int i = 0; i < keys.Length; i++)
            {
                Console.WriteLine(keys[i] + " : " + values[i]);
            }
        }

    }
}
