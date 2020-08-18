/// <summary>
/// The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes.
/// In normal usage, the client software creates a concrete implementation of the abstract factory
/// and then uses the generic interface of the factory to create the concrete objects that are part of the theme. 
/// The client does not know (or care) which concrete objects it gets from each of these internal factories, since it uses only the generic interfaces of their products.
/// This pattern separates the details of implementation of a set of objects from their general usage 
/// and relies on object composition, as object creation is implemented in methods exposed in the factory interface.
/// </summary>
namespace DesignPatterns.AbstractFactory
{
    class Main : IPattern
    {
        public void Start()
        {
            // Abstract factory #1

            AbstractFactory factory1 = new BmwFactory();
            System.Console.Write($"{factory1.GetType().Name} uses: ");
            Client client1 = new Client(factory1);
            client1.Run();

            // Abstract factory #2

            AbstractFactory factory2 = new AudiFactory();
            System.Console.Write($"{factory2.GetType().Name} uses: ");
            Client client2 = new Client(factory2);
            client2.Run();

        }
      
    }
}
