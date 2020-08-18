/// <summary>
/// State pattern allows an object to alter its behavior when its internal state changes. 
/// This pattern is close to the concept of finite-state machines. 
/// The state pattern can be interpreted as a strategy pattern, which is able to switch a strategy through invocations of methods defined in the pattern's interface.
/// </summary>
namespace DesignPatterns.State
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Setup context in a state

            Context c = new Context(new LowerCaseState());

            // Issue requests, which toggles state

            c.Request("Monday");
            c.Request("Tuesday");
            c.Request("Wednesday");
            c.Request("Thursday");
            c.Request("Friday");

            System.Console.WriteLine();
        }
    }
}
