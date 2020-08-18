namespace DesignPatterns.Iterator
{
    /// <summary>

    /// The 'Iterator' abstract class

    /// </summary>

    abstract class Iterator

    {
        public abstract object First();
        public abstract object Next();
        public abstract bool HasNext();
        public abstract object CurrentItem();

    }
}
