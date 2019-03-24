using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static List<Team> teams;

        static void Main(string[] args)
        {
            string input = "";
            teams = new List<Team>();

            while (input != "END")
            {
                input = Console.ReadLine();
                string[] inputSplited = input.Split(';', StringSplitOptions.RemoveEmptyEntries);

                switch (inputSplited[0])
                {

                    case "Team":

                        string name = inputSplited[1];
                        Team team = new Team(name);
                        AddTeamToOurList(team);
                        break;
                    case "Add":
                        string teamName = inputSplited[1];
                        string playerName = inputSplited[2];
                        int endurance = int.Parse(inputSplited[3]);
                        int sprint = int.Parse(inputSplited[4]);
                        int dribble = int.Parse(inputSplited[5]);
                        int passing = int.Parse(inputSplited[6]);
                        int shooting = int.Parse(inputSplited[7]);

                        Player player = new Player(playerName, endurance, sprint, dribble, passing, shooting);
                        AddPlayerToTeam(teamName, player);

                        break;
                    case "Remove":
                        string remTeam = inputSplited[1];
                        string remPlayer = inputSplited[2];

                        RemovePlayer(remTeam, remPlayer);

                        break;
                    case "Rating":
                        string printTeamName = inputSplited[1];
                        PrintRating(printTeamName);
                        
                        break;
                    default:
                        break;
                }
            }
        }

        private static void PrintRating(string printTeamName)
        {
            Team printTeam = teams.FirstOrDefault(n => n.Name == printTeamName);

            if (!(printTeam == null))
            {
                Console.WriteLine(printTeam);
            }
            else
            {
                Console.WriteLine($"Team {printTeamName} does not exist.");
            }

        }

        private static void RemovePlayer(string remTeam, string remPlayer)
        {
            Team team = teams.FirstOrDefault(n => n.Name == remTeam);

            if (!(team == null))
            {
                Player player = team.Players.FirstOrDefault(x => x.Name == remPlayer);

                if (!(player == null))
                {
                    teams.FirstOrDefault(x => x.Name == remTeam).RemovePlayer(player);
                }
                else
                {
                    Console.WriteLine($"Player {remPlayer} is not in {remTeam} team.");
                }
            }
        }

        private static void AddPlayerToTeam(string teamName, Player player)
        {
            bool isConteinTeam = teams.Where(n => n.Name == teamName).Any();
            if (isConteinTeam)
            {
                teams.FirstOrDefault(n => n.Name == teamName).AddPlayer(player);
            }
            else
            {
                Console.WriteLine($"Team {teamName} does not exist.");
            }

        }

        private static void AddTeamToOurList(Team team)
        {
            if (!teams.Contains(team))
            {
                teams.Add(team);
            }
        }
    }
}
