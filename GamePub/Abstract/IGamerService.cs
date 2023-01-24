using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Abstract
{
    public interface IGamerService
    {
        Gamer Register(int id, string firstName, string lastName, string nationalityId);
        void Delete(Gamer gamer);
    }
}
