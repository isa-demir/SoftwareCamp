using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    internal class ProductManager
    {
        public void Add(Product product)
        {
            Console.WriteLine($"{product.ProductName} başarıyla eklendi.");
        }
    }
}
