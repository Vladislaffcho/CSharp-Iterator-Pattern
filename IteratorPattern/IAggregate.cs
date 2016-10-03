namespace IteratorPattern
{
    public interface IAggregate<TType>
    {
        IIterate<TType> CreateIterator();
        int Count();
        TType this[int index] { get; set; }
        void Add(TType entity);
    }
}