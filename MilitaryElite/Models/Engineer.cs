using MilitaryElite.ENums;
using MilitaryElite.IContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        private ICollection<IRepair> repairs;

        public Engineer(string firstName, string lastName, int id, decimal salary, Corps corps)
            : base(firstName, lastName, id, salary, corps)
        {
            this.Repairs = new List<IRepair>();
        }

        public ICollection<IRepair> Repairs { get => repairs; private set => repairs = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nCorps: {this.Corps}\nRepairs:{(this.Repairs.Count == 0 ? "" : "\n  ")}{string.Join("\n  ", this.Repairs)}";
        }
    }
}
