using AquaShop.Models.Decorations.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AquaShop.Models.Decorations
{
    public abstract class Decoration : IDecoration
    {
        private decimal price;
        private int comfort;

        protected Decoration(int comfort, decimal price)
        {
            Price = price;
            Comfort = comfort;
        }

        public decimal Price
        {
            get;
        }
        public int Comfort
        {
            get;
        }

    }
}
