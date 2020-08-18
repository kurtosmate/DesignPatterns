/// <summary>
/// The observer pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, 
/// called observers, and notifies them automatically of any state changes, usually by calling one of their methods.
/// </summary>
namespace DesignPatterns.Observer
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Configure Observer pattern

            ConcreteSubject s = new ConcreteSubject();

            s.Attach(new ConcreteObserver(s, "Washing machine"));
            s.Attach(new ConcreteObserver(s, "Coffer maker"));

            // Change subject and notify observers
            System.Console.WriteLine("Notify observers");
            s.SubjectState = "Start";
            s.Notify();

            s.SubjectState = "Stop";
            s.Notify();
        }
    }
}
