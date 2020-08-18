using System.Collections;

namespace DesignPatterns.Iterator
{
    /// <summary>

    /// The 'ConcreteAggregate' class

    /// </summary>

    class ConcreteAggregate : Aggregate

    {
        private ArrayList _items = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        // Gets item count

        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer

        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Insert(index, value); }
        }

    }
}
