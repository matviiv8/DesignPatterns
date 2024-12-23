namespace Flyweight
{
    public class CarTypeFactory
    {
        private readonly Dictionary<string, CarType> _carTypes = new Dictionary<string, CarType>();

        public CarType GetCarType(string make, string model, string color)
        {
            string key = $"{make}_{model}_{color}";

            if (!_carTypes.ContainsKey(key))
            {
                Console.WriteLine($"CarTypeFactory: Creating new CarType: {key}");
                _carTypes[key] = new CarType(make, model, color);
            }
            else
            {
                Console.WriteLine($"CarTypeFactory: Reusing existing CarType: {key}");
            }

            return _carTypes[key];
        }
    }
}