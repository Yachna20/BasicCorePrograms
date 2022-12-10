
namespace BasicCoreCodes
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Flipcoin\n2.LeapYear\n3.PrimeFactors\n4.QuotientRemainder\n5.Swapping");
                    
  
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Flipcoin flipcoin = new Flipcoin();
                        flipcoin.CheckHeadTail();
                        break;
                    case 2:
                        LeapYear leap = new LeapYear();
                        leap.FindLeap();
                        break;
                    case 3:
                        PrimeFactors prime = new PrimeFactors();
                        prime.Prime();
                        break;
                    case 4:
                        QuotientRemainder qr = new QuotientRemainder();
                        qr.Division();
                        break;
                        case 5:
                        Swap swap= new Swap();
                        swap.Swapping();
                        break;
                    



                        
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }

    }
}