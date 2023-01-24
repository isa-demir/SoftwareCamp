using GamePub.Abstract;
using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Concrete
{
    public class ShoppingManager : IShoppingService
    {
        public void Buy(Gamer gamer,Game game)
        {
            Console.WriteLine("User : " + gamer.FirstName + " -> " + game.Name + " buying successfully.");
            gamer.MyGames.Add(game);
        }

        public void Remove(Gamer gamer, Game game)
        {
            Console.WriteLine("User : " + gamer.FirstName + " -> " + game.Name + " removed.");
        }
    }
}
