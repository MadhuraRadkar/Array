using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class UniqueElement
    {     // 7. WAP to print all unique elements in the array.
        static void Main(string[] args)
        {
            int[] a = {1,2,3,4,2,3,4,5,6 };
            for(int i=0; i < a.Length; i++)
            {
                int count = 1;
                bool isvisited = false;
                for(int k=i-1; k >= 0; k--)
                {
                    if (a[k] == a[i])
                    {
                        isvisited = true;
                        break;
                    }
                }
                if (isvisited == false)
                {
                    for(int j=i+1; j < a.Length; j++)
                    {
                        if (a[i] == a[j])
                        {
                            count++;
                        }
                    }
                }
                if (count == 1)
                {
                    Console.WriteLine( a[i]);
                }
            }
        }
    }
}
