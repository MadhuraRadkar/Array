using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class JaggedArray1
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[4][];
            jarray[0] = new int[2];
            jarray[1] = new int[4];
            jarray[2] = new int[5];
            jarray[3] = new int[8];
            

            for (int row = 0; row < jarray.Length; row++)
            {
                for (int col = 0; col < jarray[row].Length; col++)
                {
                    Console.Write(jarray[row][col] + " ");
                   // int = Convert.ToInt32(jarray[row][col]);
                }
                Console.WriteLine("\n");

            }
        }
    }
}