namespace FactoryMethod
{
    public class SmsMessageCreator : MessageCreator
    {
        public override IMessage CreateMessage()
        {
            return new SmsMessage();
        }
    }
}