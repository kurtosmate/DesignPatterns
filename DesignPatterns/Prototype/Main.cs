using System;
/// <summary>
/// Prototype is used when the type of objects to create is determined by a prototypical instance, which is cloned to produce new objects.
/// </summary>
namespace DesignPatterns.Prototype
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Create two instances and clone each


            CoffeePrototype prototype1 = new CoffeePrototype("Cappuccino", withLactoseFree: true);
            CoffeePrototype clone1 = (CoffeePrototype)prototype1.Clone();
            Console.WriteLine("Original:\t"+prototype1);
            Console.WriteLine("Clone:\t\t" + clone1);
        }
    }
}
