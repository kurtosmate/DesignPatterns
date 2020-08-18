/// <summary>
/// The composite pattern describes a group of objects that are treated the same way as a single instance of the same type of object. 
/// The intent of a composite is to "compose" objects into tree structures to represent part-whole hierarchies. 
/// Implementing the composite pattern lets clients treat individual objects and compositions uniformly
/// </summary>

namespace DesignPatterns.Composite
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Create a tree structure

            Composite root = new Composite("root");
            root.Add(new Leaf("Leaf A"));
            root.Add(new Leaf("Leaf B"));

            Composite comp = new Composite("Composite X");
            comp.Add(new Leaf("Leaf X1"));
            comp.Add(new Leaf("Leaf X2"));

            root.Add(comp);
            root.Add(new Leaf("Leaf C"));

            // Add and remove a leaf

            Leaf leaf = new Leaf("Leaf D");
            root.Add(leaf);
            root.Remove(leaf);

            // Recursively display tree

            root.Display(1);

        }
    }
}
