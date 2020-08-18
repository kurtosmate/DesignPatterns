using System;
using System.Linq;

namespace DesignPatterns.Decorator
{
    /// <summary>

    /// The 'ConcreteDecoratorB' class

    /// </summary>

    class BlueColorDecorator : Decorator

    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        void AddedBehavior()
        {
            Console.Write($" and with {this.GetType().Name.Split('.').Last()}");
        }
    }
}
