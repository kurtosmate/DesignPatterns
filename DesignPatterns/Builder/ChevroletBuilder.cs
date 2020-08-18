namespace DesignPatterns.Builder
{
    /// <summary>

    /// The 'ConcreteBuilder2' class

    /// </summary>

    class ChevroletBuilder : Builder

    {
        private Car _product = new Car("Chevrolet");

        public override void BuildDoors()
        {
            _product.Add("4 doors");
        }

        public override void BuildEngine()
        {
            _product.Add("Hybrid motor");
        }

        public override Car GetResult()
        {
            return _product;
        }
    }
}
