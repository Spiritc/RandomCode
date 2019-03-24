using System;
using System.Collections.Generic;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        private int overal;

        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            this.Overal = (endurance + sprint + dribble + passing + shooting) / 5;
        }

        public string Name
        {
            get => name;
            private set
            {
                if (value != null || value != "" || value != " ")
                {
                    name = value;
                }
                else
                {
                    Exception ex = new Exception($"A name should not be empty.");
                    Console.WriteLine(ex.Message);
                }
            }
        }
        public int Endurance
        {
            get => endurance;
            private set
            {
                if (IsInRange(value))
                {
                    endurance = value;
                }
                else
                {
                    Exception ex = new Exception($"Endurance should be between 0 and 100.");
                    Console.WriteLine(ex.Message);
                    
                }
            }
        }


        public int Sprint
        {
            get => sprint;
            private set
            {
                if (IsInRange(value))
                {
                    sprint = value;
                }
                else
                {
                    Exception ex = new Exception($"Sprint should be between 0 and 100.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }
        public int Dribble
        {
            get => dribble;
            private set
            {
                if (IsInRange(value))
                {
                    dribble = value;
                }
                else
                {
                    Exception ex = new Exception($"Dribble should be between 0 and 100.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }
        public int Passing
        {
            get => passing;
            private set
            {
                if (IsInRange(value))
                {
                    passing = value;
                }
                else
                {
                    Exception ex = new Exception($"Passing should be between 0 and 100.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }
        public int Shooting
        {
            get => shooting;
            private set
            {
                if (IsInRange(value))
                {
                    shooting = value;
                }
                else
                {
                    Exception ex = new Exception($"Shooting should be between 0 and 100.");
                    Console.WriteLine(ex.Message);
                    Environment.Exit(0);
                }
            }
        }

        public int Overal { get => overal; private set => overal = value; }

        private bool IsInRange(int val)
        {
            return val >= 0 && val <= 100 ? true : false;
        }
    }
}
