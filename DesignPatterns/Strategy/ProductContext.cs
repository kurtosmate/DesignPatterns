namespace DesignPatterns.Strategy
{
    /// <summary>

    /// The 'Context' class

    /// </summary>

    class ProductContext

    {
        private IBillingStrategy _strategy;
        private string name;
        private double originalPrice;
        // Constructor

        public ProductContext(IBillingStrategy strategy, string name, double originalPrice)
        {
            this._strategy = strategy;
            this.name = name;
            this.originalPrice = originalPrice;
        }

        public double GetPrice()
        {
            return _strategy.GetPrice(originalPrice);
        }

        public override string ToString()
        {
            return $"{name}'s actual price is {GetPrice()}";
        }
    }
}
