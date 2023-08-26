using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class EvenNumber
    {
        // WAP to declare an array of 10 size, accept the value & print only even numbers.

        static void Main(string[] args)
        {
            int[] num = new int[10];
            for(int i=0;i<num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i = 0; i < num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    Console.WriteLine($"{num[i]} is even");

                }
            }
        }
    }
}
