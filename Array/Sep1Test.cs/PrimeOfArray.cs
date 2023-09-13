using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class PrimeOfArray
    { // Mock Q.7 Print prime numbers from an array.
        static void Main(string[] args)
        {
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
                    for (int i = 2; i < num; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    Console.WriteLine("Prime element " + num);
                }
            }
        }
    }
 } 