using BorderControl.Interfaces;
using BorderControl.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BorderControl.Core
{
    public class Engine
    {
        private ICollection<IIdentifiabie> creatures;

        public Engine()
        {
            this.creatures = new List<IIdentifiabie>();
        }

        public void Run()
        {
            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] arg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                if (arg.Length == 2)
                {
                    string model = arg[0];
                    string id = arg[1];

                    Robot robot = new Robot(model, id);

                    AddRobot(robot);
                }
                else if (arg.Length == 3)
                {
                    string name = arg[0];
                    int age = int.Parse(arg[1]);
                    string id = arg[2];

                    Citizen citizen = new Citizen(name, age, id);

                    AddCitizen(citizen);
                }

                input = Console.ReadLine();
                
            }
            string banEndId = Console.ReadLine();
            PrintBannedIds(banEndId);
        }

        private void PrintBannedIds(string id)
        {
            foreach (var creature in this.creatures)
            {
                string lastDigits = creature.Id.Substring(creature.Id.Length - id.Length);

                if (id == lastDigits)
                {
                    Console.WriteLine(creature.Id);
                }
            }
        }

        public void AddRobot(Robot robot)
        {
            this.creatures.Add(robot);
        }
        public void AddCitizen(Citizen citizen)
        {
            this.creatures.Add(citizen);
        }
    }
}
