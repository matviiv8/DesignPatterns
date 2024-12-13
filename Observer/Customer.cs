namespace Observer
{
    public class Customer : IObserver
    {
        public string Name { get; }

        public Customer(string name)
        {
            Name = name;
        }

        public void Update(string message)
        {
            Console.WriteLine($"{Name} received notification: {message}");
        }
    }
}
