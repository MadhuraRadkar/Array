using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Foreach1
    {
        static void Main(string[] args)
        {
            int[] arr = { 10, 20, 30, 40, 50 }; // 1D method
            foreach (int a in arr)
            {
                Console.WriteLine(a);
            }
        }
    }
}