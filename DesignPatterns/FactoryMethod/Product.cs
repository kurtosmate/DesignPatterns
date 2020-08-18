namespace DesignPatterns.FactoryMethod
{
    /// <summary>

    /// The 'Product' abstract class

    /// </summary>

    abstract class Product
    {
        public abstract int Calories { get; }

        public abstract void Bake();
    }
}
