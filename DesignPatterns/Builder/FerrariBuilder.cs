namespace DesignPatterns.Builder
{
    /// <summary>

    /// The 'ConcreteBuilder1' class

    /// </summary>

    class FerrariBuilder : Builder

    {
        private Car _product = new Car("Ferrari");

        public override void BuildDoors()
        {
            _product.Add("2 doors");
        }

        public override void BuildEngine()
        {
            _product.Add("V8 motor");
        }

        public override Car GetResult()
        {
            return _product;
        }
    }
}
