using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Abstract
{
    public interface IShoppingService
    {
        void Buy(Gamer gamer, Game game);
        void Remove(Gamer gamer, Game game);
    }
}
