namespace Iterator
{
    public interface IAggregate
    {
        IIterator CreateIterator(bool reverse = false);
    }
}