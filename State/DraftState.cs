namespace State
{
    public class DraftState : DocumentState
    {
        public override void Publish()
        {
            Console.WriteLine("Draft: Sending the document for moderation.");
            _context.TransitionTo(new ModerationState());
        }

        public override void Reject()
        {
            Console.WriteLine("Draft: The document is already in the initial state.");
        }
    }
}