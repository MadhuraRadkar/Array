using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class NullEmpty
    {
        static void Main(string[] args)
        { 
            // IsNullOrEmpty --> to check whether string has  empty or null.
            // string str = null; // Null means nothing ,  no space , no"" , not empty
            string str = ""; // empty --> no space , it is not null.
            if (string.IsNullOrEmpty(str))
            {
                Console.WriteLine("string is empty");
            }
            Console.WriteLine(str);

            Console.WriteLine("Enter a name");
            string name = Console.ReadLine();
            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Name is Required");

            }
            else
            {
                Console.WriteLine("Hello "+name);
            }

        }
    }
}
