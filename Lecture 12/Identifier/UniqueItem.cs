using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifier
{
    class UniqueItem
    {
        private static int _id = 0;

        public static int ID
        {
            get => _id;
            set
            {
                if(_id == value)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("ID already exists");
                    Console.ResetColor();
                }
                else
                {
                    _id = value;
                }
            }
        }

        public string GetID
        {
            get => $"{this} ID: {_id}";
        }

        public UniqueItem()
        {
            _id++;
            PrintObjectInfo();
        }

        private void PrintObjectInfo()
        {
            Console.WriteLine(GetObjectInfo());
        }

        private string GetObjectInfo()
        {
            return $"Object of type: {this.GetType()} created with ID:{_id}";
        }
    }
}
