using StoreCards.StoreObjects;
using StoreCards.StoreObjects.Cards;
using System;

namespace StoreCards
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int select = 0;
            decimal turnover = 0.0m;
            decimal pValue = 0.0m;


            Card garyBronzeCard = new BronzeCard("Peyton");
            Card shawnSilverCard = new SilverCard("Kemp");
            Card kobeGoldCard = new GoldCard("Bryant");


            while (select != 4)
            {
                Console.WriteLine("Please choice a payment card 1-3, 4 for Exit:");
                Console.WriteLine("1.Bronze");
                Console.WriteLine("2.Silver");
                Console.WriteLine("3.Gold");
                Console.WriteLine("4.Exit");

                if (int.TryParse(Console.ReadLine(), out int itsNumber))
                {
                    select = itsNumber;
                }
                else
                {
                    if (select < 1 && select > 4)
                    {
                        continue;
                    } 
                }

                Console.WriteLine("Mock data:");
                Console.Write("turnover $");
                turnover = decimal.Parse(Console.ReadLine());
                Console.Write("purchase value $");
                pValue = decimal.Parse(Console.ReadLine());

                switch (select)
                {
                    case 1:
                        PayDesk.Pay(garyBronzeCard, turnover, pValue);
                        break;
                    case 2:
                        PayDesk.Pay(shawnSilverCard, turnover, pValue);
                        break;
                    case 3:
                        PayDesk.Pay(kobeGoldCard, turnover, pValue);
                        break;
                    case 4:
                        Console.WriteLine($"Thank-you for visit our store. Goodbye!");
                        break;

                    default:
                        break;
                }



            }
        }
    }
}
