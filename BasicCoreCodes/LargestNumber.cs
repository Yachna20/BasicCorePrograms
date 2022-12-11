using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreCodes
{
    internal class LargestNumber
    {
        int num1, num2, num3;
        public void Largest()
        {
            Console.WriteLine(" Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine("First number is the largest");
                }

                else
                {
                    Console.WriteLine("Third number is the largest");
                }
            }

            else if (num2 > num3)
            
                Console.WriteLine("Second number is the largest");
            
            else
            
                Console.WriteLine("Third number is the largest");
            


        }
      }
}

