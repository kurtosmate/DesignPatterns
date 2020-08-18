using System;
using System.Linq;

namespace DesignPatterns.Decorator
{
    /// <summary>

    /// The 'ConcreteComponent' class

    /// </summary>

    class RectangleComponent : ShapeComponent

    {
        public override void Operation()
        {
            Console.Write($"Draw a {this.GetType().Name.Split('.').Last()}");
        }
    }
}
