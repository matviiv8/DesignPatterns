namespace ChainOfResponsibility
{
    public interface IHandler
    {
        void SetNext(IHandler nextHandler);
        void HandleRequest(string request);
    }
}