namespace Mediator
{
    public class ChatUser : User
    {
        public ChatUser(IChatMediator mediator, string name) : base(mediator, name) { }

        public override void SendMessage(string message)
        {
            Console.WriteLine($"{Name} sends: {message}");
            _mediator.SendMessage(message, this);
        }

        public override void ReceiveMessage(string message, string senderName)
        {
            Console.WriteLine($"{Name} receives from {senderName}: {message}");
        }
    }
}
