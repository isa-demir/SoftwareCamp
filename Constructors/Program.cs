using System;

namespace Constructors
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer{ Id = 1 ,firstName = "İsa", lastName = "Demir", city = "Ordu"};
            Customer customer2 = new Customer(2, "Selver", "Yavuz", "Konya");

            BilgiYaz(customer1);
            Console.WriteLine("----------");
            BilgiYaz(customer2);

        }
        public static void BilgiYaz(Customer customer)
        {
            Console.WriteLine("   Id: " + customer.Id);
            Console.WriteLine("   Ad: " + customer.firstName);
            Console.WriteLine("Soyad: " + customer.lastName);
            Console.WriteLine("Şehir: " + customer.city);

        }
    }
    class Customer
    {
        //default constructor
        public Customer()
        {

        }
        public Customer(int id, string firstName, string lastName, string city)
        {
            this.Id = id;
            this.firstName= firstName;
            this.lastName= lastName;
            this.city= city;
        }
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string city { get; set; }

    }
}
