namespace DesignPatterns.Mediator
{
    /// <summary>

    /// The 'Mediator' abstract class

    /// </summary>

    public abstract class Mediator

    {
        public abstract event MessageReceivedEventHandler MessageReceived;
        public abstract void Send(string message, Colleague colleague, Colleague to);
    }
}
