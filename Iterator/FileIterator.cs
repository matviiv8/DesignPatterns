namespace Iterator
{
    public class FileIterator : IIterator
    {
        private readonly FileCollection _collection;
        private readonly bool _reverse;
        private int _position;

        public FileIterator(FileCollection collection, bool reverse = false)
        {
            _collection = collection;
            _reverse = reverse;
            _position = reverse ? _collection.GetFiles().Count : -1;
        }

        public bool HasNext()
        {
            return _reverse ? _position > 0 : _position < _collection.GetFiles().Count - 1;
        }

        public string Next()
        {
            _position += _reverse ? -1 : 1;
            return _collection.GetFiles()[_position];
        }
    }
}
