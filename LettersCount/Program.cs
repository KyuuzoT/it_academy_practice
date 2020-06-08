using System;

namespace LettersCount
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo again;
            do
            {
                CountLettersInWord();
                Console.WriteLine("Again (Y,N)?");
                again = Console.ReadKey();
                Console.WriteLine();
            } while (again.Key != ConsoleKey.N);
            Console.ReadKey();
        }

        private static void CountLettersInWord()
        {
            Console.WriteLine("Input any word: ");
            string input = Console.ReadLine();
            int lettersCount = 0;
            foreach (var s in input)
            {
                if (s == 'a' || s.Equals('A'))
                {
                    lettersCount++;
                }
            }

            Console.WriteLine($"Number of letters in word {input} equals to {lettersCount}");
        }
    }
}
