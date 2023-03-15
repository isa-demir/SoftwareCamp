using A101.Absract;
using System;
using System.Collections.Generic;
using System.Text;

namespace A101.Entities
{
    public class Customer : Person
    {
        public string CustomerAppNumber { get; set; }
        public double Wallet { get; set; }
    }
}
