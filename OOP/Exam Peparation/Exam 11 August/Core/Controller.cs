using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Core.Contracts;
using ViceCity.Models.Guns;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Models.Neghbourhoods;
using ViceCity.Models.Players;
using ViceCity.Models.Players.Contracts;
using ViceCity.Repositories;

namespace ViceCity.Core
{
    public class Controller : IController
    {
        private GunRepository gunRepository;
        private List<IPlayer> players;
        private GangNeighbourhood gangNeighbourhood;

        public Controller()
        {
            this.gunRepository = new GunRepository();
            this.gangNeighbourhood = new GangNeighbourhood();
            this.players = new List<IPlayer>();
            this.players.Add(new MainPlayer());
        }

        public string AddGun(string type, string name)
        {
            IGun gun;

            if (type == "Pistol")
            {
                gun = new Pistol(name);
                gunRepository.Add(gun);
            }
            else if (type == "Rifle")
            {
                gun = new Rifle(name);
                gunRepository.Add(gun);
            }
            else
            {
                return"Invalid gun type!";
            }
            return $"Successfully added {name} of type: {type}";
        }

        public string AddGunToPlayer(string name)
        {
            var gun = gunRepository.Models.FirstOrDefault(x=>x.CanFire);
            
            if (gun == null)
            {
                return "There are no guns in the queue!";
            }

            if (name == "Vercetti")
            {
                var mainPlayer = players.FirstOrDefault(x => x.Name == "Tommy Vercetti");
                mainPlayer.GunRepository.Add(gun);
                gunRepository.Remove(gun);
                return $"Successfully added {gun.Name} to the Main Player: Tommy Vercetti";
            }
            else 
            {
                var civilPlayer = players.FirstOrDefault(x => x.Name == name);
                if (civilPlayer == null)
                {
                    return "Civil player with that name doesn't exists!";
                }
                civilPlayer.GunRepository.Add(gun);
                gunRepository.Remove(gun);
                return $"Successfully added {gun.Name} to the Civil Player: {name}";
            }
        }

        public string AddPlayer(string name)
        {
            IPlayer player = new CivilPlayer(name);
            players.Add(player);

            return $"Successfully added civil player: {player.Name}!";

        }

        public string Fight()
        {
            var mainPlayer = (MainPlayer)players.FirstOrDefault(x => x.Name == "Tommy Vercetti");
            var civilPlayers = players.Where(x => x.Name != "Tommy Vercetti").ToList();

            StringBuilder sb = new StringBuilder();

            gangNeighbourhood.Action(mainPlayer, civilPlayers);

            bool noOneIsHarmedorDead = true;
            foreach (var civil in players)
            {
                if (civil.IsAlive == false)
                {
                    noOneIsHarmedorDead = false;
                    break;
                }
            }

            if (mainPlayer.LifePoints == 100 && noOneIsHarmedorDead == true)
            {
                return "Everything is okay!";
            }
            else
            {
                sb.AppendLine("A fight happened:");
                sb.AppendLine($"Tommy live points: { mainPlayer.LifePoints}!");
                sb.AppendLine($"Tommy has killed: {civilPlayers.Where(x=>x.IsAlive == false).Count()} players!");
                sb.AppendLine($"Left Civil Players: {civilPlayers.Where(x=>x.IsAlive).Count()}!");
            }
            return sb.ToString().TrimEnd();
        }
    }
}
