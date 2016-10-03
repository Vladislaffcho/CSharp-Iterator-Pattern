using System.Collections.Generic;

namespace IteratorPattern
{
    public class MyAggregate<TType> : IAggregate<TType> where TType : class 
    {
         private readonly List<TType>  _items = new List<TType>();

        public IIterate<TType> CreateIterator()
        {
            return new MyIterator<TType>(this);
        }

        public int Count()
        {
            return _items.Count;
        }

        public void Add(TType entity)
        {
            _items.Add(entity);
        }

        public TType this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }
}