namespace Composite
{
    public abstract class FileSystemItem
    {
        protected string _name;

        protected FileSystemItem(string name)
        {
            _name = name;
        }

        public abstract void Display(int indent = 0);

        public virtual void Add(FileSystemItem item)
        {
            throw new NotImplementedException("Cannot add item to this type.");
        }

        public virtual void Remove(FileSystemItem item)
        {
            throw new NotImplementedException("Cannot remove item from this type.");
        }
    }
}
