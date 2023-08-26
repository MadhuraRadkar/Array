using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Rainfall
    {     // WAP to accept rainfall for a week from the user & display the rainfall using an array.

        static void Main(string[] args)
        {
            int[] Rainfall = new int[7];
            for(int i= 0; i<Rainfall.Length; i++)
            {
                Rainfall[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Rainfall in the week is");
            for(int i=0; i<Rainfall.Length; i++)
            {
                Console.WriteLine($"Rainfall[i] = {Rainfall[i]}");

            }

        }
    }
}
