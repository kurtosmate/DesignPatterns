namespace DesignPatterns.Visitor
{
    /// <summary>

    /// The 'Element' abstract class

    /// </summary>

    abstract class Element

    {
        public abstract void Accept(Visitor visitor);
    }
}
