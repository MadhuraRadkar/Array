using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class ReverseNum
    {  // Mock. Q4. WAP to reverse a number.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            int reversedNum = 0;
            while (num > 0)
            {
                int rem = num % 10;
                reversedNum = (reversedNum * 10)+ rem;
                num = num / 10;
            }
            Console.WriteLine("Reversed Number " + reversedNum);
        }
    }
}
