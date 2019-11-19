namespace Wild_Farm.Animals
{
    public abstract class Mammal : Animal
    {
        private string  livingRegion;

        protected Mammal(string animalType, string name, double weight, string livingRegion) 
            : base(animalType,name, weight)
        {
            LivingRegion = livingRegion;
        }

        public string  LivingRegion
        {
            get { return livingRegion; }
            set { livingRegion = value; }
        }

    }
}
