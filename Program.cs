using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{
    class Program
    {
        static void printArray(int[] arr)
        {
            foreach (var element in arr)
                Console.Write(element + " ");
        }

        static void printArray(double[] arr)
        {
            Console.WriteLine();
            foreach (var element in arr)
                Console.Write(element + " ");
        }

        static void printArray(char[] arr)
        {
            Console.WriteLine();
            foreach (var element in arr)
                Console.Write(element + " ");
        }

        static void Main(string[] args)
        {
            int[] intArray = { 1, 23, 45, 21, 48, 4 };
            double[] doubleArray = { 1, 2.3, 4.5, 2.1, 4.8, 4.9 };
            char[] charArray = { 'A','b','c' };

            printArray(intArray);
            printArray(doubleArray);
            printArray(charArray);

            Console.Read();
        }        
    }
}
