using System;

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
            Console.WriteLine("Changed array: ");
            foreach (var item in differentElemsArr)
            {
                Console.WriteLine(item);
            }
        }

        private static void arrayPrintFindMax()
        {
        }

        private static void boxingUnboxing()
        {
        }
    }
}
