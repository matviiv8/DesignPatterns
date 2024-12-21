namespace State
{
    public class DocumentContext
    {
        private IDocumentState _state;

        public DocumentContext(IDocumentState state)
        {
            TransitionTo(state);
        }

        public void TransitionTo(IDocumentState state)
        {
            Console.WriteLine($"Transitioning to {state.GetType().Name}.");
            _state = state;
            _state.SetContext(this);
        }

        public void Publish()
        {
            _state.Publish();
        }

        public void Reject()
        {
            _state.Reject();
        }
    }
}