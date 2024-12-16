namespace Mediator
{
    public abstract class User
    {
        protected IChatMediator _mediator;
        public string Name { get; }

        protected User(IChatMediator mediator, string name)
        {
            _mediator = mediator;
            Name = name;
        }

        public abstract void SendMessage(string message);
        public abstract void ReceiveMessage(string message, string senderName);
    }
}
