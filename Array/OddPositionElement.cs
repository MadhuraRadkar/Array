using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class OddPositionElement
    {
        static void Main(string[] args)
        {  // WAC to create an array and display the elements at odd positions .

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            //int OddPosition = 1;
            //foreach (int num in numbers)
            //{
            //    if(OddPosition % 2 == 0)
            //    {
            //        Console.WriteLine("Element at odd position "+num);
            //    }
            //    OddPosition++;
            //}


            // using for loop.
            for(int i=0;i<numbers.Length; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine("Element at odd Position " + numbers[i]);
                }
            }
        }
    }
}
