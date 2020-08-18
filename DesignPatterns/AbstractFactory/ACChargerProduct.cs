using System;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>

    /// The 'ProductB2' class

    /// </summary>

    class ACChargerProduct : AbstractChargerProduct

    {
        public override void Interact(AbstractEngineProduct a)
        {
            Console.WriteLine(a.GetType().Name +
              " with " + this.GetType().Name);
        }
    }
}
