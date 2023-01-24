using System;

namespace InterfacesGoodProgramer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IPersonManager customerManager = new CustomerManager();
            IPersonManager personManager = new PersonManager();

            ProjectManager projectManager = new ProjectManager();

            projectManager.Add(customerManager);
            projectManager.Add(customerManager);
            projectManager.Remove(personManager);
        }
    }

    interface IPersonManager
    {
        void Add();
        void Remove();
    }

    class PersonManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Person added.");
        }

        public void Remove()
        {
            Console.WriteLine("Person removed.");
        }
    }
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Customer added.");
        }

        public void Remove()
        {
            Console.WriteLine("Customer removed.");
        }
    }

    class ProjectManager
    {
        public void Add(IPersonManager person)
        {
            person.Add();
        }
        public void Remove(IPersonManager person)
        {
            person.Remove();
        }
    }
}
