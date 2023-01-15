using System;

namespace MyBankSimulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customerManager = new CustomerManager();

            var c1 = new Customer() 
            {
                Id= 1, FirstName= "İsa", LastName = "Demir", Address = "İstanbul"
            };
            var c2 = new Customer()
            {
                Id = 2,
                FirstName = "Selver",
                LastName = "Yavuz",
                Address = "Konya"
            };
            var c3 = new Customer()
            {
                Id = 1,
                FirstName = "Züleyha",
                LastName = "Yalçın",
                Address = "Eskişehir"
            };

            Customer[] customers = { c1, c2, c3 };
            foreach (var c in customers)
            {
                customerManager.Add(c);
            }
            customerManager.Remove(c3);

            foreach (var item in customers)
            {
                customerManager.ShowCustomerInfos(item);
            }
        }
    }
}
