using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;

        public Team(string name)
        {
            this.name = name;
            this.players = new List<Player>();
        }

        public string Name { get => name; set => name = value; }
        public List<Player> Players { get => players; set => players = value; }

        public void AddPlayer(Player player)
        {
            this.Players.Add(player);
        }

        public void RemovePlayer(Player player)
        {

            this.Players.Remove(player);

        }

        public override string ToString()
        {
            return $"{this.Name} - {(this.Players.Sum(x => x.Overal)) / this.Players.Count}";
        }
    }
}
