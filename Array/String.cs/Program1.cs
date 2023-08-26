using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class Program1
    {
        static void Main(string[] args)
        {
            string message = "Hello to all";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode()); // Returns the address location of variable.

            message = message + " Good morning";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());

            message = message + " Good day";
            Console.WriteLine(message);
            Console.WriteLine(message.GetHashCode());






        }
    }
}
