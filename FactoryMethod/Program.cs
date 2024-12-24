using FactoryMethod;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("App: Sending an SMS message.");
        MessageCreator smsCreator = new SmsMessageCreator();
        smsCreator.SendMessage("123-456-789", "Hello via SMS!");

        Console.WriteLine();

        Console.WriteLine("App: Sending an Email message.");
        MessageCreator emailCreator = new EmailMessageCreator();
        emailCreator.SendMessage("example@example.com", "Hello via Email!");
    }
}