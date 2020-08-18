/// <summary>
/// The factory method pattern is a creational pattern that uses factory methods to deal with the problem of creating objects without having to specify the exact class of the object 
/// that will be created. 
/// This is done by creating objects by calling a factory method—either specified in an interface and implemented by child classes, 
/// or implemented in a base class and optionally overridden by derived classes—rather than by calling a constructor.
/// </summary>
namespace DesignPatterns.FactoryMethod
{
    public class Main : IPattern
    {
        public void Start()
        {
            // An array of creators

            CakeCreator[] creators = new CakeCreator[2];

            creators[0] = new MacaroonCreator();
            creators[1] = new ChocolateCakeCreator();

            // Iterate over creators and create products

            foreach (CakeCreator creator in creators)
            {
                Product product = creator.FactoryMethod();
                product.Bake();
            }
        }
    }
}
