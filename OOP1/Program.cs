using System;

namespace OOP1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager();

            Product product1 = new Product();
            product1.Id= 1;
            product1.CategoryId = 2; //2 numara -> mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 230;
            product1.UnitsInStock = 25;

            Product product2 = new Product() {Id = 2, CategoryId = 5, 
                ProductName = "Bilgisayar", UnitPrice = 22000, UnitsInStock = 10 };

            productManager.Add(product1);
        }
    }
}
