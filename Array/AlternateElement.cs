using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class AlternateElement
    {   // Display alternate elements from an array.
        static void Main(string[] args)
        {
            int[] numbers = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
            for(int i=0;i<numbers.Length; i += 2)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
