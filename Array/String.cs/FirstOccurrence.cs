using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Array.String.cs
{
    public class FirstOccurrence
    {      // Find first occurrence of a character in the string.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            Console.WriteLine("Enter the character to find");
            char character = Console.ReadKey().KeyChar;

            int index = -1;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i] == character)
                {
                    index = i;
                    break;
                }
            }
            if(index != 1)
            {
                Console.WriteLine($"The character {character} is not at index {index}");
            }
            else
            {
                Console.WriteLine($"The character {character} is not found in the string");
            }
        }
    }
}
