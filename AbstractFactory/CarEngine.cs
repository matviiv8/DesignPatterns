namespace AbstractFactory
{
    public class CarEngine : IEngine
    {
        public string GetSpecifications()
        {
            return "Car Engine: 1.6L, 4 cylinders.";
        }
    }
}
