using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class AcceptValueAndPrint
    {
        static void Main(string[] args)
        {
            // declaration of array for int data type
            //data type [] variale name =new data type[size];

            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Print all the values");

            for (int i = 0; i < numbers.Length; i++) // to assume i is your index value
            {
                Console.WriteLine($"numbers[{i}]= {numbers[i]}");
            }


        }
    }
}
