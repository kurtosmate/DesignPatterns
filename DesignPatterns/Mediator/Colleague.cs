namespace DesignPatterns.Mediator
{
    /// <summary>

    /// The 'Colleague' abstract class

    /// </summary>

    public abstract class Colleague

    {
        public string Name { get; protected set; }
        protected Mediator mediator;

        // Constructor

        public Colleague(Mediator mediator)
        {
            this.mediator = mediator;
        }
    }
}
