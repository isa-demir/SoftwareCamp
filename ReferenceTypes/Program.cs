using System;

namespace ReferenceTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var person1 = new Person();
            var person2 = new Person();

            person1.firstName = "İsa";
            person2 = person1;
            person1.firstName = "Selver";
            Console.WriteLine(person2.firstName);

            var customer = new Customer();
            customer.firstName = "Veli";
            customer.CreditCardNumber = "1234567890";

            var employee = new Employee();
            employee.firstName = "Selim";

            Person person3 = customer;
            customer.firstName = "Aziz";
            Console.WriteLine(person3.firstName); //Aziz
            //Eğer parantezler içine almaz isek creditcardnumber'a ulaşamayız.
            //Bu işleme boxing(kutulama) işlemi denir.
            Console.WriteLine(((Customer)person3).CreditCardNumber);
            Console.WriteLine("-----------------------------------");
            var personManager = new PersonManager();

            personManager.Add(person1);
            personManager.Add(customer);
            personManager.Add(employee);


        }
    }

    class Person
    {
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
    }
    //Müşteri
    class Customer : Person
    {
        public string CreditCardNumber { get; set; }
    }
    //Çalışan
    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        public void Add(Person person) 
        {
            Console.WriteLine(person.firstName + " eklendi.");
        }
    }
}
