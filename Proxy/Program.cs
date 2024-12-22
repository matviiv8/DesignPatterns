using Proxy;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Client: Trying to access the file as a Guest:");
        IFileAccess guestProxy = new FileAccessProxy("Guest");
        guestProxy.ReadFile("data.txt");

        Console.WriteLine();

        Console.WriteLine("Client: Trying to access the file as an Admin:");
        IFileAccess adminProxy = new FileAccessProxy("Admin");
        adminProxy.ReadFile("data.txt");
    }
}