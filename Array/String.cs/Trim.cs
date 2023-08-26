using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class Trim
    {  
        static void Main(string[] args)
        {   //  Trim leading white space in string.
            string massage = "    Hello world";
            string str1 = massage.TrimStart();
            Console.WriteLine(str1);



            // Trim end space in string.
            string massage2 = "Hello   ";
            string massage3 = "world";
            string str2 = string.Concat(massage2.TrimEnd(), " ", massage3);
            Console.WriteLine(str2);

            

         




        }


    }

}
