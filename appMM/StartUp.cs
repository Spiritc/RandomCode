using System;

namespace appM
{
    partial class WrongData
    {
        static void Main(string[] args)
        {
            int m = 0;

            while (!(m > 2 && m <= 10000))
            {
                Console.WriteLine("Enter na number betwin 3 and 10000 ");
                if (int.TryParse(Console.ReadLine(), out int itsNomber))
                {
                    m = itsNomber;
                }
                else
                {
                    Console.WriteLine("Тhis is not a number!?");
                }
            }

            Painter painter = new Painter(m);

            painter.Printing();

        }

    }
}
