/// <summary>
/// The template method is a method in a superclass, usually an abstract superclass, and defines the skeleton of an operation in terms of a number of high-level steps. 
/// These steps are themselves implemented by additional helper methods in the same class as the template method.
/// </summary>
namespace DesignPatterns.TemplateMethod
{
    public class Main : IPattern
    {
        public void Start()
        {
            AbstractGameClass m = new MarioGame();
            m.Start();
            System.Console.WriteLine();
            
            AbstractGameClass t = new TankGame();
            t.Start();
            System.Console.WriteLine();

        }
    }
}
