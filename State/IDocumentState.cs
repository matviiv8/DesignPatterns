namespace State
{
    public interface IDocumentState
    {
        void SetContext(DocumentContext context);
        void Publish();
        void Reject();
    }
}