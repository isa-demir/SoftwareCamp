using GamePub.Abstract;
using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Concrete
{
    public class GameManager : IGameService
    {
        public Game AddGame(int id, string name, double price)
        {
            return new Game {Id = id, Name = name, Price = price };
        }
        public void DeleteGame(Game game)
        {
            Console.WriteLine(game.Name = " başarıyla silindi.");
        }
    }
}
