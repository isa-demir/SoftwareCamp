using System;

namespace InterfaceSegregationPrinciple
{
    internal class Program
    {
        /*
         * Interface Segregation prensibine göre, “istemcilerin
         * kullanmadıkları arayüzleri uygulamaya zorlanmaması gerektiğini”
         * savunulmaktadır. Herbir interface’in belirli bir amacı olmalıdır.
         * Tüm metodları kapsayan tek bir interface kullanmak yerine, herbiri
         * ayrı metod gruplarına hizmet veren birkaç interface tercih edilmektedir.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
