using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class MaxNumOfArray
    {  // Mock Q3.Accept array from user and then find maximum number from it.
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            for(int i=0; i<numbers.Length; i++)
            {
                Console.WriteLine("Enter number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }
            int maxNumber = numbers[0];
            for(int i=1;i<numbers.Length;i++)
            {
                if (numbers[i] > maxNumber)
                {
                    maxNumber = numbers[i];
                }
            }
            Console.WriteLine("The maximum number is " + maxNumber);
        }
    }
}
