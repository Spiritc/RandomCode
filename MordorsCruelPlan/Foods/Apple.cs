using System;
using System.Collections.Generic;
using System.Text;

namespace MordorsCruelPlan.Foods
{
    public class Apple : Food
    {
        public const int happiness = 1;

        public Apple() 
            : base(happiness)
        {
        }
    }
}
