namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Fighter : BaseMachine, IFighter
    {
        private const double InitialHealthPoints = 200;
        private const double AggressiveModeAttackPoints = 50;
        private const double AgrressiveModeDefencePoints = 25;

        public Fighter(string name, double attackPoints, double defensePoints) : base(name, InitialHealthPoints, attackPoints, defensePoints)
        {
        }

        public bool AggressiveMode => true;

        public void ToggleAggressiveMode()
        {
            if (AggressiveMode == false)
            {
                AttackPoints -= AggressiveModeAttackPoints;
                AttackPoints -= AgrressiveModeDefencePoints;
            }
            else if (AggressiveMode == true)
            {
                AttackPoints += AggressiveModeAttackPoints;
                DefensePoints -= AgrressiveModeDefencePoints;
            }
        }
        public override string ToString()
        {
            if (AggressiveMode == false)
            {
                return " *Aggressive: OF";
            }
            return " *Aggressive: ON";
        }
    }
}
