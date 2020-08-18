namespace DesignPatterns.Bridge
{
    /// <summary>

    /// The 'RefinedAbstraction' class

    /// </summary>

    class LocalTravelAgency : AbstractTravelAgency

    {
        public override void Travel()
        {
            implementor.Travel();
        }
    }
}
