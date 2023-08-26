using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class Program2
    {
        static void Main(string[] args)
        {  
            // concat , TrimStart ,TrimEnd,IndexOf,LastIndexOf,ToUpper,ToLower,Split,ToCharArray,Length-Property.

            string message = "  Hello to all  ";
            string message2 = " hello to all  ";

            // Methods of string class.
            string str1 = string.Concat(message, " ", message2.TrimEnd());
            Console.WriteLine(str1);
            Console.WriteLine(str1);
            Console.WriteLine(str1.Trim());

            // ToUpper & ToLower.
            Console.WriteLine(message2.ToUpper());
            Console.WriteLine(message2.ToLower());

            // Indexof
            Console.WriteLine("index "+message2.IndexOf('o')); // Returns the first occurrence.
            Console.WriteLine("Lastindex "+message2.LastIndexOf('o')); // returns last occurrence.

            // Convert string to string array
            // Use of Split('')
            string[] strarr = message2.Split(' ');

            // Convert string to char array.
            char[] ch = message.ToCharArray();

            // Convert char array  to string.
            string str2 = new string(ch);
            Console.WriteLine(str2);
            foreach(char c in ch)
            {
                Console.WriteLine(c);
            }

            Console.WriteLine(strarr[0]); // Good
            Console.WriteLine(strarr[1]); // Morning

            foreach(string s in strarr)
            {
                Console.WriteLine(s);

            }
            for(int i=0; i<message2.Length; i++)
            {
                Console.WriteLine(message2[i]);
            }





        }
    }
}
