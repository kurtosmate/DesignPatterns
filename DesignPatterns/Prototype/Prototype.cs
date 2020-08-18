namespace DesignPatterns.Prototype
{
    /// <summary>

    /// The 'Prototype' abstract class

    /// </summary>

    abstract class Prototype

    {
        
        public string Flavour { get; }
        public bool WithLactoseFree { get; }

        // Constructor

        public Prototype(string flavour, bool withLactoseFree)
        {
            Flavour = flavour;
            WithLactoseFree = withLactoseFree;
        }



        public abstract Prototype Clone();
    }
}
