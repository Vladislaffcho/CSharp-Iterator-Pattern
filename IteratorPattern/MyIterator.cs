namespace IteratorPattern
{
    public class MyIterator<TEntity> : IIterate<TEntity> where TEntity : class
    {
        private readonly IAggregate<TEntity> _aggregate;
        private int _current;

        public MyIterator(IAggregate<TEntity> aggregate)
        {
            _aggregate = aggregate;
        }

        public TEntity First()
        {
            return _aggregate[0];
        }

        public TEntity MoveNext()
        {
            _current++;
            return _current < _aggregate.Count() ? _aggregate[_current] : null;
        }

        public bool IsDone() => _current >= _aggregate.Count();

        public TEntity CurrentItem() => _aggregate[_current];
    }
}