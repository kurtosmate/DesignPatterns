using System;
using System.Linq;

namespace DesignPatterns.Bridge
{
    /// <summary>

    /// The 'ConcreteImplementorB' class

    /// </summary>

    class Car : Vehicle

    {
        public override void Travel()
        {
            Console.WriteLine($"Travel wtih {this.GetType().Name.Split('.').Last()}");
        }
    }
}
