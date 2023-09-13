using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class FibonacciSeries
    { // Mock Q6. Print Fibonacci series upto a given number.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int num = Convert.ToInt32(Console.ReadLine());
            int first = 3;
            int second = 5;
            Console.WriteLine(first);
            Console.WriteLine(second);

            for (int i=2; i<num; i++)
            {
                int next = first + second;
                Console.WriteLine(next +"");
                first = second;
                second = next;
            }
           
        }
    }
}
