using System;
using System.Collections;
using System.Linq;

namespace BrothersInTheBar
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Step 1
            int finalRounds = 0;
            int inputGlassesCount = int.Parse(Console.ReadLine());
            int[] barGlasses = new int[inputGlassesCount];
            string inputGassesSize = Console.ReadLine();
            int numberOfGlasses = inputGassesSize.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray().Length;

            //Step 2
            if (numberOfGlasses > 1)
            {
                string[] inputGlasses = inputGassesSize.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int i = 0; i < inputGlassesCount; i++)
                {
                    barGlasses[i] = int.Parse(inputGlasses[i]);
                }
            }
            else
            {
                barGlasses[0] = int.Parse(inputGassesSize);
                for (int i = 1; i < inputGlassesCount; i++)
                {
                    barGlasses[i] = int.Parse(Console.ReadLine());
                }
            }

            //Step 3
            finalRounds = Rounds(barGlasses);
            //Step 6
            Console.WriteLine(finalRounds);

        }


        private static int Rounds(int[] barGlasses)
        {
            //Step 4
            int count = 0;
            bool foundRound = false;
            int[] barGlassesRounds = new int[barGlasses.Length];
            for (int i = 0; i < barGlasses.Length; i++)
            {
                barGlassesRounds[i] = barGlasses[i];
            }

            //Step 5
            while (true)
            {

                for (int i = 0; i < barGlassesRounds.Length - 2; i++)
                {
                    if (barGlassesRounds[i] == barGlassesRounds[i + 1] && barGlassesRounds[i] == barGlassesRounds[i + 2])
                    {
                        count++;
                        barGlassesRounds[i] = 0;
                        barGlassesRounds[i + 1] = 0;
                        barGlassesRounds[i + 2] = 0;
                        foundRound = true;
                    }
                }

                if (foundRound)
                {
                    barGlassesRounds = barGlassesRounds.Where(x => x != 0).ToArray();
                    foundRound = false;
                }
                else
                {
                    break;
                }
            }

            return count;
        }
    }
}
