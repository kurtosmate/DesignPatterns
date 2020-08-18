using System;

namespace DesignPatterns.Composite
{
    /// <summary>

    /// The 'Leaf' class

    /// </summary>

    class Leaf : Component

    {
        // Constructor

        public Leaf(string name)
          : base(name)
        {
        }

        public override void Add(Component c)
        {
            return;
           // Console.WriteLine("Cannot add to a leaf");
        }

        public override void Remove(Component c)
        {
            return;
           // Console.WriteLine("Cannot remove from a leaf");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new String('-', depth) + name);
        }
    }
}
