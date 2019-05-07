using MilitaryElite.ENums;
using MilitaryElite.IContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        private ICollection<IMission> missions;


        public Commando(string firstName, string lastName, int id, decimal salary, Corps corps)
            : base(firstName, lastName, id, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public ICollection<IMission> Missions { get => missions;private set => missions = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {this.Corps}\nMissions:{(this.Missions.Count == 0 ? "" : "\n  ")}{string.Join("\n  ", this.Missions)}";
        }
    }
}
