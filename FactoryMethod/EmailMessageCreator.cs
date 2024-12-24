namespace FactoryMethod
{
    public class EmailMessageCreator : MessageCreator
    {
        public override IMessage CreateMessage()
        {
            return new EmailMessage();
        }
    }
}