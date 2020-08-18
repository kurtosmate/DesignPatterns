using System;

namespace DesignPatterns.Mediator
{
    /// <summary>

    /// A 'ConcreteColleague' class

    /// </summary>

    class ConcreteColleague : Colleague

    {

        // Constructor

        public ConcreteColleague(Mediator mediator, string name)
          : base(mediator)
        {
            Name = name;
            mediator.MessageReceived += new MessageReceivedEventHandler(Notify);
        }

        public void Send(string message, Colleague to)
        {
            mediator.Send(message, this, to);
        }

        public void Notify(string message, Colleague from, Colleague to)
        {
            if (to == this)
            {
                Console.WriteLine($"{Name} gets message from {from.Name}: {message}");
            }
        }
    }
}
