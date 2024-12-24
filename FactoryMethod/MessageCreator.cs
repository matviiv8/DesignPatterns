namespace FactoryMethod
{
    public abstract class MessageCreator
    {
        public abstract IMessage CreateMessage();

        public void SendMessage(string recipient, string content)
        {
            var message = CreateMessage();
            message.Send(recipient, content);
        }
    }
}