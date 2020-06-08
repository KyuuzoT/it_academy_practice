using System;

namespace GoodDay
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo again;
            do
            {
                Greeting greeting = new Greeting();
                Console.WriteLine("Again (Y,N)?");
                again = Console.ReadKey();
                Console.WriteLine();
            } while (again.Key != ConsoleKey.N);
        }
    }
}
