using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    public class LongestWord
    {   // 18. Write a code to find longest word in the string.
        static void Main(string[] args)
        {
            string str = "India is the best";
            string[] words = str.Split(' ');
            string longestWord = "";

            for(int i=0; i<words.Length; i++)
            {
                if (words[i].Length > longestWord.Length)
                {
                  longestWord = words[i];
                }
            }
            Console.WriteLine("The longest word is = "+longestWord);

        }
    }
}
