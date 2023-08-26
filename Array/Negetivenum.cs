using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class Negetivenum
    {
         // 3. WAP to print all negative elements in an array and also count the total number of negative elements in an array.
        static void Main(string[] args)
        {
            int[] Negetive = new int[8];
            int count = 0;
            for(int i = 0; i<Negetive.Length; i++)
            {
                Console.WriteLine("Enter number");
                Negetive[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<Negetive.Length; i++)
            {
                if (Negetive[i] < 0)
                {
                    Console.WriteLine(Negetive[i] + "is a Negetive number");
                    count++;
                    

                }

            }
            Console.WriteLine("Total negetive numbers are " +count);
            count++;
            
        }
    }
}
