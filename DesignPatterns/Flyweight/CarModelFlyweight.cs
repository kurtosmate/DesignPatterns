using System;
using System.Drawing;

namespace DesignPatterns.Flyweight
{
    /// <summary>

    /// The 'ConcreteFlyweight' class

    /// </summary>

    class CarModelFlyweight : FlyweightModel

    {
        public string Color { get; private set; }
        public string Type { get; private set; }
        public CarModelFlyweight(string color, string type)
        {
            Color = color;
            Type = type;
            Console.WriteLine("Created new "+this.ToString());
        }

        public override void Draw()
        {
            Console.WriteLine("Drew "+this.ToString());
        }

        public override string ToString()
        {
            return $"{Color} {Type} car";
        }

    }
}
