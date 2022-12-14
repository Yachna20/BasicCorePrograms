
namespace BasicCoreCodes
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Flipcoin\n2.LeapYear\n3.PrimeFactors\n4.QuotientRemainder\n5.Swapping\n6.EvenorOdd"+
                                   "\n7.VowelorConsonant\n8.LargestAmong3Numbers");
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
                     case 6:
                        EvenorOdd num = new EvenorOdd();
                        num.Test();
                        break;
                    case 7:
                        Alphabet vow = new Alphabet();
                        vow.VowelConsonant();
                        break;
                    case 8:
                        LargestNumber large = new LargestNumber();
                        large.Largest();
                        break;
                    
                       default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }

    }
}