using ChainOfResponsibility;

class Program
{
    static void Main()
    {
        var authHandler = new AuthenticationHandler();
        var authorizationHandler = new AuthorizationHandler();
        var loggingHandler = new LoggingHandler();

        authHandler.SetNext(authorizationHandler);
        authorizationHandler.SetNext(loggingHandler);

        Console.WriteLine("Sending 'Authenticate' request:");
        authHandler.HandleRequest("Authenticate");

        Console.WriteLine("\nSending 'Authorize' request:");
        authHandler.HandleRequest("Authorize");

        Console.WriteLine("\nSending 'Log' request:");
        authHandler.HandleRequest("Log");

        Console.WriteLine("\nSending 'Unknown' request:");
        authHandler.HandleRequest("Unknown");
    }
}