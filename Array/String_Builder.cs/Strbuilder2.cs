using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String_Builder.cs
{
    public class Strbuilder2
    {
        static void Main(string[] args)
        {
            StringBuilder strbuilder = new StringBuilder("Hello to all");
            Console.WriteLine(strbuilder);

            strbuilder.Append("Good morning");
            Console.WriteLine(strbuilder);

            strbuilder.Remove(4,5);
            Console.WriteLine(strbuilder);

           // strbuilder.Replace('l', 'L');
           // Console.WriteLine(strbuilder);

            strbuilder.Replace("all", "everyone");
            Console.WriteLine(strbuilder);

            Console.WriteLine("Capacity= "+strbuilder.Capacity);
            Console.WriteLine(strbuilder);
        }
    }
}
