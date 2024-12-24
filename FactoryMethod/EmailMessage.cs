namespace FactoryMethod
{
    public class EmailMessage : IMessage
    {
        public void Send(string recipient, string content)
        {
            Console.WriteLine($"Sending Email to {recipient}: {content}");
        }
    }
}