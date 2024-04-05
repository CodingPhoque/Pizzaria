namespace Pizzaria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            Console.WriteLine("Welcome to Big Mamma Pizzaria");
            Console.WriteLine();
            Console.WriteLine("MenuCatalog");
            store.Test();
            Console.Write("Hit any key to continue with user dialog");
            Console.ReadKey();
            store.Run();
        }
    }
}
