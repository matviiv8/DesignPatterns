namespace ChainOfResponsibility
{
    public class AuthenticationHandler : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Authenticate")
            {
                Console.WriteLine("Authentication successful.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}