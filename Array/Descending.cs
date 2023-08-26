using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Descending
    {
        static void Main(string[] args)
        {  // Print in Descending order. 
            // bubble sort method.
            int[] arr = { 45, 67, 12, 89, 5 };
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            foreach (int a in arr)
            {
                Console.WriteLine(a);

            }
        }
    }
}
