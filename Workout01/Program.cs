using System;
using System.Collections.Generic;

namespace Workout01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<User> list = new List<User> {
                new NormalUser{Id = 1, Name = "İsa"},
                new PremiumUser{Id = 2, Name = "Selver"},
                new Admin(),
            };

            List<IDatabaseManager> databases= new List<IDatabaseManager> {
                new SqlDatabaseManager(),
                new FirestoreManager(),
                new OracleDatabaseManager(),
            };

            UserManager userManager = new UserManager();
            

            foreach (var user in list)
            {
                userManager.CreateUser(user, databases[0]);
            }

            Console.WriteLine("\n--------------------------------\n");
            foreach (var user in list)
            {
                userManager.UpgradeUser(user, databases[2]);
            }
        }
    }
}
