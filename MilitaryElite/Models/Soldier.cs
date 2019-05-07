using MilitaryElite.IContracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Soldier : ISoldier
    {
        private string firstName;
        private string lastName;
        private int id;

        public Soldier(string firstName, string lastName, int id)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Id = id;
        }
        //TODO add validation

        public string FirstName { get => firstName;private set => firstName = value; }
        public string LastName { get => lastName; private set => lastName = value; }
        public int Id { get => id; private set => id = value; }

        public override string ToString()
        {
            return $"Name: {this.FirstName} {this.LastName} Id: {this.Id}";
        }
    }
}
