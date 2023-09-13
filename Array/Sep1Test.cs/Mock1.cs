using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class Reverse
    {  //  Mock  *1. Accept a string from user and print it in reverse order.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string str = Console.ReadLine();
            string reversedString = "";
            for(int i = str.Length - 1; i >= 0; i--)
            {
                reversedString = reversedString + str[i];
            }
            Console.WriteLine(reversedString );
        }
    }
}
