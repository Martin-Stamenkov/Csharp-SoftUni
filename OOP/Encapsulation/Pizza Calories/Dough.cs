using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public class Dough
    {
        private double weight;
        private string flourType;
        private string flourBakingTehnique;


        public Dough(string flourType, string flourBakingTehnique, double weight)
        {
            this.FlourType = flourType;
            this.FlourBakingTehnique = flourBakingTehnique;
            this.Weight = weight;
        }
        
        public string  FlourType
        {
            get
            {
                return flourType;
            }
            set
            {
                if (!DoughRepository.IsValidFlourType(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourType = value;
            }
        }

        public string FlourBakingTehnique
        {
            get
            {
                return flourBakingTehnique;
            }

            set
            {
                if (!DoughRepository.IsValidBakingTechnique(value))
                {
                    throw new ArgumentException("Invalid type of dough.");
                }
                flourBakingTehnique = value;
            }

        }

        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value < 1 || value > 200)
                {
                    throw new ArgumentException("Dough weight should be in the range[1..200].");
                }
                weight = value;
            }
        }
        public double GetTotalCalories()
        {
            return 2 * Weight * DoughRepository.GetBakingModifier(this.FlourBakingTehnique) * DoughRepository.GetFlourModifier(this.FlourType);
        }

    }
}
