using System;

namespace Task_14_2
{
    class Program
    {
        private static string _inputString = "Hello, guys!";
        static void Main(string[] args)
        {
            string result;
            result = _inputString.TrimString(0, 5);
            Console.WriteLine(result);
            result = _inputString.TrimString(5, 9);
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
