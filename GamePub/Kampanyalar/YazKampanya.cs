using GamePub.Abstract;
using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Kampanyalar
{
    public class YazKampanya : IKampanyaService
    {
        public double GetKampanya(Game game)
        {
            // %45 indirim uygulanmaktadır.
            return game.Price - (game.Price * 0.45);
        }
    }
}
