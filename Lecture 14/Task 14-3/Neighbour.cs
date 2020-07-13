using System;
using System.Collections.Generic;
using System.Text;

namespace Task_14_3
{
    class Neighbour
    {
        private long _phoneNumber;
        private short _flatNumber;
        private string _fullName;     

        public long PhoneNumber
        {
            get => _phoneNumber;
            set
            {
                if(value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Value cannot be less then 0");
                    Console.ResetColor();
                }
                else
                {
                    _phoneNumber = value;
                }
            }
        }

        public short FlatNumber
        {
            get => _flatNumber;
            set
            {
                if (value < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Value cannot be less then 0");
                    Console.ResetColor();
                }
                else
                {
                    _flatNumber = value;
                }
            }
        }

        public string FullName
        {
            get => _fullName;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Value cannot be empty");
                    Console.ResetColor();
                }
                else
                {
                    _fullName = value;
                }
            }
        }

        public string GetNeighbourInfo()
        {
            return $"Your neighbour {_fullName} from appartment {_flatNumber} with tel. number {_phoneNumber}";
        }
    }
}
