using GamePub.Abstract;
using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Adapters
{
    public class MernisCheckAdapter : IGamerCheckService
    {
        public bool checkIfRealPerson(Gamer gamer)
        {
            if (gamer.FirstName == "İsa")
            {
                return true;
            }
            return false;
        }
    }
}
