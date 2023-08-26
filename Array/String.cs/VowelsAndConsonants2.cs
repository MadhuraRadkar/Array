using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    public class VowelsAndConsonants2
    {
        static void Main(string[] args)
        {   // 9. Count total numbers of vowels and consonants in a string using for loop.
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();

            int vowelCount = 0;
            int consonantCount = 0;

            for(int i=0;i<str.Length;i++)
            {
                char c = char.ToLower(str[i]);
                if (c >= 'a' && c <= 'z') 
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u' || c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
            Console.WriteLine($"Number of vowels = {vowelCount }");
            Console.WriteLine($"Number of consonants = {consonantCount}");
        }
    }
}
