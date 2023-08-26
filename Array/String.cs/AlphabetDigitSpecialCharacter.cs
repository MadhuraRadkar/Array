using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    public class AlphabetDigitSpecialCharacter
    {   // 13. Write a code to find total num of alphabets,digits or special character in a string.
        static void Main(string[] args)
        {
            string str = "India @123";
            int alphabetCount = 0;
            int digitCount = 0;
            int SpecialCharCount = 0;

            for(int i = 0; i < str.Length; i++)
            {
                char c= str[i];
                if(char.IsLetter(c))
                {
                    alphabetCount++;
                }
                else if(char.IsDigit(c))
                {
                    digitCount++;
                }
                else
                {
                    SpecialCharCount++;
                }
            }
            Console.WriteLine("Alphabets "+alphabetCount);
            Console.WriteLine( "Digits " + digitCount );
            Console.WriteLine("SpecialCharacter " +SpecialCharCount );
        }
    }
}
