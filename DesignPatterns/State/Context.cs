using System;

namespace DesignPatterns.State
{
    /// <summary>

    /// The 'Context' class

    /// </summary>

    class Context

    {
        private State _state;

        // Constructor

        public Context(State state)
        {
            this.State = state;
        }

        // Gets or sets the state

        public State State
        {
            get { return _state; }
            set
            {
                _state = value;
            }
        }

        public void Request(string text)
        {
            _state.Handle(this, text);
        }
    }
}
