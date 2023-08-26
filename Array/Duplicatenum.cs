using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Duplicatenum
    {  // 6. WAP to find duplicate number in array.
        static void Main(string[] args)
        {
            int[] arr = { 2, 2,12,23,23,2 };
            for(int i=0; i<arr.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1; k>=0; k--)
                {
                    if (arr[k] == arr[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for(int j=i+1;j<arr.Length; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            count++;
                        }
                    }
                    if (count > 1)
                    {
                        Console.WriteLine("Duplicate number is " + arr[i]);
                        Console.WriteLine(count);
                    }

                }

            }
         

        }
    }
}
