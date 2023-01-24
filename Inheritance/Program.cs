using System;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person[] peoples = new Person[]
            {
                new Student{FirstName = "İsa"},
                new Customer{FirstName = "Selver"},
            };

            foreach (var item in peoples)
            {
                Console.WriteLine(item.FirstName);
            }


        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
}
