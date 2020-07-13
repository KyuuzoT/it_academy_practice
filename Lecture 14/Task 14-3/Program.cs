using System;
using System.Collections.Generic;

namespace Task_14_3
{
    class Program
    {
        private static int _flatRndMin = 1;
        private static int _flatRndMax = 25;
        private static int _phoneRndMin = 8800555;
        private static int _phoneRndMax = int.MaxValue;
        private static int _quantityOfNeighbours = 20;

        static void Main(string[] args)
        {
            IList<Neighbour> floorNeighbours = new List<Neighbour>();
            AddFakeNeighboursInList(floorNeighbours);
            PrintList(floorNeighbours);
            FindNeighbourWithExactFlat(floorNeighbours);

            Console.ReadKey();
        }

        private static void AddFakeNeighboursInList(IList<Neighbour> floorNeighbours)
        {
            Neighbour neighbour;
            for (int i = 0; i < _quantityOfNeighbours; i++)
            {
                neighbour = new Neighbour();
                neighbour.FlatNumber = (short)(new Random().Next(_flatRndMin, _flatRndMax));
                neighbour.PhoneNumber = new Random().Next(_phoneRndMin, _phoneRndMax);
                neighbour.FullName = Char.ConvertFromUtf32(new Random().Next(0x0041, 0x007A));
                floorNeighbours.Add(neighbour);
            }
        }

        private static void FindNeighbourWithExactFlat(IList<Neighbour> floorNeighbours)
        {
            short flatNumber = 0;
            Console.WriteLine("Please, input flat number you wish to look up: ");
            if(short.TryParse(Console.ReadLine(), out flatNumber))
            {
                foreach (var item in floorNeighbours)
                {
                    if(item.FlatNumber.Equals(flatNumber))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Neighbour was found!");
                        Console.ResetColor();
                        Console.WriteLine(item.GetNeighbourInfo());
                    }
                }
            }
        }

        private static void PrintList(IList<Neighbour> floorNeighbours)
        {
            foreach (var item in floorNeighbours)
            {
                Console.WriteLine(item.GetNeighbourInfo());
            }
        }
    }
}
