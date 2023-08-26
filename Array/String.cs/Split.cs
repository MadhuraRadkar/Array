using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class Split
    {   // Split string into 2 tokens and find first and last occurrence.
        static void Main(string[] args)
        {
            string massage = "HELLO$WORLD";
            string[] tokens = massage.Split('$');

            string token1 = tokens[0];
            string token2 = tokens[1];

            Console.WriteLine("Token1 = "+token1);
            Console.WriteLine("Token2 = "+token2);

            Console.WriteLine("Index " +massage.IndexOf('O')); // First occurrence.
            Console.WriteLine("LastIndex "+massage.LastIndexOf('O')); // last occurrence.



        }
    }
}
