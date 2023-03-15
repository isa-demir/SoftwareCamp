using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Absract
{
    public interface IPersonCheckService
    {
        bool CheckIfRealPerson(Person person);
    }
}
