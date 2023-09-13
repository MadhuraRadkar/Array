using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Denomination prblm...There are notes of 1000,500,200,100,50,20 and 10.you need to distribute given amount
// in such a way that minimum number of notes are given.
// For example. if amount is 540 then 500-->1 note and 20-->2 notes.
// If amount is 8930 then 1000-->8 , 500-->1,200-->2,20-->1,10-->1 note.
namespace Arrays
{
    public class Notes
    {
        static void Main(string[] args)
        {
            int[] notes = { 1000, 500, 200, 100, 50, 20, 10 };
            Console.WriteLine("Enter the amount");
            int amount = Convert.ToInt32(Console.ReadLine());

            for(int i =0; i < notes.Length; i++)
            {
                int count = amount / notes[i];
                if(count > 0)
                {
                    Console.WriteLine(notes[i] +" = "+count);
                    amount = amount % notes[i]; 

                }
            }

        }    
    }
}