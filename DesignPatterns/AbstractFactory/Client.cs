namespace DesignPatterns.AbstractFactory
{
    /// <summary>

    /// The 'Client' class. Interaction environment for the products.

    /// </summary>

    class Client

    {
        private AbstractEngineProduct _abstractEngineProduct;
        private AbstractChargerProduct _abstractChargerProduct;

        // Constructor

        public Client(AbstractFactory factory)
        {
            _abstractChargerProduct = factory.CreateProductChargerProduct();
            _abstractEngineProduct = factory.CreateProductEngineProduct();
        }

        public void Run()
        {
            _abstractChargerProduct.Interact(_abstractEngineProduct);
        }
    }
}
