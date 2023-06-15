using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class BANK
    {
        private int balans = 1000;
        public bool Pin;
        public string pin;

       

        
        
        public void ShowMenu()
        {
            bool exit=false;

            while(!exit)
            {
                Console.WriteLine("----MENU GOSTER");
                Console.WriteLine("1. Balans goster");
                Console.WriteLine("2. Negd vesaitin verilmesi");
                Console.WriteLine("3. Hesabdan cixaris");

                int secim = Convert.ToInt32(Console.ReadLine());

                switch (secim)
                {
                    case 1:
                        BalansGoster();
                        break;
                        case 2:
                        NegdVesaitinVerilmesi();
                        break;
                        case 3:
                        HesabdanCixaris();
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Yanlis Secim: Yeniden Cehd edin!");
                        break;


                }
            }

            
        }
        public void BalansGoster()
        {
            Console.WriteLine("Sizin Balans:" +balans);

        }
        public void NegdVesaitinVerilmesi()
        {
            Console.WriteLine("Cekmek istediyiniz meblegi secin (1-1000 AZN)");

            int amount = int.Parse(Console.ReadLine());

            if (amount<1 || amount > 1000)
            {
                Console.WriteLine("Yanlis Mebleq: 1-1000 AZN arasinda mebleq cixarda bilersiz");
                   

            }
            if(amount>balans)
            {
                Console.WriteLine("Hesabda kifayet qeder mebleq yoxdur");
               
            }
           balans-= amount;
           

            
            Console.WriteLine("Cekilen Mebleq" +amount);
            int yuzluk = amount / 100;
            amount %= 100;
            int ellilik= amount % 50;
            amount %= 50;
            int iyirmilik= amount % 20;
            amount %= 20;
            int onluq= amount % 10;
            amount %= 10;
            int beslik= amount % 5 ;
            amount %= 5;
            int birlik= amount % 1;
            amount %= 1;
            Console.WriteLine("100  "+yuzluk);
            Console.WriteLine("50  "+ellilik);
            Console.WriteLine("20  " +iyirmilik);
            Console.WriteLine("10  " +onluq);
            Console.WriteLine("5  " +beslik);
            Console.WriteLine("1  " +birlik);
        }
        public void HesabdanCixaris()
        {
            if (balans == 1000)
            {
                Console.WriteLine("Hesabdan cixaris olunmayib" );
            }
            else
            {
              
                Console.WriteLine("Tarix:" +DateTime.Now);
            }
            
        }

        
    }
   
}

