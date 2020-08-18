namespace DesignPatterns.Builder
{
    /// <summary>

    /// The 'Builder' abstract class

    /// </summary>

    abstract class Builder

    {
        public abstract void BuildDoors();
        public abstract void BuildEngine();
        public abstract Car GetResult();
    }
}
