using System;

namespace DesignPatterns.Observer
{
    /// <summary>

    /// The 'ConcreteObserver' class

    /// </summary>

    class ConcreteObserver : Observer

    {
        // Gets or sets subject
        public ConcreteSubject Subject { get; set; }
        
        private string _name;
        private string _observerState;

        // Constructor

        public ConcreteObserver(
          ConcreteSubject subject, string name)
        {
            this.Subject = subject;
            this._name = name;
            Update();
        }

        public override void Update()
        {
            _observerState = Subject.SubjectState;
            Console.WriteLine($"Observer {_name}'s new state is {_observerState}");
        }


    }
}
