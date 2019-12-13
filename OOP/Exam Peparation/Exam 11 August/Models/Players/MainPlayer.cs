using System;
using System.Collections.Generic;
using System.Text;

namespace ViceCity.Models.Players
{
    public class MainPlayer : Player
    {
        private const int InitialLifePoints = 100;

        public MainPlayer() 
            : base("Tommy Vercetti", InitialLifePoints)
        {
        }
    }
}
