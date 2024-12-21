namespace State
{
    public class ModerationState : DocumentState
    {
        public override void Publish()
        {
            Console.WriteLine("Moderation: Publishing the document.");
            _context.TransitionTo(new PublishedState());
        }

        public override void Reject()
        {
            Console.WriteLine("Moderation: Rejecting the document. Returning to Draft.");
            _context.TransitionTo(new DraftState());
        }
    }
}