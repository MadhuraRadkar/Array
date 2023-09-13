using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays.Sep1Test.cs
{
    public class StringToggle
    { // Mock Q10. WAP to write toggle case of each character of a string .
        public static string ToggleCharacter(string str)
        {

            char[] charArray = str.ToCharArray();

            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] >= 65 && charArray[i] <= 90)
                {
                    int a = (int)charArray[i] + 32;
                    charArray[i] = (char)a;
                }
                else
                {
                    int A = (int)charArray[i] - 32;
                    charArray[i] = (char)A;
                }

            }
            string str1 = new string(charArray);
            return str1;



        }
        public static void Main(string[] args)
        {
            string str = "InDia Is My CouNtry";
            Console.WriteLine(ToggleCharacter(str));
        }
    }
}
