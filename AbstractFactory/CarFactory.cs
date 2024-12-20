namespace AbstractFactory
{
    public class CarFactory : IVehicleFactory
    {
        public IEngine CreateEngine()
        {
            return new CarEngine();
        }

        public IWheels CreateWheels()
        {
            return new CarWheels();
        }
    }
}
