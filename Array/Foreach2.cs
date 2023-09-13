using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Foreach2
    {
        static void Main(string[] args)
        {   // 2D
            int[,] arr = new int[2,3]
            {
              {100,200,300 },
              {400,500,600 }
            };
            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }

        }
    }
}
