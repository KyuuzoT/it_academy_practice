using System;
using System.Linq;

namespace Lecture6
{
    class Program
    {
        static void Main(string[] args)
        {
            emptyArray();
            arrayWithThreeDifferentElems();
            arrayPrintFindMax();
            boxingUnboxing();

            Console.ReadKey();
        }

        private static void emptyArray()
        {
            int[] array = new int[0];//Array contains zero elements - is it empty?
        }

        private static void arrayWithThreeDifferentElems()
        {
            object[] differentElemsArr = new object[3] { 32, 'A', "Hello" };
            Console.WriteLine("Original array: ");
            foreach (var item in differentElemsArr)
            {
                Console.WriteLine(item);
            }
            int temp = (int)differentElemsArr[0] + 10;
            differentElemsArr[0] = temp;
            string tempStr = differentElemsArr[2] + ", guys!";
            differentElemsArr[2] = tempStr;
            Console.WriteLine("\nChanged array: ");
            foreach (var item in differentElemsArr)
            {
                Console.WriteLine(item);
            }
        }

        private static void arrayPrintFindMax()
        {
            Console.WriteLine("\n");
            int[] randomArray = new int[13];
            Random rnd = new Random();
            for (int i = 0; i < randomArray.Length; i++)
            {
                randomArray[i] = rnd.Next(1, 100);
            }

            foreach (int number in randomArray)
            {
                Console.Write($"{number} ");
            }
            int maxValue = randomArray.OrderByDescending(x => x).First();
            Console.WriteLine($"\nMax element: {maxValue}");
        }

        private static void boxingUnboxing()
        {
            short shortVal = 1;
            object objValBox = shortVal;
            Console.WriteLine($"Boxing: {objValBox}, type:{objValBox.GetType()}");
            sbyte sbValUnbox = (sbyte)(short)objValBox;//System.InvalidCastException?!

            Console.WriteLine($"UnBoxing: {sbValUnbox}, type:{sbValUnbox.GetType()}");
        }
    }
}
