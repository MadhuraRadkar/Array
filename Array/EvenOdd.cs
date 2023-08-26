using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class EvenOdd
    {  // 4. WAP to put even and odd elements of array in two separate arrays.
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evenNumbers = new int[num.Length];
            int[] oddNumbers = new int[num.Length];
            int evenCount = 0;
            int oddCount = 0;
            for(int i=0; i<num.Length; i++)
            {
                if (num[i] % 2 == 0)
                {
                    evenNumbers[evenCount] = num[i];
                    evenCount++;
                }
                else
                {
                    oddNumbers[oddCount] = num[i];
                    oddCount++;
                }
            }
            Console.WriteLine("Even numbers ");
            for(int i = 0; i < evenCount; i++)
            {
                Console.WriteLine(evenNumbers[i]);
            }
            Console.WriteLine("Odd numbers");
            for(int i=0;i<oddCount; i++)
            {
                Console.WriteLine(oddNumbers[i]);
            }

        }
    }
}
