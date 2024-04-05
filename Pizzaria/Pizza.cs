using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Pizza
    {
        public int Number { get; set; }
        public string Name { get; set; }
        public string Ingredients { get; set; }
        public double Price { get; set; }

        public override string ToString()
        {
            return $"Number: {Number}, Name: {Name}, Ingredients: {Ingredients}, Price: {Price}";
        }
    }
}
