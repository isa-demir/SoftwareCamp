using System;
using System.Collections.Generic;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<DataAccess> databases = new List<DataAccess> {
                new SqlDataAccess(),
                new MySqlDataAccess(),
           };

            foreach (var db in databases)
            {
                Console.WriteLine(db.LoadConnectionString("jes"));
                db.LoadData();
                Console.WriteLine();
            }

        }
    }

    abstract class DataAccess
    {
        public virtual string LoadConnectionString(string name)
        {
            Console.WriteLine("Load successful!");
            return "load connection string";
        }

        public abstract void SaveData();
        public abstract void LoadData();
    }

    class SqlDataAccess : DataAccess
    {
        public override string LoadConnectionString(string name)
        {
            string output = base.LoadConnectionString(name);
            output += " (from Sql)";
            return output;
        }
        public override void LoadData()
        {
            Console.WriteLine("Sql load data");
        }

        public override void SaveData()
        {
            Console.WriteLine("Sql save data");
        }
    }

    class MySqlDataAccess : DataAccess
    {
        public override void LoadData()
        {
            Console.WriteLine("MySql load data");
        }

        public override void SaveData()
        {
            Console.WriteLine("MySql save data");
        }
    }

}
