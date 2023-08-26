using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class AcceptName
    {
        public static void Main(string[] args)
        { // WAP to accept 5 names using 1D array and display using for loop.
            string[] arr = new string[5];
            for(int i=0;i<arr.Length; i++)
            {
                Console.WriteLine("Enter Name");
                arr[i] = Console.ReadLine();
            }
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
    }
}
