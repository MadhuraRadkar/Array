using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String_Builder.cs
{
    public class StringBuilder1
    {
        static void Main(string[] args)
        {

            string str1 = "Hello to all";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());

            str1 = str1 + "Good Morning";
            Console.WriteLine(str1);
            Console.WriteLine(str1.GetHashCode());


            Console.WriteLine("-------StringBuilder Class--------");

            StringBuilder strbuilder = new StringBuilder("Hello to all");
            Console.WriteLine(strbuilder);
            Console.WriteLine(strbuilder.GetHashCode());

            strbuilder.Append("Good Morning");
            Console.WriteLine(strbuilder);
            Console.WriteLine(strbuilder.GetHashCode());

        }
    }
}
