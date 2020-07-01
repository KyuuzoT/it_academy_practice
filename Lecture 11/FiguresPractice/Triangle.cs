using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresPractice
{
    class Triangle : IShape
    {
        private float _aSide;
        private float _bSide;
        private float _cSide;

        public float ASide
        {
            get => _aSide;
            set
            {
                if (value > 0)
                {
                    _aSide = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Side of triangle can not be less than zero");
                    Console.ResetColor();
                }
            }
        }

        public float BSide
        {
            get => _bSide;
            set
            {
                if (value > 0)
                {
                    _bSide = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Side of triangle can not be less than zero");
                    Console.ResetColor();
                }
            }
        }

        public float CSide
        {
            get => _cSide;
            set
            {
                if (value > 0)
                {
                    _cSide = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Side of triangle can not be less than zero");
                    Console.ResetColor();
                }
            }
        }

        public const string SHAPE_NAME = "Triangle";

        public float ShapeSquare()
        {
            float halfPerimeter = CalculateHalfPerimeter();
            return (float)(Math.Sqrt((halfPerimeter * (halfPerimeter - _aSide) * (halfPerimeter - _bSide) * (halfPerimeter - _cSide))));
        }

        private float CalculateHalfPerimeter()
        {
            return (_aSide + _bSide + _cSide)/2;
        }

        public string GetShapeInfo()
        {
            return $"This is {SHAPE_NAME}. CLR Type is {this.GetType()}. Square is {this.ShapeSquare()} with sides:" +
                $"\nSide A = {_aSide}\nSide B = {_bSide}\nSide C = {_cSide}";
        }
    }
}
