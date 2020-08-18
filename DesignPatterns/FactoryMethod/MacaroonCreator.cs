namespace DesignPatterns.FactoryMethod
{
    /// <summary>

    /// A 'ConcreteCreator' class

    /// </summary>

    class MacaroonCreator : CakeCreator

    {
        public override Product FactoryMethod()
        {
            return new MacaroonProduct();
        }
    }
}
