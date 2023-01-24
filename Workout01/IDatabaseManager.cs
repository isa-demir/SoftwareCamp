using System;
using System.Collections.Generic;
using System.Text;

namespace Workout01
{
    internal interface IDatabaseManager
    {
        void Add(string name);
        void Update(string name);
    }

    class SqlDatabaseManager : IDatabaseManager
    {
        public void Add(string name)
        {
            Console.WriteLine(name + " sql'e eklendi!");
        }

        public void Update(string name)
        {
            Console.WriteLine(name + " güncellendi! (SQL)");
        }
    }
    class FirestoreManager : IDatabaseManager
    {
        public void Add(string name)
        {
            Console.WriteLine(name + " firestore'a eklendi!");
        }

        public void Update(string name)
        {
            Console.WriteLine(name + " güncellendi! (Firestore)");
        }
    }

    class OracleDatabaseManager : IDatabaseManager
    {
        public void Add(string name)
        {
            Console.WriteLine(name + " oracle'a eklendi!");
        }

        public void Update(string name)
        {
            Console.WriteLine(name + " oracle'da güncellendi!");
        }
    }

}
