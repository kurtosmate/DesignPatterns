/// <summary>
/// The command pattern is a design pattern in which an object is used to encapsulate all information needed to perform an action or trigger an event at a later time. 
/// This information includes the method name, the object that owns the method and values for the method parameters.
/// </summary>

namespace DesignPatterns.Command
{
    public class Main : IPattern
    {
        public void Start()
        {
            
            Adder adder = new Adder();
            Command command1 = new ConcreteCommand(adder, 6);
            Command command2 = new ConcreteCommand(adder, 2);
            Command command3 = new ConcreteCommand(adder, 7);

            // Set and execute command

            Invoker invoker = new Invoker(5);
            invoker.AddCommand(command1);
            invoker.AddCommand(command2);
            invoker.AddCommand(command3);
            invoker.ExecuteCommands();
            System.Console.WriteLine($"Result: {invoker.Result}");

            invoker.UndoCommand();
            System.Console.WriteLine($"Result: {invoker.Result}");
        }
    }
}
