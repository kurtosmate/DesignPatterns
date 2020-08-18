namespace DesignPatterns.Strategy
{
    /// <summary>

    /// The 'Strategy' abstract class

    /// </summary>

    interface IBillingStrategy

    {
        double GetPrice(double rawPrice);
    }
}
