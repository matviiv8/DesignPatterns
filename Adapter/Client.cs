namespace Adapter
{
    public class Client
    {
        private readonly IPrint _printer;

        public Client(IPrint printer)
        {
            _printer = printer;
        }

        public void Execute()
        {
            _printer.Print("Hello, Adapter Pattern!");
        }
    }
}
