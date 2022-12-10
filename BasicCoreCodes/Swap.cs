using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreCodes
{
    internal class Swap
    {
        int num1, num2, num3;

        public void Swapping()
        {
            Console.WriteLine("Enter the no for num1");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the no for num2");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Before Swapping num1 = {0} and num2 ={1}", num1, num2);
            num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("AfterSwapping num1 = {0} and num2 = {1}", num1, num2);
        }
    }
}
