namespace DesignPatterns.Prototype
{
    /// <summary>

    /// A 'ConcretePrototype' class 

    /// </summary>

    class CoffeePrototype : Prototype

    {
        // Constructor

        public CoffeePrototype(string flavour, bool withLactoseFree)
          : base(flavour, withLactoseFree)
        {
        }

        // Returns a shallow copy

        public override Prototype Clone()
        {
            return (Prototype)this.MemberwiseClone();
        }

        public override string ToString()
        {
            if (WithLactoseFree)
            {
                return $"Lactose free {this.Flavour}";
            }
            else
            {

                return $"{this.Flavour}";
            }
        }
    }
}
