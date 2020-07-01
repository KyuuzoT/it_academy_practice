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
        private static int _indexer = 0;

        static void Main(string[] args)
        {
            IShape[] shapes = CreateArrayOfShapes();
            PrintArray(shapes);
            Console.ReadKey();
        }

        private static IShape[] CreateArrayOfShapes()
        {
            IShape[] shapes = new IShape[_arraySize];

            do
            {
                Console.WriteLine("Choose the type of figure to add into array:");
                Console.WriteLine("1. Circle\n2. Triangle\n3. Rectangle");
                FillArrayOfShapes(shapes);
            } while (_indexer < shapes.Length);

            return shapes;
        }

        private static void FillArrayOfShapes(IShape[] shapes)
        {
            var choice = Console.ReadKey();
            Console.WriteLine();
            switch (choice.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Circle circle = CreateCircle();
                    shapes[_indexer] = circle;
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Triangle triangle = CreateTriangle();
                    shapes[_indexer] = triangle;
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Rectangle rectangle = CreateRectangle();
                    shapes[_indexer] = rectangle;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    return;
            }
            _indexer++;
        }

        private static Rectangle CreateRectangle()
        {
            Rectangle rectangle = new Rectangle();

            Console.WriteLine("Input sides of rectangle:");
            Console.WriteLine("Side x:");
            rectangle.XSide = InputFloat();
            Console.WriteLine("Side y:");
            rectangle.YSide = InputFloat();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSquare of rectangle: {rectangle.ShapeSquare()}\n");
            Console.ResetColor();

            return rectangle;
        }       

        private static Triangle CreateTriangle()
        {
            Triangle triangle = new Triangle();

            Console.WriteLine("Input sides of triangle:");
            Console.WriteLine("Side a:");
            triangle.ASide = InputFloat();
            Console.WriteLine("Side b:");
            triangle.BSide = InputFloat();
            Console.WriteLine("Side c:");
            triangle.CSide = InputFloat();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSquare of triangle: {triangle.ShapeSquare()}\n");
            Console.ResetColor();

            return triangle;
        }

        private static Circle CreateCircle()
        {
            Circle circle = new Circle();
            Console.WriteLine("Input radius of circle:");
            circle.Radius = InputFloat();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\nSquare of circle: {circle.ShapeSquare()}\n");
            Console.ResetColor();

            return circle;
        }

        private static float InputFloat()
        {
            float value;
            while (true)
            {
                if (!float.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    return value;
                }
            }
        }

        private static void PrintArray(IShape[] shapes)
        {
            foreach (var item in shapes)
            {
                Console.WriteLine(item.GetShapeInfo());
            }
        }
    }
}
