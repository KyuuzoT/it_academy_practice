using System;

namespace Task_14_1
{
    class Program
    {
        private static int rndMin = 1;
        private static int rndMax = 4;
        private static int _arraySize = 10;
        private static Rectangle[] _rectangles;

        static void Main(string[] args)
        {
            _rectangles = AddRectanglesToArray();
            PrintArray(_rectangles);
            FindDuplicates(_rectangles);

            Console.ReadKey();
        }

        private static Rectangle[] AddRectanglesToArray()
        {
            Rectangle[] rects = new Rectangle[_arraySize];
            Rectangle item;

            for (int i = 0; i < rects.Length; i++)
            {
                item = new Rectangle();
                item.Width = new Random().Next(rndMin, rndMax);
                item.Height = new Random().Next(rndMin, rndMax);
                rects[i] = item;
            }

            return rects;
        }

        private static void FindDuplicates(Rectangle[] rectangles)
        {
            int dupsQuantity = 0;
            foreach (var item in rectangles)
            {
                if(item.Height.Equals(rectangles[0].Height) && item.Width.Equals(rectangles[0].Width))
                {
                    Console.WriteLine("Duplicate found!");
                    dupsQuantity++;
                }
            }

            Console.WriteLine($"Quantity of duplicates: {dupsQuantity}");
        }

        private static void PrintArray(Rectangle[] rectangles)
        {
            int indexer = 0;
            foreach (var item in rectangles)
            {
                Console.WriteLine($"{indexer}. {item.GetRectangleInfo()}");
                indexer++;
            }
        }
    }
}
