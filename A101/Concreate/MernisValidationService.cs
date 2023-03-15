using A101.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Concreate
{
    public class MernisValidationService : IPersonCheckService
    {
        public bool CheckIfRealPerson(Person person)
        {
            if (person.PhoneNumber == "05537391552")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
