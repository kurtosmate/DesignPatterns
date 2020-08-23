/// <summary>
/// The memento pattern is a software design pattern that provides the ability to restore an object to its previous state (undo via rollback).
/// </summary>
namespace DesignPatterns.Memento
{
    public class Main : IPattern
    {
        public void Start()
        {
            Originator o = new Originator();
            o.State = "Open";

            // Store internal state
            System.Console.WriteLine("Create memento...");
            Caretaker c = new Caretaker();
            c.Memento = o.CreateMemento();

            // Continue changing originator

            o.State = "Closed";
            o.State = "Sealed";

            // Restore saved state

            o.SetMemento(c.Memento);

        }
    }
}
