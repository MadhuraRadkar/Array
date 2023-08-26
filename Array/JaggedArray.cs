using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    internal class JaggedArray
    {
        static void Main(string[] args)
        {
            int[][] jarray = new int[5][];
            jarray[0] = new int[] { 1, 2, 3, 4, 5, 6 };
            jarray[1] = new int[] { 10, 20, 30 };
            jarray[2] = new int[] { 100, 200, 300, 400, 500 };
            jarray[3] = new int[] { 00, 00 };
            jarray[4] = new int[] { 111 };
           
            for(int row = 0; row < jarray.Length; row++)
            {
                for(int col=0; col < jarray[row].Length; col++)
                {
                    Console.Write(jarray[row][col]+" ");
                }
                Console.WriteLine("\n");

            }


        }
    }
}
