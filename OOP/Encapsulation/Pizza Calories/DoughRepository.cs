using System;
using System.Collections.Generic;
using System.Text;

namespace Pizza_Calories
{
    public static class DoughRepository
    {
       private static Dictionary<string, double> doughType;
       private static Dictionary<string, double> bakingTechnique;

        public static bool IsValidFlourType(string key)
        {
            Initilaize();
            return doughType.ContainsKey(key.ToLower());
        }
        public static bool IsValidBakingTechnique(string key)
        {
            Initilaize();
            return bakingTechnique.ContainsKey(key.ToLower());
        }

        public static void Initilaize()
        {

            if (doughType != null && bakingTechnique != null)
            {
                return;
            }

            doughType = new Dictionary<string, double>();
            bakingTechnique = new Dictionary<string, double>();

            doughType.Add("white", 1.5);
            doughType.Add("wholegrain", 1);
            
            bakingTechnique.Add("crispy",0.9);
            bakingTechnique.Add("chewy",1.1);
            bakingTechnique.Add("homemade",1);
        }


        public static double GetFlourModifier(string type)
        {
           Initilaize();
           return doughType[type.ToLower()];
        }

        public static double GetBakingModifier(string type)
        {
            Initilaize();
            return bakingTechnique[type.ToLower()];
        }
    }
}
