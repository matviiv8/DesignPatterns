namespace Observer
{
    public class OnlineStore : ISubject
    {
        private List<IObserver> _observers = new List<IObserver>();

        public void Attach(IObserver observer)
        {
            _observers.Add(observer);
            Console.WriteLine("OnlineStore: Added a subscriber.");
        }

        public void Detach(IObserver observer)
        {
            _observers.Remove(observer);
            Console.WriteLine("OnlineStore: Removed a subscriber.");
        }

        public void Notify(string message)
        {
            Console.WriteLine("OnlineStore: Notifying subscribers...");
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
        public void AddNewProduct(string productName)
        {
            Console.WriteLine($"OnlineStore: A new product has been added: {productName}");
            Notify($"New product available: {productName}");
        }

        public void AnnounceDiscount(string discountDetails)
        {
            Console.WriteLine("OnlineStore: A discount has been announced.");
            Notify($"Special discount: {discountDetails}");
        }
    }
}
