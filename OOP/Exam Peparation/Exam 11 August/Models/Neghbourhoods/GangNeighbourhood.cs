using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ViceCity.Models.Neghbourhoods.Contracts;
using ViceCity.Models.Players.Contracts;

namespace ViceCity.Models.Neghbourhoods
{
    public class GangNeighbourhood : INeighbourhood
    {
        public void Action(IPlayer mainPlayer, ICollection<IPlayer> civilPlayers)
        {
            while (civilPlayers.Count > 0)
            {
                var gun = mainPlayer.GunRepository.Models.FirstOrDefault(g => g.CanFire == true);

                if (gun == null)
                {
                    break;
                }

                var civilPlayer = civilPlayers.FirstOrDefault(c=>c.IsAlive== true);

                if (civilPlayer ==null)
                {
                    break;
                }

                var damage = gun.Fire();
                civilPlayer.TakeLifePoints(damage);
            }

            while (mainPlayer.IsAlive && civilPlayers.Any())
            {
                var civilPlayer = civilPlayers.FirstOrDefault(c => c.IsAlive == true);

                if (civilPlayer == null)
                {
                    break;
                }

                var gun = civilPlayer.GunRepository.Models.FirstOrDefault(g => g.CanFire == true);

                if (gun == null)
                {
                    break;
                }

                var damage = gun.Fire();
                mainPlayer.TakeLifePoints(damage);

                if (mainPlayer.IsAlive == false)
                {
                    break;
                }

            }
        }
    }
}
