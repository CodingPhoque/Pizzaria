using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class CustomerDataLayer
    {
        List<Customer> _customer;

        public CustomerDataLayer()
        {
            _customer = new List<Customer>();
        }

        public void Create(Customer c)
        {
            _customer.Add(c);
        }

        public void PrintMenu()
        {
            foreach (Customer c in _customer)
            {
                Console.WriteLine(c);
            }

        }
    }
}
