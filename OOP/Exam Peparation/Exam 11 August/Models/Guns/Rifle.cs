using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Guns
{
    public class Rifle : Gun
    {
        private const int InitialBulletsPerBarrel = 50;
        private const int InitialtotalBullets = 500;
        private const int InitialDamage = 5;


        public Rifle(string name) 
            : base(name, InitialBulletsPerBarrel, InitialtotalBullets)
        {
        }

        public override int Fire()
        {
            if (BulletsPerBarrel - InitialDamage <= 0 && TotalBullets > 0)
            {
                BulletsPerBarrel -= InitialDamage;
                BulletsPerBarrel = InitialBulletsPerBarrel;
                TotalBullets -= InitialBulletsPerBarrel;
                return InitialDamage;
            }
            if (CanFire == true)
            {
                BulletsPerBarrel -= InitialDamage;
                return InitialDamage;
            }
            return 0;
        }
    }
}
