/// <summary>
/// The decorator pattern is a design pattern that allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class.
/// The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern.
/// The decorator pattern is structurally nearly identical to the chain of responsibility pattern, 
/// the difference being that in a chain of responsibility, exactly one of the classes handles the request, while for the decorator, all classes handle the request.
/// </summary>
namespace DesignPatterns.Decorator
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Create ConcreteComponent and two Decorators

            RectangleComponent c = new RectangleComponent();
            RedBorderDecorator d1 = new RedBorderDecorator();
            BlueColorDecorator d2 = new BlueColorDecorator();

            // Link decorators

            d1.SetComponent(c);
            d2.SetComponent(d1);

            d2.Operation();
            System.Console.WriteLine();
        }
    }
}
