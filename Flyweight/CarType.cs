namespace Flyweight
{
    public class CarType
    {
        public string Make { get; }
        public string Model { get; }
        public string Color { get; }

        public CarType(string make, string model, string color)
        {
            Make = make;
            Model = model;
            Color = color;
        }

        public void Display(string owner, string licensePlate)
        {
            Console.WriteLine($"Car: {Make} {Model} ({Color}) | Owner: {owner}, License Plate: {licensePlate}");
        }
    }
}