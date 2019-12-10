namespace MortalEngines.Entities
{
    using MortalEngines.Entities.Contracts;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Tank : BaseMachine,ITank
    {

        private const double InitialHealthPoints = 100;
        private const double DefenceModePoints = 30;
        private const double DefenceModeAttackPoints = 40;

        public Tank(string name, double attackPoints, double defensePoints) : base(name, InitialHealthPoints, attackPoints, defensePoints)
        {
        }

        public bool DefenseMode => true;

        public void ToggleDefenseMode()
        {
            if (DefenseMode == true)
            {
                AttackPoints -= DefenceModeAttackPoints;
                DefensePoints += DefenceModePoints;
            }
            else if (DefenseMode == false)
            {
                AttackPoints += DefenceModeAttackPoints;
                DefensePoints -= DefenceModePoints;
            }
        }
        public override string ToString()
        {
            if (DefenseMode == true)
            {
                return " *Defense: ON";
            }          
                return " * Defense: OF";
        }
    }
}
