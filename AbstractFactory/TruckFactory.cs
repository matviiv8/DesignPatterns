namespace AbstractFactory
{
    public class TruckFactory : IVehicleFactory
    {
        public IEngine CreateEngine()
        {
            return new TruckEngine();
        }

        public IWheels CreateWheels()
        {
            return new TruckWheels();
        }
    }
}
