using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.String.cs
{   // Check given strings are anagram or not.
    public class AnagramOrNot
    {  
        static void Main(string[] args)
        {
            string str = "listen";
            string str2 = "silents";
            char[] ch = str.ToLower().ToCharArray();
            char[] ch2 = str2.ToLower().ToCharArray();

            string str3 = new string(ch);
            string str4 = new string(ch2);

            if(str3 == str4)
            {
                Console.WriteLine("Anagram");

            }
            else
            {
                Console.WriteLine("Not anagram");

            }

        }
    }
}
