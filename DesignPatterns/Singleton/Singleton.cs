namespace DesignPatterns.Singleton
{

    /// <summary>

    /// The 'Singleton' class

    /// </summary>

    class Singleton

    {
        private static Singleton _instance;

        // Constructor is 'protected'

        protected Singleton()
        {
        }

        public static Singleton Instance()
        {
            // Uses lazy initialization.

            // Note: this is not thread safe.

            if (_instance == null)
            {
                _instance = new Singleton();
            }

            return _instance;
        }

        public int NumberOfMessages { get; private set; } = 0;
        public void SendMessage(string message)
        {
            System.Console.WriteLine($"New message accepted: {message}");
            NumberOfMessages++;
        }

        
    }
}
