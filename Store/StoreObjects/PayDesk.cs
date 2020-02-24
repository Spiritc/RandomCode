using StoreCards.StoreObjects.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoreCards.StoreObjects
{
    static class PayDesk
    {

        public static void Pay(Card card, decimal turnover, decimal pValue)
        {
            decimal discountRate = 0.0m;
            decimal discount = 0.0m;
            decimal totalPrice = 0.0m;

            //Step 3
            if (card.GetType() == typeof(BronzeCard))
            {
                discount = pValue * 0.0m;
                totalPrice = pValue - discount;

                if (turnover >= 100 && turnover <= 300)
                {
                    discountRate = 0.01m;
                    discount = pValue * discountRate;
                    totalPrice = pValue - discount;
                }
                if (turnover > 300)
                {
                    discountRate = 0.025m;
                    discount = pValue * discountRate;
                    totalPrice = pValue - discount;
                }
            }
            if (card.GetType() == typeof(SilverCard))
            {
                discountRate = 0.02m;
                discount = pValue * 0.02m;
                totalPrice = pValue - discount;

                if (turnover > 300)
                {
                    discountRate = 0.035m;
                    discount = pValue * discountRate;
                    totalPrice = pValue - discount;
                }
            }
            if (card.GetType() == typeof(GoldCard))
            {
                discountRate = 0.02m;
                totalPrice += pValue * 0.02m;
                discount = pValue * 0.02m;

                if (turnover > 300)
                {
                    discountRate = 0.02m;
                    discount = pValue * discountRate;
                    totalPrice = pValue - discount;

                    if (pValue >= 100)
                    {
                        discountRate += 0.01m;
                        if (pValue >= 200)
                        {
                            discountRate += 0.01m;
                            if (pValue >= 300)
                            {
                                discountRate += 0.01m;
                                if (pValue >= 400)
                                {
                                    discountRate += 0.01m;
                                    if (pValue >= 500)
                                    {
                                        discountRate += 0.01m;
                                        if (pValue >= 600)
                                        {
                                            discountRate += 0.01m;
                                            if (pValue >= 700)
                                            {
                                                discountRate += 0.01m;
                                                if (pValue >= 800)
                                                {
                                                    discountRate += 0.01m;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
                discount = pValue * discountRate;
                totalPrice = pValue - discount;
            }

            Console.WriteLine($"Purchase value: ${pValue:f2}");
            Console.WriteLine($"Discount rate: {discountRate:f1}%");
            Console.WriteLine($"Discount: ${discount:f2}");
            Console.WriteLine($"Total: ${totalPrice:f2}");

        }
    }
}
