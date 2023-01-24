using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Abstract
{
    public interface IGamerCheckService
    {
        bool checkIfRealPerson(Gamer gamer);
    }
}
