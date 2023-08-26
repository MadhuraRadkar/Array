using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    public class HighestFrequency
    {   // 12. Write a code to find highest frequency character in a string.
        static void Main(string[] args)
        {
            string input = "Hello World";
            char mostFrequentChar = ' ';
            int highestFrequency = 0;

            for(int i=0; i<input.Length; i++)
            {
                int count = 0;
                for(int j=0; j<input.Length; j++)
                {
                    if (input[i] == input[j])
                    {
                        count++;
                    }
                }
                if(count > highestFrequency)
                {
                    mostFrequentChar = input[i];
                    highestFrequency = count;
                }
            }
            Console.WriteLine("Most frequent character "+mostFrequentChar );
        }
    }
}
