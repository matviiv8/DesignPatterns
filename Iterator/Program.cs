using Iterator;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the directory path:");
        string directoryPath = Console.ReadLine();

        Console.WriteLine("Enter the file extension (e.g., .txt):");
        string fileExtension = Console.ReadLine();
        var fileCollection = new FileCollection(directoryPath, fileExtension);

        if (fileCollection.GetFiles().Count == 0)
        {
            Console.WriteLine($"No files with the extension '{fileExtension}' found in the directory '{directoryPath}'.");
            return;
        }

        Console.WriteLine("\nTraversing files in forward order:");
        var iterator = fileCollection.CreateIterator();
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Next());
        }

        Console.WriteLine("\nTraversing files in reverse order:");
        var reverseIterator = fileCollection.CreateIterator(reverse: true);
        while (reverseIterator.HasNext())
        {
            Console.WriteLine(reverseIterator.Next());
        }
    }
}
