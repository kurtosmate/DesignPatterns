namespace DesignPatterns.FactoryMethod
{
    /// <summary>

    /// A 'ConcreteCreator' class

    /// </summary>

    class ChocolateCakeCreator : CakeCreator

    {
        public override Product FactoryMethod()
        {
            return new ChocolateCakeProduct();
        }
    }
}
