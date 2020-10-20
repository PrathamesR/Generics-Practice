using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsPractice
{


    public class PrintArray<dataType>
    {
        private dataType[] arr;

        public PrintArray(dataType[] arr)
        {
            this.arr = arr;
        }

        public void PrintArr()
        {
            Console.WriteLine();
            foreach (dataType elem in arr)
                Console.Write(elem+", ");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] intArray = { 1, 23, 45, 21, 48, 4 };
            double[] doubleArray = { 1, 2.3, 4.5, 2.1, 4.8, 4.9 };
            char[] charArray = { 'A','b','c' };

            new PrintArray<int>(intArray).PrintArr();
            new PrintArray<double>(doubleArray).PrintArr();
            new PrintArray<char>(charArray).PrintArr();

            Console.Read();
        }        
    }
}
