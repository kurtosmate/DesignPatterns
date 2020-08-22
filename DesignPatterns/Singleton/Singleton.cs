namespace DesignPatterns.Singleton
{
    /// <summary>
    /// The 'Singleton' class
    /// </summary>

    class Singleton
    {
        // Lock object for thread safety
        private static object myLock = new object();
        private static Singleton _instance;

        // Constructor is 'protected' or 'private'
        private Singleton()
        {
        }

        public static Singleton Instance()
        {
            if (_instance == null) // 1st check
            { 
                lock (myLock)
                {
                    if (_instance == null) // 2nd (double) check
                    { 
                        {
                            _instance = new Singleton();
                        }
                    }
                }
            }
            return _instance;
        }

        //Some busines logic
        public int NumberOfMessages { get; private set; } = 0;
        public void SendMessage(string message)
        {
            System.Console.WriteLine($"New message accepted: {message}");
            NumberOfMessages++;
        }


    }
}
