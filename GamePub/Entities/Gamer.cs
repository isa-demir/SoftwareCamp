using System;
using System.Collections.Generic;
using System.Text;

namespace GamePub.Entities
{
    public class Gamer
    {
        public Gamer()
        {
            this.MyGames = new List<Game>();
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalityId { get; set; }
        public List<Game> MyGames { get; set; }

    }
}
