using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Absract
{
    public abstract class BaseManager
    {
        IPersonCheckService _personCheckService;
        public BaseManager(IPersonCheckService personCheckService)
        {
            _personCheckService = personCheckService;
        }
        
        protected bool CheckIfRealPerson(Person person)
        {
            return _personCheckService.CheckIfRealPerson(person);
        }
    }
}
