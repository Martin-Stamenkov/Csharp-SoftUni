using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Pistol : Gun
    {
        private const int InitialBulletsPerBarrel = 10;
        private const int InitialtotalBullets = 100;
        private const int InitialDamage = 1;

        public Pistol(string name) 
            : base(name, InitialBulletsPerBarrel, InitialtotalBullets)
        {
        }

        public override int Fire()
        {
            if (BulletsPerBarrel - InitialDamage <= 0 && TotalBullets > 0)
            {
                BulletsPerBarrel--;
                BulletsPerBarrel = InitialBulletsPerBarrel;
                TotalBullets -= InitialBulletsPerBarrel;
                return InitialDamage;
            }
            if (CanFire == true)
            {
                BulletsPerBarrel--;
                return InitialDamage;
            }
            return 0;
        }
    }
}
