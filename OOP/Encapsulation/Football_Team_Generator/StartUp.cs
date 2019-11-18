using System;
using System.Collections.Generic;
using System.Linq;

namespace Football_Team_Generator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();

            var command = Console.ReadLine();

            while (command != "END")
            {
                var tokens = command.
                    Split(";", StringSplitOptions.RemoveEmptyEntries);

                var currentCommand = tokens[0];
                var teamName = tokens[1];

                try
                {
                    if (currentCommand == "Team")
                    {
                        teams.Add(new Team(teamName));
                    }
                    if (currentCommand == "Add")
                    {
                        var containsName = teams.FirstOrDefault(x => x.Name == teamName);

                        if (containsName != null)
                        {
                            var name = tokens[2];
                            var endurance = int.Parse(tokens[3]);
                            var sprint = int.Parse(tokens[4]);
                            var dribble = int.Parse(tokens[5]);
                            var passing = int.Parse(tokens[6]);
                            var shooting = int.Parse(tokens[7]);
                            Player player = new Player(name, endurance, sprint, dribble, passing, shooting);
                            containsName.AddPlayer(player);
                        }
                        else
                        {
                            throw new ArgumentException($"Team {teamName} does not exist.");
                        }
                    }
                    else if (currentCommand == "Remove")
                    {
                        var containsName = teams.FirstOrDefault(x => x.Name == teamName);
                        var currentTeam = tokens[1];
                        var name = tokens[2];
                        containsName.RemovePlayer(name);
                    }
                    else if (currentCommand == "Rating")
                    {
                        var containsName = teams.FirstOrDefault(x => x.Name == teamName);
                        var currentTeam = tokens[1];
                        if (containsName != null)
                        {

                            Console.WriteLine($"{containsName.Name} - {containsName.Raiting}");
                        }
                        else
                        {
                            throw new ArgumentException($"Team {currentTeam} does not exist.");
                        }
       
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                command = Console.ReadLine();
            }
        }
    }
}
