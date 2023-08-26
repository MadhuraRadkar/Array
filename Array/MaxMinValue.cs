using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class MaxMinValue
    {     // 5. WAP to find maximum and minimum value in an array.
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            for(int i=0; i<arr.Length; i++)
            {
                Console.WriteLine("Enter number");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int m = arr[0];
            int n = arr[0];
            for(int i =0;i<arr.Length; i++)
            {
                if (arr[i] > m)
                {
                    m = arr[i];
                }
                else if (arr[i] < n)
                {
                    n = arr[i];
                }
            }
            Console.WriteLine("Maximum value is " +m);
            Console.WriteLine("Minimum value is "+n);
        }
    }
}
