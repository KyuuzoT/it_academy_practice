using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresPractice
{
    class Program
    {
        private static int _arraySize = 5;
        static void Main(string[] args)
        {
            
            Console.WriteLine("Choose the type of figure to add into array:");
            Console.WriteLine("1. Circle\n2. Triangle\n 3. Rectangle");

            CreateArrayOfShapes();

            Console.ReadKey();
        }

        private static void CreateArrayOfShapes()
        {
            IShape[] shapes = new IShape[_arraySize];
            for (int i = 0; i < shapes.Length; i++)
            {
                Console.WriteLine("Choose the type of figure to add into array:");
                Console.WriteLine("1. Circle\n2. Triangle\n 3. Rectangle");
                var choice = Console.Read();
                switch (choice)
                {
                    case 1:
                        Circle circle = new Circle;
                        Console.WriteLine("Input radius of circle:");
                        circle.Radius = float.Parse(Console.ReadLine());
                        shapes[i] = circle;
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    default:
                        Console.WriteLine("Invalid input!");
                        break;
                }
            }
        }
    }
}
