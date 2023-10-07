using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{  //  generate your own function to satisfy the relationship between the inputs and outputs.
   //  Your task is to create a function that, when fed the inputs below, produce the sample outputs shown.
   // examples 832-->594, 51-->36,1-->0,7977-->180,665-->99,149-->0.

    public class JisaReversNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int num = Convert .ToInt32(Console.ReadLine());
            int reverse = 0;
            int temp = num;
            while(num > 0)
            {
                int digit = num % 10;
                reverse = reverse * 10 + digit;
                num = num / 10;
            }
            //Console.WriteLine(reverse);

            int result = temp - reverse;
            if(result > 0)
            {
                Console.WriteLine(result); 
            }
            else
            {
                Console.WriteLine("0");
            }
            
        }
        
    }
}
