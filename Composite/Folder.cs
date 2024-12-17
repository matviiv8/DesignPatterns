namespace Composite
{
    public class Folder : FileSystemItem
    {
        private readonly List<FileSystemItem> _items = new List<FileSystemItem>();

        public Folder(string name) : base(name) { }

        public override void Add(FileSystemItem item)
        {
            _items.Add(item);
        }

        public override void Remove(FileSystemItem item)
        {
            _items.Remove(item);
        }

        public override void Display(int indent = 0)
        {
            Console.WriteLine(new string(' ', indent) + _name);
            foreach (var item in _items)
            {
                item.Display(indent + 2);
            }
        }
    }
}
