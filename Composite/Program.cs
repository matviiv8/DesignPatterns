using Composite;
using File = Composite.File;

class Program
{
    static void Main(string[] args)
    {
        var root = new Folder("Root");

        var folder1 = new Folder("Folder1");
        folder1.Add(new File("File1_1.txt"));
        folder1.Add(new File("File1_2.txt"));

        var folder2 = new Folder("Folder2");
        folder2.Add(new File("File2_1.txt"));

        var subFolder = new Folder("SubFolder");
        subFolder.Add(new File("FileSub_1.txt"));
        folder2.Add(subFolder);

        root.Add(folder1);
        root.Add(folder2);
        root.Add(new File("RootFile.txt"));

        Console.WriteLine("File System Structure:");
        root.Display();
    }
}