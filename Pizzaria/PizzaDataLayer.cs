using System;
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
        
        public Pizza SearchPizza(Func<Pizza, bool> predicate)
        {
            Pizza pizza = _pizzas.FirstOrDefault(predicate);
            return pizza;
        }
       
        public bool DeletePizza(Func<Pizza, bool> predicate)
        {
            Pizza pizzaToRemove = _pizzas.FirstOrDefault(predicate);
            if (pizzaToRemove != null)
            {
                _pizzas.Remove(pizzaToRemove);
                return true; // Indicate successful deletion
            }
            return false; // Indicate pizza not found
        }

        public bool UpdatePizza(Func<Pizza, bool> predicate, Pizza newPizza)
        {
            Pizza pizzaToUpdate = _pizzas.FirstOrDefault(predicate);
            if (pizzaToUpdate != null)
            {
                // Update pizza properties
                pizzaToUpdate.Number = newPizza.Number;
                pizzaToUpdate.Name = newPizza.Name;
                pizzaToUpdate.Ingredients = newPizza.Ingredients;
                pizzaToUpdate.Price = newPizza.Price;
            
                return true; // Indicate successful update
            }
            return false; // Indicate pizza not found
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
