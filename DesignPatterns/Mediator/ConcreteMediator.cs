namespace DesignPatterns.Mediator
{
    /// <summary>

    /// The 'ConcreteMediator' class

    /// </summary>
    public delegate void MessageReceivedEventHandler(string message, Colleague from, Colleague to);
    class ConcreteMediator : Mediator

    {

        public override event MessageReceivedEventHandler MessageReceived;

        public override void Send(string message, Colleague colleague, Colleague to)
        {
                this.MessageReceived?.Invoke(message, colleague, to);
        }
    }
}
