using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.String.cs
{   // A word is alphabetically sorted if all of the letters in it are in consecutive alphabetical order.
    // some examples are hoop , ghost , abhors .
    public class Alphabetically_Sorted_Words
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string input = Console.ReadLine();
            input = input.ToLower();

            bool IsAlphabeticallySort = true;
            for(int i=1; i<input.Length; i++)
            {
                if (input[i] < input[i-1])
                {
                    IsAlphabeticallySort = false;
                    break;
                    
                }
            }
            if(IsAlphabeticallySort)
            {
                Console.WriteLine("Alphabetically sorted ");
            }
            else
            {
                Console.WriteLine("not alphabetically sorted");
            }
        }

    }
}
