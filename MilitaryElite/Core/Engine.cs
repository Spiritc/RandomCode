using MilitaryElite.ENums;
using MilitaryElite.IContracts;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Core
{
    public class Engine
    {
        private ICollection<ISoldier> soldiers;
        private ISoldier soldier;

        public Engine()
        {
            this.soldiers = new List<ISoldier>();
        }
        public void Run()
        {
            string input = Console.ReadLine();


            while (input != "End")
            {
                //"Private <id> <firstName> <lastName> <salary>”
                //“LieutenantGeneral <id> <firstName> <lastName> <salary> <private1Id> <private2Id> … <privateNId>” 
                //Engineer <id> <firstName> <lastName> <salary> <corps> <repair1Part> <repair1Hours> … <repairNPart> <repairNHours>
                //Commando <id> <firstName> <lastName> <salary> <corps> <mission1CodeName>  <mission1state> … <missionNCodeName> <missionNstate>
                //“Spy <id> <firstName> <lastName> <codeNumber>”

                string[] inputArg = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);
                string type = inputArg[0];
                int id = int.Parse(inputArg[1]);
                string firstName = inputArg[2];
                string lastName = inputArg[3];

                if (type == "Private")
                {
                    decimal salary = decimal.Parse(inputArg[4]);
                    soldier = GetPrivateSoldier(firstName, lastName, id, salary);
                }
                else if (type == "LieutenantGeneral")
                {
                    decimal salary = decimal.Parse(inputArg[4]);
                    soldier = GetLieutenantGeneral(firstName, lastName, id, salary, inputArg);
                }
                else if (type == "Engineer")
                {
                    decimal salary = decimal.Parse(inputArg[4]);

                    soldier = GetEngineer(firstName, lastName, id, salary, inputArg);
                }
                else if (type == "Commando")
                {
                    decimal salary = decimal.Parse(inputArg[4]);

                    soldier = GetCommando(firstName, lastName, id, salary, inputArg);
                }
                else if (type == "Spy")
                {
                    int codeNumber = int.Parse(inputArg[4]);

                    soldier = GetSpy(firstName, lastName, id, codeNumber);
                }

                if (soldier != null)
                {
                    soldiers.Add(soldier);
                }

                input = Console.ReadLine();
            }


            foreach (var soldier in soldiers)
            {
                Console.WriteLine(soldier);
            }

        }

        private ISoldier GetSpy(string firstName, string lastName, int id, int codeNumber)
        {
            ISpy spy = new Spy(firstName, lastName, id, codeNumber);

            return spy;
        }

        private ISoldier GetCommando(string firstName, string lastName, int id, decimal salary, string[] inputArg)
        {
            string corpsAsString = inputArg[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }

            ICommando commando = new Commando(firstName, lastName, id, salary, corps);

            for (int i = 6; i < inputArg.Length; i += 2)
            {
                string codeName = inputArg[i];
                string stateAsString = inputArg[i + 1];

                if (!Enum.TryParse(stateAsString, out State state))
                {
                    continue;
                }

                IMission mission = new Mission(codeName, state);

                commando.Missions.Add(mission);
            }

            return commando;

        }

        private ISoldier GetEngineer(string firstName, string lastName, int id, decimal salary, string[] inputArg)
        {
            string corpsAsString = inputArg[5];

            if (!Enum.TryParse(corpsAsString, out Corps corps))
            {
                return null;
            }

            IEngineer engineer = new Engineer(firstName, lastName, id, salary, corps);

            for (int i = 6; i < inputArg.Length; i += 2)
            {
                string partName = inputArg[i];
                int workHours = int.Parse(inputArg[i + 1]);
                IRepair repair = new Repair(partName, workHours);
                engineer.Repairs.Add(repair);
            }

            return engineer;
        }

        private ISoldier GetLieutenantGeneral(string firstName, string lastName, int id, decimal salary, string[] inputArg)
        {

            ILieutenantGeneral lieutenantGeneral = new LieutenantGeneral(firstName, lastName, id, salary);

            for (int i = 5; i < inputArg.Length; i++)
            {
                int privateId = int.Parse(inputArg[i]);
                IPrivate privateSoldier = (IPrivate)this.soldiers.FirstOrDefault(x => x.Id == int.Parse(inputArg[i]));

                lieutenantGeneral.Squad.Add(privateSoldier);
            }

            return lieutenantGeneral;
        }

        private ISoldier GetPrivateSoldier(string firstName, string lastName, int id, decimal salary)
        {
            IPrivate privateSoldier = new Private(firstName, lastName, id, salary);

            return privateSoldier;
        }
    }
}
