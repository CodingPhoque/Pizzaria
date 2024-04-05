using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public double PhoneNumber { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}, Phone number: {PhoneNumber}";
        }
    }
}
