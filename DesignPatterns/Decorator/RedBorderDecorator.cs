using System;
using System.Linq;

namespace DesignPatterns.Decorator
{
    /// <summary>

    /// The 'ConcreteDecoratorA' class

    /// </summary>

    class RedBorderDecorator : Decorator

    {
        public override void Operation()
        {
            base.Operation();
            AddedBehavior();
        }

        void AddedBehavior()
        {
            Console.Write($" with {this.GetType().Name.Split('.').Last()}");
        }
    }
}
