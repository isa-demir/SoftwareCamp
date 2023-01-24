using System;

namespace GenericsIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();

            Console.WriteLine(isimler.Length);
            
            isimler.Add("isa");
            Console.WriteLine(isimler.Length);

            isimler.Add("ahmet");
            Console.WriteLine(isimler.Length);


            foreach (var item in isimler.items)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
