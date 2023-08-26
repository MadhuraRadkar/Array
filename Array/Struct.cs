using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Struct
    {
        public struct Screen
        {
            private int X, Y;
            public Screen(int X, int Y)
            {
                this.X = X;
                this.Y = Y;
            }
            public string Print()
            {
                return $"X={X},Y={Y}";
            }
        }

        public class Program
        {
            static void Main(string[] args)
            {
                Screen screen = new Screen(100,200);
                Console.WriteLine(screen.Print());
            }
        }
    }
}
