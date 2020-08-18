using System;

namespace DesignPatterns.AbstractFactory
{
    /// <summary>

    /// The 'ProductB1' class

    /// </summary>

    class DCChangerProduct : AbstractChargerProduct

    {
        public override void Interact(AbstractEngineProduct a)
        {
            Console.WriteLine(a.GetType().Name +
              " with " + this.GetType().Name);
        }
    }
}
