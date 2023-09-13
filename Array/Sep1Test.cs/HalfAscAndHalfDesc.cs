using Array;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class HalfAscAndHalfDesc
    { // Mock Q8. WAP to Print Half numbers in ascending order and other half in descending order in an array.
        static void Main(string[] args)
        {
            int[] numbers = { 5, 3, 8, 2, 7, 1, 5, 4, 6,9 };
            int length = numbers.Length;
            int halfLength = length / 2;

            for(int i = 0; i<halfLength-1; i++) 
            {
                for(int j = i+1; j<halfLength; j++)
                {
                    if (numbers[i] > numbers[j]) // Ascending order.
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            for(int i= halfLength; i<length-1; i++) 
            {
                for(int j=i+1;j<length; j++)
                {
                    if (numbers[i] < numbers[j]) // Descending order.
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = temp;
                    }
                }
            }
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
        }
    }
}
