namespace Adapter
{
    public class PrinterAdapter : IPrint
    {
        private readonly OldPrinter _oldPrinter;

        public PrinterAdapter(OldPrinter oldPrinter)
        {
            _oldPrinter = oldPrinter;
        }

        public void Print(string message)
        {
            _oldPrinter.ShowText(message);
        }
    }
}
