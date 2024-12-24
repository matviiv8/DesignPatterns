namespace FactoryMethod
{
    public class SmsMessage : IMessage
    {
        public void Send(string recipient, string content)
        {
            Console.WriteLine($"Sending SMS to {recipient}: {content}");
        }
    }
}