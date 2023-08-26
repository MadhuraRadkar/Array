using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Foreach3
    { // print 5 names using foreach loop .  accept from user.
        static void Main(string[] args)
        {
            string[] name = new string[5];
            for(int i=0;i<name.Length; i++)
            {
                Console.WriteLine("Enter name");
                name[i] = Console.ReadLine();
            }
            foreach (var a in name)
            {
                Console.WriteLine(a);
            }
        }
    }
}
