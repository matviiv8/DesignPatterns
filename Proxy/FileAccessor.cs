namespace Proxy
{
    public class FileAccessor : IFileAccess
    {
        public void ReadFile(string fileName)
        {
            Console.WriteLine($"FileAccessor: Reading file '{fileName}'...");
            Console.WriteLine($"File '{fileName}' read successfully.");
        }
    }
}