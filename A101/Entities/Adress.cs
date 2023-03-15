using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Entities
{
    public class Adress
    {
       private Dictionary<byte, string> _cities= new Dictionary<byte, string>() {

            {1, "Adana" },
            {2, "Antalya" },
            {34, "İstanbul" },
            {52, "Ordu" },
            {42, "Konya" }
        };

        string getCity(byte id)
        {
            if (_cities.ContainsKey(id))
            {
                return _cities[id];
            }
            else
            {
                return null;
            }
        }
    }
}
