using System;
using System.Collections.Generic;
using System.Text;

namespace Food_Shortage
{
    public interface IBuyer
    {
        void BuyFood();

        int Food { get; }

        string Name { get; }
    }
}
