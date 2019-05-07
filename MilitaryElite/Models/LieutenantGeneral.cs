using MilitaryElite.IContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        private ICollection<IPrivate> squad;


        public LieutenantGeneral(string firstName, string lastName, int id, decimal salary) 
            :base(firstName,lastName,id,salary)
        {
            this.Squad = new List<IPrivate>();
        }

        
        public ICollection<IPrivate> Squad { get => squad; private set => squad = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nPrivates:{(this.Squad.Count == 0 ? "" : "\n  ")}{string.Join("\n  ",this.Squad)}";
        }
    }

    
}
