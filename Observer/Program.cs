using Observer;

class Program
{
    static void Main(string[] args)
    {
        var store = new OnlineStore();

        var customer1 = new Customer("Alice");
        var customer2 = new Customer("Bob");

        store.Attach(customer1);
        store.Attach(customer2);

        store.AddNewProduct("Smartphone X1");

        store.Detach(customer1);

        store.AnnounceDiscount("20% off on all electronics!");
    }
}