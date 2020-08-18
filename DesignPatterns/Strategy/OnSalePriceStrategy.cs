using System;

namespace DesignPatterns.Strategy
{
    /// <summary>

    /// A 'ConcreteStrategy' class

    /// </summary>

    class OnSalePriceStrategy : IBillingStrategy

    {
        public double GetPrice(double rawPrice) => rawPrice*0.5;
    }
}
