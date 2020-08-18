namespace DesignPatterns.AbstractFactory
{
    /// <summary>

    /// The 'ConcreteFactory1' class

    /// </summary>

    class BmwFactory : AbstractFactory

    {
        public override AbstractEngineProduct CreateProductEngineProduct()
        {
            
            return new ElectricEngineProduct();
        }
        public override AbstractChargerProduct CreateProductChargerProduct()
        {
            return new DCChangerProduct();
        }
    }
}
