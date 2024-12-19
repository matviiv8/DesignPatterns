namespace Iterator
{
    public class FileCollection : IAggregate
    {
        private readonly List<string> _files = new List<string>();

        public FileCollection(string directoryPath, string fileExtension)
        {
            if (Directory.Exists(directoryPath))
            {
                _files.AddRange(Directory.GetFiles(directoryPath, $"*{fileExtension}"));
            }
        }

        public List<string> GetFiles()
        {
            return _files;
        }

        public IIterator CreateIterator(bool reverse = false)
        {
            return new FileIterator(this, reverse);
        }
    }
}
