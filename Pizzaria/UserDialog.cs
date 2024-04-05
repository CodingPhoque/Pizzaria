using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria
{
    internal class UserDialog
    {
        PizzaDataLayer _pizzaDataLayer;
        public UserDialog(PizzaDataLayer pizzaDataLayer)
        {
            _pizzaDataLayer = pizzaDataLayer;
        }

        Pizza GetNewPizza()
        {
            Pizza pizzaItem = new Pizza();
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.WriteLine("|    Creating Pizza   |");
            Console.WriteLine("-----------------------");
            Console.WriteLine();
            Console.Write("Enter name: ");
            pizzaItem.Name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter ingredients: ");
            pizzaItem.Ingredients = Console.ReadLine();

            string input = "";
            Console.Write("Enter price: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.Price = Int32.Parse(input); 
            }
            catch (FormatException e)
            {
                Console.WriteLine($"False input '{input}' - Message: {e.Message}");
                throw;
            }

            input = "";
            Console.Write("Enter pizza number: ");
            try
            {
                input = Console.ReadLine();
                pizzaItem.Number = Int32.Parse(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine($"False input '{input}' - Message: {e.Message}");
                throw;
            }

            return pizzaItem;
        }
        int MainMenuChoice(List<string> menuItems)
        {
            Console.Clear();
            Console.WriteLine("----------------------------");
            Console.WriteLine("| Big Mammas Pizzaria Menu |");
            Console.WriteLine("----------------------------");
            Console.WriteLine();
            Console.WriteLine("Options:");
            foreach (string choice in menuItems)
            {
                Console.WriteLine(choice);
            }

            Console.Write("Enter option#: ");
            string input = Console.ReadKey().KeyChar.ToString();

            try
            {
                int result = Int32.Parse(input);
                return result;
            }

            catch (FormatException)
            {
                Console.WriteLine($" False input '{input}' must be a number");
            }
            return -1;
        }
        public void Run()
        {
            bool proceed = true;
            List<string> mainMenulist = new List<string>()
            {
                "1. Create new pizza",
                "2. Delete a pizza",
                "3. Update a pizza",
                "4. Search for a pizza",
                "5. Print pizza menu",
                "6. Exit",
            };

            while (proceed)
            {
                int MenuChoice = MainMenuChoice(mainMenulist);
                Console.WriteLine();
                switch (MenuChoice)
                {
                    case 1:
                        try
                        {
                            Pizza pizza = GetNewPizza();
                            _pizzaDataLayer.Create(pizza);
                            Console.WriteLine($"You created: {pizza}");
                        }
                        catch (Exception)
                        {
                            Console.WriteLine($"No pizza created");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 2:
                        // Delete a pizza
                        Console.Write("Enter the name of the pizza to delete: ");
                        string deleteName = Console.ReadLine();
                        try
                        {
                            // Define a predicate function to search for pizzas by name
                            Func<Pizza, bool> deletePredicate = pizza => pizza.Name.ToLower() == deleteName.ToLower();

                            // Delete the pizza matching the predicate
                            bool deleted = _pizzaDataLayer.DeletePizza(deletePredicate);

                            if (deleted)
                            {
                                Console.WriteLine("Pizza deleted successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Pizza not found.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input format");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;

                    case 3:
                        // Update a pizza
                        Console.Write("Enter the name of the pizza to update: ");
                        string updateName = Console.ReadLine();
                        try
                        {
                            // Define a predicate function to search for pizzas by name
                            Func<Pizza, bool> updatePredicate = pizza => pizza.Name.ToLower() == updateName.ToLower();

                            // Create a new Pizza object with updated information
                            Pizza updatedPizza = GetNewPizza();

                            // Update the pizza matching the predicate
                            bool updated = _pizzaDataLayer.UpdatePizza(updatePredicate, updatedPizza);

                            if (updated)
                            {
                                Console.WriteLine("Pizza updated successfully.");
                            }
                            else
                            {
                                Console.WriteLine("Pizza not found.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input format");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;

                    case 4:
                        // Search your pizza
                        Console.Write("Enter the name of the pizza: ");
                        string searchName = Console.ReadLine();
                        try
                        {
                            // Define a predicate function to search for pizzas by name
                            Func<Pizza, bool> predicate = pizza => pizza.Name.ToLower() == searchName.ToLower();

                            // Search for a pizza matching the predicate
                            Pizza foundPizza = _pizzaDataLayer.SearchPizza(predicate);

                            // Check if a pizza was found
                            if (foundPizza != null)
                            {
                                Console.WriteLine($"Found Pizza: {foundPizza}");
                            }
                            else
                            {
                                Console.WriteLine("Pizza not found.");
                            }
                        }
                        catch (FormatException)
                        {
                            Console.WriteLine("Invalid input format");
                        }
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 5:
                        _pizzaDataLayer.PrintMenu();
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                    case 6:
                        proceed = false;
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.Write("Hit any key to continue");
                        Console.ReadKey();
                        break;
                }
            }

        }
    }
}
