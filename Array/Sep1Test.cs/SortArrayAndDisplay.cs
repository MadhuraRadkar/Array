using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class SortArrayAndDisplay
    {
        // Mock Q.2. WAP to sort an integer in array and display.
        static void Main(string[] args)
        {
            int[] num = { 14, 55, 28, 3, 17, 9 };
            for(int i=0; i<num.Length-1; i++)
            {
                for(int j=i;j<num.Length; j++)
                {
                    if (num[i] > num[j])
                    {
                        int temp = num[i];
                        num[i] = num[j];
                        num[j] = temp;
                    }
                }
            }
            Console.WriteLine("Sorted numbers");
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
    }
}
