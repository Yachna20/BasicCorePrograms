using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreCodes
{
    internal class Alphabet
    {
        char ch;
        public void VowelConsonant()
        {
            Console.WriteLine("Enter any character:");
            ch = Convert.ToChar(Console.ReadLine());

            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u' || ch == 'A'
                  || ch == 'E' || ch == 'I' || ch == 'O' || ch == 'U')

            {
                Console.WriteLine("It is a Vowel");

            }
            else
            {

                Console.WriteLine("It is a Consonant");
            }
            

        }
    }
}
