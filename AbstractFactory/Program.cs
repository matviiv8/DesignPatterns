using AbstractFactory;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Car:");
        Client carClient = new Client(new CarFactory());
        carClient.DescribeVehicle();

        Console.WriteLine("\nTruck:");
        Client truckClient = new Client(new TruckFactory());
        truckClient.DescribeVehicle();
    }
}