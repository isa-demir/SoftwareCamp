using System;

namespace Mehods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductName = "Keyboard";
            product1.ProductPrice = 300;
            product1.ProductDescription = "Mechanical Keyboard From Razer";
            product1.InStock= 10;

            Product product2 = new Product();
            product2.ProductName = "Webcam";
            product2.ProductPrice = 120;
            product2.ProductDescription = "HD Webcamera From Logitech";
            product2.InStock = 7;  

            Product[] products = { product1, product2 };

            foreach (var item in products)
            {
                Console.WriteLine("       Ürün adı : " + item.ProductName);
                Console.WriteLine("    Ürün fiyatı : " + item.ProductPrice);
                Console.WriteLine("Ürün Açıklaması : " + item.ProductDescription);
                Console.WriteLine("------------------------");
            }
            Console.WriteLine("\n--------------METODLAR--------------\n");
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
        }
    }
}
