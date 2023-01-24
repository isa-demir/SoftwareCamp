using System;
using System.Collections.Generic;
using System.Text;

namespace Workout01
{
    internal interface IUserManager
    {
        void CreateUser(User user,IDatabaseManager db);
        void UpgradeUser(User user, IDatabaseManager db);

    }

    class UserManager : IUserManager
    {
        public void CreateUser(User user, IDatabaseManager db)
        {
            Console.Write("Kullanıcı oluşturuldu! - ");
            db.Add(user.Name);
        }

        public void UpgradeUser(User user, IDatabaseManager db)
        {
            if (!(user is Admin))
            {
                Console.WriteLine(user.Name + " " + user.BuyPremium());
                if (user.Id != 2)
                {
                    db.Update(user.UserColor);
                }
            }
            else
            {
                Console.WriteLine(user.BuyPremium());
            }
            
        }
    }

}
