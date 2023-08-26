using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class CountOccurrence
    {   //  WAP to Count occurrences of a character in string.
        static void Main(string[] args)
        {
            string str = "Hello to all";
            char targetChar = 'l';
            int count = 0;
            foreach (char c in str)
            {
                if(c == targetChar)
                {
                    count++;
                }
            }
            Console.WriteLine("The character "+targetChar + " appears "+count+" times.");

        }
    }
}
