using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresPractice
{
    class Rectangle : IShape
    {
        private float _xSide;
        private float _ySide;

        public const string SHAPE_NAME = "Rectangle";

        public float XSide
        {
            get => _xSide;
            set
            {
                if(value > 0)
                {
                    _xSide = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Side of rectangle can not be less than zero");
                    Console.ResetColor();
                }
            }
        }

        public float YSide
        {
            get => _ySide;
            set
            {
                if(value > 0)
                {
                    _ySide = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Side of rectangle can not be less than zero");
                    Console.ResetColor();
                }
            }
        }

        public float ShapeSquare()
        {
            return _xSide * _ySide;
        }

        public string GetShapeInfo()
        {
            return $"This is {SHAPE_NAME}. CLR Type is {this.GetType()}. Square is {this.ShapeSquare()} with sides:" +
                $"\nSide X = {_xSide}\nSide Y = {_ySide}";
        }
    }
}
