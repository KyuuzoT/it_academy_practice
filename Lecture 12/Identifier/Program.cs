using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Identifier
{
    class Program
    {
        private static int _newID = 100;

        static void Main(string[] args)
        {
            UniqueItem item1 = new UniqueItem();
            Console.WriteLine(item1.GetID);
            UniqueItem item2 = new UniqueItem();
            UniqueItem item3 = new UniqueItem();

            UniqueItem.ID = _newID;
            UniqueItem item4 = new UniqueItem();
            Console.WriteLine(item4.GetID);
            UniqueItem item5 = new UniqueItem();
            UniqueItem item6 = new UniqueItem();

            Console.ReadKey();
        }
    }
}
