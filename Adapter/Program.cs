using Adapter;

class Program
{
    static void Main(string[] args)
    {
        OldPrinter oldPrinter = new OldPrinter();
        IPrint adapter = new PrinterAdapter(oldPrinter);

        Client client = new Client(adapter);
        client.Execute();
    }
}
