namespace Memento
{
    public class Memento
    {
        private readonly int _health;
        private readonly int _level;
        private readonly string _position;

        public Memento(int health, int level, string position)
        {
            _health = health;
            _level = level;
            _position = position;
        }

        public int GetHealth() => _health;
        public int GetLevel() => _level;
        public string GetPosition() => _position;
    }
}