using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SecondSmallest
    {   // 8. WAP to find the second smallest element in an array.
        static void Main(string[] args)
        {
            int[] arr = {12,45,15,20,4,5,2};
            int smallest = int.MaxValue;
            int secondSmallest =int.MaxValue;
            for(int i=0; i<arr.Length; i++)
            {
                if (arr[i] < smallest)
                {
                    secondSmallest = smallest;
                    smallest = arr[i];
                }
                if (arr[i] != smallest && arr[i] < secondSmallest)
                {
                    secondSmallest = arr[i];
                }
            }
            Console.WriteLine(secondSmallest);

        }
    }
}
