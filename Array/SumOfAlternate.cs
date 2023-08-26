using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SumOfAlternate
    {
       // Display sum of alternate elements in array.
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = 0;
            for(int i = 0; i < arr.Length; i+=2)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine("The sum of alternate elements is " +sum);

        }


    }
}
