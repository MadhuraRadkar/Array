using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class TotalNumOfWords
    {   // WAP to count total number of words in the string.
        static void Main(string[] args)
        {
            string str = "hello to all";
            int wordCount = str.Split(' ').Length;
            Console.WriteLine("Total num of words "+wordCount);
        }
    }
}
