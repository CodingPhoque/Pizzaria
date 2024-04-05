using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class Store
    {
        PizzaDataLayer pizzaDataLayer;

        public Store()
        {
            pizzaDataLayer = new PizzaDataLayer();
        }
        public void Test()
        {
            Pizza p = new Pizza() { Number = 1, Name = "Margherita", Ingredients = "Tomato & cheese", Price = 69 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 2, Name = "Vesuvio", Ingredients = "Tomato,cheese & ham", Price = 75 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 3, Name = "Capricciosa", Ingredients = "Tomato,cheese,ham & mushrooms", Price = 80 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 4, Name = "Calzone", Ingredients = "Baked pizza with tomato,cheese,ham & mushrooms", Price = 80 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 5, Name = "Quattro Stagioni", Ingredients = "Tomato,cheese,ham,mushrooms,shrimp & peppers", Price = 85 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 6, Name = "Marinara", Ingredients = "Tomato,cheese,shrimp,mussels & garlic", Price = 85 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 7, Name = "Vegetarian", Ingredients = "Tomato,cheese & vegetables", Price = 80 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 8, Name = "Italiana", Ingredients = "Tomato,cheese,onion & meat sauce", Price = 75 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 9, Name = "Gorgonzola", Ingredients = "Tomato,gorgonzola, onion & mushroom", Price = 85 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 10, Name = "Contadina", Ingredients = "Tomato,cheese,mushrooms & olives", Price = 75 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 11, Name = "Naples", Ingredients = "Tomato,cheese,anchovies & olives", Price = 79 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 12, Name = "Vichinga", Ingredients = "Tomato,cheese,ham,mushrooms,peppers,garlic & chili (strong)", Price = 80 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 13, Name = "Calzone Special", Ingredients = "(Not baked) tomato,cheese,shrimp,ham & meat sauce", Price = 80 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 14, Name = "Esotica", Ingredients = "Tomato,cheese,ham,shrimp & pineapple", Price = 80 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 15, Name = "Tonno", Ingredients = "Tomato,cheese,tuna & shrimp", Price = 85 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 16, Name = "Sardegna", Ingredients = "Tomato,cheese,cocktail sausages,bacon,onions & eggs", Price = 80 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 17, Name = "Romana", Ingredients = "Tomato,cheese,ham,bacon & onion", Price = 78 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 18, Name = "Sole", Ingredients = "Tomato,cheese,ham,bacon & eggs", Price = 78 };
            pizzaDataLayer.Create(p);

            p = new Pizza() { Number = 19, Name = "Big Mamma", Ingredients = "Tomato,gorgonzola,shrimp,asparagus & parma ham", Price = 90 };
            pizzaDataLayer.Create(p);

            pizzaDataLayer.PrintMenu();

            /*Console.WriteLine();
            int pizzaToBeFound = 2;
            Console.WriteLine($"Finding Pizza {pizzaToBeFound}");
            Pizza foundPizza = pizzaDataLayer.Read(pizzaToBeFound);
            Console.WriteLine(foundPizza);

            Console.WriteLine();
            string searchCriteria = "PIZZA#1";
            Console.WriteLine($"Finding Pizza starting with: {searchCriteria}");
            foundPizza = pizzaDataLayer.SearchPizza(searchCriteria);
            Console.WriteLine(foundPizza);

            Console.WriteLine();
            Console.WriteLine($"Updating Pizza #{foundPizza.Number}");
            foundPizza.Name += " (Updated)";
            pizzaDataLayer.Update(foundPizza);

            Console.WriteLine();
            pizzaDataLayer.PrintMenu();

            Console.WriteLine();
            int pizzaToBeDeleted = 2;
            Console.WriteLine($"Deleting pizza#: {pizzaToBeDeleted}");
            pizzaDataLayer.Delete(pizzaToBeDeleted);
            Console.WriteLine();
            pizzaDataLayer.PrintMenu();*/

        }

        public void Run()
        {
            new UserDialog(pizzaDataLayer).Run();
        }
    }
}
