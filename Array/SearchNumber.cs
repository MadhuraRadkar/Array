using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class SearchNumber
    {    // Search a number in an array.
        static void Main(string[] args)
        {
            int[] numbers = { 12, 34, 55, 67, 83, 23, 11, 2 };
            Console.WriteLine("Enter number you want to search");
            int searchNumber = Convert.ToInt32(Console.ReadLine());

            bool found = false;
            foreach (int num in numbers)
            {
                if(num == searchNumber)
                {
                    found = true;
                    break;
                }
            }
            if (found)
            {
                Console.WriteLine(searchNumber+" is found in array");
            }
            else
            {
                Console.WriteLine(searchNumber+" is not found in array");
            }
        }
    }
}
