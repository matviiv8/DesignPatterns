namespace Composite
{
    public class File : FileSystemItem
    {
        public File(string name) : base(name) { }

        public override void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + _name);
        }
    }
}
