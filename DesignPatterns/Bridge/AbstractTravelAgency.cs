namespace DesignPatterns.Bridge
{
    /// <summary>

    /// The 'Abstraction' class

    /// </summary>

    class AbstractTravelAgency

    {
        protected Vehicle implementor;

        // Property

        public Vehicle Implementor
        {
            set { implementor = value; }
        }

        public virtual void Travel()
        {
            implementor.Travel();
        }
    }
}
