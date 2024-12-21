namespace State
{
    public class PublishedState : DocumentState
    {
        public override void Publish()
        {
            Console.WriteLine("Published: The document is already published.");
        }

        public override void Reject()
        {
            Console.WriteLine("Published: Archiving the document. Returning to Draft.");
            _context.TransitionTo(new DraftState());
        }
    }
}