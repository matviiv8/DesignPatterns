namespace AbstractFactory
{
    public class CarWheels : IWheels
    {
        public string GetSpecifications()
        {
            return "Car Wheels: 15 inches.";
        }
    }
}
