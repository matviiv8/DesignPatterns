namespace AbstractFactory
{
    public interface IVehicleFactory
    {
        IEngine CreateEngine();
        IWheels CreateWheels();
    }
}
