using State;

class Program
{
    static void Main(string[] args)
    {
        var document = new DocumentContext(new DraftState());

        document.Publish();
        document.Publish();
        document.Reject();
    }
}