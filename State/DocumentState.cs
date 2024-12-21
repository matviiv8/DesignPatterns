namespace State
{
    public abstract class DocumentState : IDocumentState
    {
        protected DocumentContext _context;

        public void SetContext(DocumentContext context)
        {
            _context = context;
        }

        public abstract void Publish();
        public abstract void Reject();
    }
}