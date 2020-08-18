using System;

namespace DesignPatterns.Strategy
{
    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class NormalPriceStrategy : IBillingStrategy

    {
        public double GetPrice(double rawPrice) => rawPrice;
    }
}
