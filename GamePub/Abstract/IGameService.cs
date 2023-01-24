using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Abstract
{
    internal interface IGameService
    {
        Game AddGame(int id, string name, double price);
        void DeleteGame(Game game);
    }
}
