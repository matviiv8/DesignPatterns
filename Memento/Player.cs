namespace Memento
{
    public class Player
    {
        private int _health;
        private int _level;
        private string _position;

        public Player(int health, int level, string position)
        {
            _health = health;
            _level = level;
            _position = position;
        }

        public void ShowStatus()
        {
            Console.WriteLine($"Player Status: Health = {_health}, Level = {_level}, Position = {_position}");
        }

        public void UpdateState(int health, int level, string position)
        {
            _health = health;
            _level = level;
            _position = position;
            Console.WriteLine("Player: State updated.");
        }

        public Memento Save()
        {
            Console.WriteLine("Player: Saving current state...");
            return new Memento(_health, _level, _position);
        }

        public void Restore(Memento memento)
        {
            _health = memento.GetHealth();
            _level = memento.GetLevel();
            _position = memento.GetPosition();
            Console.WriteLine("Player: State restored.");
        }
    }
}