namespace ATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int PinattemptCount = 0;
            int Pin = 2322;
            Console.WriteLine("ATM xos gelmişsiniz ");
            

            while(PinattemptCount < 3)
            {
                Console.WriteLine("PIN daxil edin");


                int pin = Convert.ToInt32(Console.ReadLine());

                if(pin == Pin)
                {
                    Console.WriteLine("Daxil olundu ");
                    break;

                }
                else
                {
                    PinattemptCount++;
                    Console.WriteLine("PIN cehd sayiniz:" + (3-PinattemptCount));

                }

            }
            if(PinattemptCount == 3)
            {
                Console.WriteLine("Cehd sayiniz bitdi! Kart block olunur" );
            }
                
                
                
            
            

            



            BANK menu = new BANK();
            
           
            menu.ShowMenu();
            menu.BalansGoster();
            menu.NegdVesaitinVerilmesi();
            menu.HesabdanCixaris();

            




        }
    }
}