namespace AbstractFactory
{
    public class TruckWheels : IWheels
    {
        public string GetSpecifications()
        {
            return "Truck Wheels: 22 inches.";
        }
    }
}
