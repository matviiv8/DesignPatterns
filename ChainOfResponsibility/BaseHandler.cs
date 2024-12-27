namespace ChainOfResponsibility
{
    public abstract class BaseHandler : IHandler
    {
        protected IHandler _nextHandler;

        public void SetNext(IHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public virtual void HandleRequest(string request)
        {
            if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(request);
            }
            else
            {
                Console.WriteLine($"No handler found for {request}.");
            }
        }
    }
}