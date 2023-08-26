using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class RemoveOccurrence
    {    // Remove all occurrences of a character in a string.
        static void Main(string[] args)
        {
            string str = "Hello World";
            char charToRemove = 'l';
            string result = "";

            foreach (char c in str)
            {
                if(c != charToRemove)
                {
                    result = result + c; 
                }
            }
            Console.WriteLine(result);
        }
    }
}
