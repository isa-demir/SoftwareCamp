using GamePub.Abstract;
using GamePub.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Concrete
{
    public class GamerManager : IGamerService
    {
        IGamerCheckService _gamerCheckService;

        public GamerManager(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }

        public Gamer Register(int id, string firstName, string lastName, string nationalityId)
        {
            Gamer gamer;
            gamer = new Gamer { Id = id, FirstName = firstName, LastName = lastName, NationalityId = nationalityId };
            if (_gamerCheckService.checkIfRealPerson(gamer))
            {
                Console.WriteLine(gamer.FirstName + " başarıyla kayıt edildi.");
                return gamer;
            }
            else
            {
                Console.WriteLine("Kimlik doğrulaması başarısız.");
                return null;
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Gamer deleted.");
        }
    }
}
