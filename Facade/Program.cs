using Facade;

class Program
{
    static void Main(string[] args)
    {
        ComputerFacade computer = new ComputerFacade();
        
        computer.StartComputer();
        computer.ShutDownComputer();
    }
}
