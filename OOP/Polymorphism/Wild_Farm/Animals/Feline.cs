namespace Wild_Farm.Animals
{
    public abstract class Feline : Mammal
    {
        private string breed;

        protected Feline(string animalType, string name, double weight, string livingRegion, string breed) 
            : base(animalType, name, weight, livingRegion)
        {
            Breed = breed;
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }
        public override string ToString()
        {
            return $"{AnimalType} [{Name}, {Breed}, {Weight}, {LivingRegion}, {FoodEaten}]";
        }
    }
}
