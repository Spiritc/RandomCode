using System;
using System.Collections.Generic;
using System.Text;

namespace appM
{
    class Painter
    {
        private string name = "Leonardo";
        private int magicNumber;

        public string Name { get => name; private set => name = value; }

        public int MagicNumber { get => magicNumber; set => magicNumber = value; }

        public Painter(int mNumber)
        {
            this.MagicNumber = mNumber;
        }

        public void Printing()
        {
            int brushRows = 0;
            int brushColumns = this.MagicNumber;
            if (this.MagicNumber % 2 == 0)
            {
                brushRows = this.MagicNumber;
            }
            else
            {
                brushRows = this.MagicNumber + 1;
            }


            for (int i = 0; i < brushRows/2; i++)
            {
                Console.WriteLine((new string('-', brushColumns - i)) + (new string('*', brushColumns + i * 2)) +
                                  (new string('-', brushColumns - i * 2)) + (new string('*', brushColumns + i * 2)) +
                                  (new string('-', brushColumns * 2 - i * 2)) +
                                  (new string('*', brushColumns + i * 2)) + (new string('-', brushColumns - i * 2)) +
                                  (new string('*', brushColumns + i * 2)) + (new string('-', brushColumns - i)));
            }
            for (int i = 0; i < brushRows / 2; i++)
            {
                Console.WriteLine((new string('-', brushColumns/2 - i)) + (new string('*', brushColumns)) + (new string('-', 1 + i * 2)) + 
                                  (new string('*', (brushColumns  % 2 == 0 ? brushColumns * 2 - 2: brushColumns * 2 - 1) - i * 2)) +
                                  (new string('-', 1 + i * 2)) + (new string('*', brushColumns)) + (new string('-', (brushColumns % 2 == 0 ? brushColumns : brushColumns - 1) - i * 2 )) +
                                  (new string('*', brushColumns)) + (new string('-', 1 + i * 2)) + (new string('*', (brushColumns % 2 == 0 ? brushColumns * 2 - 2: brushColumns * 2 - 1) - i * 2)) +
                                  (new string('-', 1 + i * 2)) + (new string('*', brushColumns)) + (new string('-', brushColumns / 2 - i)));
            }
        }
    }
}
