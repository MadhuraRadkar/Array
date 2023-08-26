using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.String.cs
{
    internal class VowelAndConsonants
    {
        static void Main(string[] args)
        {   // 9. Count total numbers of vowels and consonants in a string.
            string str = "Hello World";
            int vowelCount = 0;
            int consonantCount = 0;
            foreach (char c in str)
            {
                if (char.IsLetter(c))
                {
                    if (c == 'a' || c == 'e'|| c=='i'|| c=='o'|| c=='u'|| c=='A'|| c=='E'||c=='I'||c=='O'||c=='U')
                    {
                        vowelCount++;
                    }
                    else
                    {
                        consonantCount++;
                    }
                }
            }
            Console.WriteLine("Total vowels are "+vowelCount);
            Console.WriteLine("Total consonants are "+consonantCount);

        }
    }
}
