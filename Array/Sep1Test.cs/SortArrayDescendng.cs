using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class SortArrayDescendng
    {   // WAP to sort an array in descending order.
        static void Main(string[] args)
        {
            int[] arr = { 24, 45, 67, 46, 9, 3, 50 };
            for(int i=0; i<arr.Length; i++)
            {
                for(int j=i; j<arr.Length; j++)
                {
                    if (arr[i] < arr[j])
                    {
                        int temp = arr[i];
                        arr[i]= arr[j];
                        arr[j]= temp;
                    }
                }
            }
            foreach(int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
