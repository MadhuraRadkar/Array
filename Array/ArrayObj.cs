using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class ArrayObj
    {
        static void Main(string[] args)
        {
            object[] arrobj = new object[4];
            arrobj[0] = 1000;
            arrobj[1] = "Hello world";
            arrobj[2] = 85.86;
            arrobj[3] = "F";

            foreach (var item in arrobj)
            {
                Console.WriteLine(item);

            }
        }
    }
}
