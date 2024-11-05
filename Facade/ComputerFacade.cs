namespace Facade
{
    public class ComputerFacade
    {
        private readonly PowerSupply _powerSupply;
        private readonly HardwareCheck _hardwareCheck;
        private readonly OSLoader _osLoader;

        public ComputerFacade()
        {
            _powerSupply = new PowerSupply();
            _hardwareCheck = new HardwareCheck();
            _osLoader = new OSLoader();
        }

        public void StartComputer()
        {
            _powerSupply.TurnOn();
            _hardwareCheck.CheckConnections();
            _hardwareCheck.TestHardware();
            _osLoader.LoadOS();
            Console.WriteLine("Computer is up and running!");
        }

        public void ShutDownComputer()
        {
            Console.WriteLine("Shutting down the computer...");
            _powerSupply.TurnOff();
        }
    }
}
