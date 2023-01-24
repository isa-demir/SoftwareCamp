using System;
using System.Collections.Generic;
using System.Text;

namespace Workout01
{
    internal abstract class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual string UserColor { get; set; }

        public virtual string BuyPremium()
        {
            return "Zaten premium kullanıcısınız.";
        }
    }

    class NormalUser : User
    {

        public override string UserColor { get { return "yellow"; } set { UserColor = "yellow"; } }
        public override string BuyPremium()
        {
            return "Satın alım başarılı";
        }
    }

    class PremiumUser : User
    {
        public override string UserColor { get { return "purple"; } set { UserColor = "purple"; } }
    }

    class Admin : User
    {
        public Admin()
        {
            this.Id = 0;
            this.Name= "admin";
            this.UserColor = "RED";
        }
        public override string BuyPremium()
        {
            return "Admin satın alım yapamaz!";
        }
    }

}
