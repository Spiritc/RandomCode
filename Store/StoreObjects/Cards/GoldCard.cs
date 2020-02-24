using System;
using System.Collections.Generic;
using System.Text;

namespace StoreCards.StoreObjects.Cards
{
    class GoldCard : Card
    {
        private string ownerName;
        private decimal discountRate;
        private decimal turnover;

        public override string OwnerName { get => ownerName; set => ownerName = value; }
        public decimal Turnover { get => turnover; set => turnover = value; }
        public decimal DiscountRate { get => discountRate; set => discountRate = value; }

        public GoldCard(string ownerName)
        {
            OwnerName = ownerName;
            Turnover = 0.0m;
            DiscountRate = 0.02m;
        }
    }
}
