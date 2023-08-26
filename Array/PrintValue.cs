using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class PrintValue
    {
        static void Main(string[] args)
        {
            // declaration of array for int data type.
            //data type [] variale name =new data type[size];

            int[] numbers = new int[10] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };

            // how to access single element - using index
            Console.WriteLine(numbers[4]);

            Console.WriteLine(numbers[0]);

            numbers[7] = 800;
            Console.WriteLine(numbers[7]);

            Console.WriteLine("Print all the values");

            for (int i = 0; i < numbers.Length; i++) // to assume i is your index value
            {
                Console.WriteLine($"numbers[{i}]= {numbers[i]}");

            }
        }
    }
}