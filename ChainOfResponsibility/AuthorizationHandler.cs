namespace ChainOfResponsibility
{
    public class AuthorizationHandler : BaseHandler
    {
        public override void HandleRequest(string request)
        {
            if (request == "Authorize")
            {
                Console.WriteLine("Authorization granted.");
            }
            else
            {
                base.HandleRequest(request);
            }
        }
    }
}