namespace DesignPatterns.AbstractFactory
{
    /// <summary>

    /// The 'ConcreteFactory2' class

    /// </summary>

    class AudiFactory : AbstractFactory

    {
        public override AbstractEngineProduct CreateProductEngineProduct()
        {
            return new HybridEngineProduct();
        }
        public override AbstractChargerProduct CreateProductChargerProduct()
        {
            return new ACChargerProduct();
        }
    }
}
