namespace Memento
{
    public class SaveManager
    {
        private readonly Stack<Memento> _saves = new();

        public void SaveGame(Memento memento)
        {
            _saves.Push(memento);
            Console.WriteLine("SaveManager: Game saved.");
        }

        public Memento LoadLastSave()
        {
            if (_saves.Count > 0)
            {
                Console.WriteLine("SaveManager: Loading last saved state...");
                return _saves.Pop();
            }

            throw new InvalidOperationException("No saved states available.");
        }
    }
}