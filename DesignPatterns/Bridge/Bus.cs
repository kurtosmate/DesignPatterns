using System;
using System.Linq;

namespace DesignPatterns.Bridge
{
    /// <summary>

    /// The 'ConcreteImplementorA' class

    /// </summary>

    class Bus : Vehicle

    {
        public override void Travel()
        {
            Console.WriteLine($"Travel wtih {this.GetType().Name.Split('.').Last()}");
        }
    }
}
