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
                FillArrayOfShapes(shapes, i);
            }
        }

        private static void FillArrayOfShapes(IShape[] shapes, int i)
        {
            var choice = Console.Read();
            switch (choice)
            {
                case 1:
                    Circle circle = CreateCircle();
                    shapes[i] = circle;
                    break;
                case 2:
                    Triangle triangle = CreateTriangle();
                    shapes[i] = triangle;
                    break;
                case 3:
                    Rectangle rectangle = CreateRectangle();
                    shapes[i] = rectangle;
                    break;
                default:
                    Console.WriteLine("Invalid input!");
                    break;
            }
        }

        private static Rectangle CreateRectangle()
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Input sides of rectangle:");
            Console.WriteLine("Side x:");
            rectangle.XSide = float.Parse(Console.ReadLine());
            Console.WriteLine("Side y:");
            rectangle.YSide = float.Parse(Console.ReadLine());
            return rectangle;
        }

        private static Triangle CreateTriangle()
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Input sides of triangle:");
            Console.WriteLine("Side a:");
            triangle.ASide = float.Parse(Console.ReadLine());
            Console.WriteLine("Side b:");
            triangle.BSide = float.Parse(Console.ReadLine());
            Console.WriteLine("Side c:");
            triangle.CSide = float.Parse(Console.ReadLine());
            return triangle;
        }

        private static Circle CreateCircle()
        {
            Circle circle = new Circle();
            Console.WriteLine("Input radius of circle:");
            circle.Radius = float.Parse(Console.ReadLine());
            return circle;
        }
    }
}
