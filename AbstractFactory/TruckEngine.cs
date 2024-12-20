namespace AbstractFactory
{
    public class TruckEngine : IEngine
    {
        public string GetSpecifications()
        {
            return "Truck Engine: 5.0L, 6 cylinders.";
        }
    }
}
