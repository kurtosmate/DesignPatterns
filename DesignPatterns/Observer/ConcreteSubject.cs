namespace DesignPatterns.Observer
{
    /// <summary>

    /// The 'ConcreteSubject' class

    /// </summary>

    class ConcreteSubject : Subject

    {
        private string _subjectState = "Init";

        // Gets or sets subject state

        public string SubjectState
        {
            get { return _subjectState; }
            set { _subjectState = value; }
        }
    }
}
