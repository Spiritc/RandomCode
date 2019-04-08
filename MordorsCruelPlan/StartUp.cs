using MordorsCruelPlan.Core;
using MordorsCruelPlan.Foods;
using System;

namespace MordorsCruelPlan
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Engine engine = new Engine();
            engine.Run();
        }
    }
}
