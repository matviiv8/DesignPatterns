namespace AbstractFactory
{
    public class Client
    {
        private readonly IEngine _engine;
        private readonly IWheels _wheels;

        public Client(IVehicleFactory factory)
        {
            _engine = factory.CreateEngine();
            _wheels = factory.CreateWheels();
        }

        public void DescribeVehicle()
        {
            Console.WriteLine($"Engine: {_engine.GetSpecifications()}");
            Console.WriteLine($"Wheels: {_wheels.GetSpecifications()}");
        }
    }
}
