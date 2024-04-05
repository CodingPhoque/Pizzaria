﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class PizzaDataLayer
    {
        List<Pizza> _pizzas;

        public PizzaDataLayer()
        {
            _pizzas = new List<Pizza>();
        }

        public void Create(Pizza p)
        {
            _pizzas.Add(p);
        }

        public void PrintMenu()
        {
            foreach (Pizza p in _pizzas)
            {
                Console.WriteLine(p);
            }

        }
        
    }
}
