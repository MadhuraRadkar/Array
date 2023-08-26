using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class ReverseString
    {  // 10. Write a code to find Reverse of a string.
        static void Main(string[] args)
        {
            string str = "India is my country";
            string reversed = "";
            for(int i =str.Length - 1; i >= 0; i--)
            {
                reversed = reversed + str[i];
            }
            Console.WriteLine(reversed );
        }
    }
}
