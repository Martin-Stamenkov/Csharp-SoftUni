
namespace Ferrari
{

    public class Ferrari : ICar
    {

        public Ferrari(string model, string name)
        {
            Driver = name;
            Model = model;
        }

        public string Model { get; private set; }

        public string Driver { get; private set; }

        public string Brakes()
        {
            return "Brakes";
        }

        public string Gas()
        {
            return "Gas";
        }

        public override string ToString()
        {
            return $"{Model}/{Brakes()}!/{Gas()}!/{Driver}".ToString();
        }

    }
}
