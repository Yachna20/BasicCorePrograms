using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreCodes
{
  internal class Flipcoin
    {
        double PercentageOfHead = 0, PercentageOfTail = 0;
        double HeadCount = 0, TailCount = 0;
        public void CheckHeadTail()
        {
            Console.WriteLine("Enter no. of times you want to flip the coin");
            int NumofCount = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= NumofCount; i++)
            {
                Random randobj = new Random();
                double randomnumber = randobj.NextDouble();

                if (randomnumber < 0.5)
                {
                    TailCount++;
                    Console.WriteLine("Tail");
                }
                else
                {
                    HeadCount++;
                    Console.WriteLine("Head");
                }
                Console.WriteLine("Total head count is-" + HeadCount);
                Console.WriteLine("Total tail count is-" + TailCount);
                Console.WriteLine("****Percentage of Head and Tail****");
                PercentageOfHead = HeadCount / NumofCount * 100;
                PercentageOfTail = TailCount / NumofCount * 100;
                Console.WriteLine("Percentage of Head" + PercentageOfHead + "%");
                Console.WriteLine("Percentage of Tail" + PercentageOfTail + "%");
            }



        }
    }
}
