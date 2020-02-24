using System;
using System.Collections.Generic;
using System.Text;

namespace StoreCards.StoreObjects
{
    abstract class Card 
    {
        abstract public string OwnerName { get; set; }

        public string CardNumber { get; set; }
    }
}
