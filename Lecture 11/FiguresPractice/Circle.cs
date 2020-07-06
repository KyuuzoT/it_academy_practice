using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresPractice
{
    class Circle : IShape
    {
        private float _radius;

        public const string SHAPE_NAME = "Circle";

        public float Radius
        {
            get => _radius;
            set
            {
                if(value > 0)
                {
                    _radius = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Radius of circle can not be less than zero");
                    Console.ResetColor();
                }
            }
        }

        public float ShapeSquare()
        {
            return (float)(Math.PI * _radius * _radius);
        }

        public string GetShapeInfo()
        {
            return $"This is {SHAPE_NAME}. CLR Type is {this.GetType()}. Square is {this.ShapeSquare()} with radius:" +
                $"\nRadius = {_radius}";
        }
    }
}
