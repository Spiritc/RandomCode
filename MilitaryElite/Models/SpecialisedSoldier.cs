using MilitaryElite.ENums;
using MilitaryElite.IContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        private Corps corps;

        public SpecialisedSoldier(string firstName, string lastName, int id, decimal salary, Corps corps)
            : base(firstName, lastName, id, salary)
        {
            this.Corps = corps;
        }

        public Corps Corps { get => corps; private set => corps = value; }

        
    }

}
