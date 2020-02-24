using System;
using System.Collections.Generic;
using System.Text;

namespace StoreCards.StoreObjects.Cards
{
    class BronzeCard : Card
    {
        private decimal discountRate;
        private decimal turnover;
        private string ownerName;


        public override string OwnerName { get => ownerName; set => ownerName = value; }
        public decimal Turnover { get => turnover; set => turnover = value; }
        public decimal DiscountRate { get => discountRate; set => discountRate = value; }

        public BronzeCard(string ownerName)
        {
            OwnerName = ownerName;
            Turnover = 0.0m;
            DiscountRate = 0.0m;
        }

    }
}
