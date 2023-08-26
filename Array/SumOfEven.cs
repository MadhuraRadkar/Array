using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SumOfEven
    {
        static void Main(string[] args)
        {  // WAP to create int type of array and calculate sum of even  element from the array.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            int sum = 0;
            foreach (int num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum = sum + num;
                }
            }
            Console.WriteLine("The sum of even elements is " + sum);
        }
    }
}
