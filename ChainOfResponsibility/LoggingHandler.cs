namespace ChainOfResponsibility
{
    public class LoggingHandler : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Log")
            {
                Console.WriteLine("Action logged.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}