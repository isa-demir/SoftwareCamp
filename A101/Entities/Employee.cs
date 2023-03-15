using A101.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Entities
{
    public class Employee : Person
    {
        public string NationalityID { get; set; }
        public double Pay { get; set; }
        public string Department { get; set; }
    }
}
