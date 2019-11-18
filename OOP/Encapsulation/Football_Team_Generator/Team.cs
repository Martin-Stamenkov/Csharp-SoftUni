using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Football_Team_Generator
{
    public class Team 
    {
        private string name;

        private List<Player> team;

        public Team(string teamName)
        {
            Name = teamName;
            team = new List<Player>();
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("A name should not be empty.");
                }
                name = value;
            }
        }

        public int Raiting => TeamRating();
        public int TeamRating()
        {
            if (team.Any())
            {
                return (int)Math.Round(team.Average(x => x.SkillPlayerRaiting));
                
            }
            throw new ArgumentException($"{Name} - 0");
        }

        public void AddPlayer(Player player)
        {
            team.Add(player);
        }

        public void RemovePlayer(string name)
        {
            foreach (var eachPlayer in team.ToList())
            {
                if (eachPlayer.Name == name)
                {
                    team.Remove(eachPlayer);
                    return;
                }
            }
            throw new ArgumentException($"Player {name} is not in {Name} team.");
        }
    }
   
}
