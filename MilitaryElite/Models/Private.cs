using MilitaryElite.IContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Private : Soldier ,IPrivate
    {
        
        private decimal salary;

        public Private(string firstName, string lastName, int id, decimal salary) 
            : base(firstName, lastName, id) 
        {
            this.Salary = salary;
        }
        //TODO add vaidation
        public decimal Salary { get => salary;private set => salary = value; }

        public override string ToString()
        {
            return base.ToString() + $" Salary: {this.Salary:F2}";
        }
    }
}
