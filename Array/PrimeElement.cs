using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class PrimeElement
    {
        static void Main(string[] args)
        {  // Display prime elements from an array.
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };
            foreach (int num in numbers)
            {
                bool isPrime = true;
                if (num <= 1)
                {
                    isPrime = false;
                }
                else
                {
                    for(int i = 2; i < num; i++)
                    {
                        if (num % 2 == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime element "+num);
                }
            }
        }
    }
}
