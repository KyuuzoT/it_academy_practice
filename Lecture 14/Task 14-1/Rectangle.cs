using System;
using System.Collections.Generic;
using System.Text;

namespace Task_14_1
{
    struct Rectangle
    {
        private int _width;
        private int _height;

        public int Width
        {
            get => _width;
            set
            {
                addValue(value, out _width);
            }
        }

        public int Height
        {
            get => _height;
            set
            {
                addValue(value, out _height);
            }
        }

        private void addValue(int inputValue, out int outputValue)
        {
            if (inputValue > 0)
            {
                outputValue = inputValue;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Value cannot be less then 0");
                Console.ResetColor();
                outputValue = 0;
            }
        }

        public string GetRectangleInfo()
        {
            return $"Rectangle with height: {_height} and width {_width}.";
        }
    }
}
