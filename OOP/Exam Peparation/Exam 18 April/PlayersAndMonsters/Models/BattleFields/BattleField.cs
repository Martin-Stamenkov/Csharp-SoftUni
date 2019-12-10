using PlayersAndMonsters.Models.BattleFields.Contracts;
using PlayersAndMonsters.Models.Players;
using PlayersAndMonsters.Models.Players.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PlayersAndMonsters.Models.BattleFields
{
    public class BattleField : IBattleField
    {
        public void Fight(IPlayer attackPlayer, IPlayer enemyPlayer)
        {
            if (attackPlayer.IsDead || enemyPlayer.IsDead)
            {
                throw new ArgumentException("Player is dead!");
            }

            if (attackPlayer is Beginner)
            {
                attackPlayer.Health += 40;
                foreach (var card in attackPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }
            if (enemyPlayer is Beginner)
            {
                enemyPlayer.Health += 40;

                foreach (var card in enemyPlayer.CardRepository.Cards)
                {
                    card.DamagePoints += 30;
                }
            }

            int attackPlayerBonusHealth = attackPlayer.CardRepository.Cards.Sum(h => h.HealthPoints);
            int enemyPlayerBonusHealth = enemyPlayer.CardRepository.Cards.Sum(h => h.HealthPoints);

            attackPlayer.Health += attackPlayerBonusHealth;
            enemyPlayer.Health += enemyPlayerBonusHealth;

            int attackPlayerDamagePoints = attackPlayer.CardRepository.Cards.Sum(d => d.DamagePoints);
            int enemyPlayerDamagePoints = enemyPlayer.CardRepository.Cards.Sum(d => d.DamagePoints);

            while (true)
            {
                enemyPlayer.TakeDamage(attackPlayerDamagePoints);

                if (enemyPlayer.IsDead)
                {
                    break;
                }

                attackPlayer.TakeDamage(enemyPlayerDamagePoints);

                if (attackPlayer.IsDead)
                {
                    break;
                }

            }
        }
    }
}
