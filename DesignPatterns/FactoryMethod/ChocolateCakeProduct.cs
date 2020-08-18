using System.Linq;

namespace DesignPatterns.FactoryMethod
{
    /// <summary>

    /// A 'ConcreteProduct' class

    /// </summary>

    class ChocolateCakeProduct : Product

    {
        public override int Calories => 371;

        public override void Bake()
        {
            System.Console.WriteLine($"Baked {this.GetType().Name.Split('.').Last()} and it has {Calories} calories");
        }
    }
}
