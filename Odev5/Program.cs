using System;

namespace Odev5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.FirstName = "İsa";
            customer.LastName = "Demir";

            Console.WriteLine(customer.FirstName);
        }
    }
}
