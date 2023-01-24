using GamePub.Abstract;
using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Kampanyalar
{
    public class OcakKampanya : IKampanyaService
    {
        public double GetKampanya(Game game)
        {
            //%25 indirim
            return (game.Price - (game.Price * 0.25));
        }
    }
}
