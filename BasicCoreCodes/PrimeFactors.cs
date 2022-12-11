using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreCodes
{
    internal class PrimeFactors
    {
        int a, b;

        public void Prime()
        {
            Console.WriteLine("Please enter your integer: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (b = 1; b <= a; b++)
            {
                if (a % b == 0)
                {
                    Console.WriteLine(b + " is a factor of " + a);
                }
            }
            


        }
    }
}
