using Mediator;

class Program
{
    static void Main(string[] args)
    {
        IChatMediator chatMediator = new ChatMediator();
        var user1 = new ChatUser(chatMediator, "Alice");
        var user2 = new ChatUser(chatMediator, "Bob");
        var user3 = new ChatUser(chatMediator, "Charlie");

        chatMediator.AddUser(user1);
        chatMediator.AddUser(user2);
        chatMediator.AddUser(user3);

        user1.SendMessage("Hello everyone!");
        user2.SendMessage("Hi Alice!");
        user3.SendMessage("Good to see you all!");
    }
}