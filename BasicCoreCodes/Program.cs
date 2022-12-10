
namespace BasicCoreCodes
{
    public class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("1.Flipcoin");
                    
  
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Flipcoin flipcoin = new Flipcoin();
                        flipcoin.CheckHeadTail();
                        break;
                    



                        
                    default:
                        Console.WriteLine("Please enter valid choice");
                        break;
                }
            }
        }

    }
}