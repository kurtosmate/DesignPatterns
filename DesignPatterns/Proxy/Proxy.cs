namespace DesignPatterns.Proxy
{
    public partial class Main
    {
        /// <summary>

        /// The 'Proxy' class

        /// </summary>

        class Proxy : Subject

        {
            private RealSubject _realSubject;

            public override void Request()
            {
                // Use 'lazy initialization'

                if (_realSubject == null)
                {
                    _realSubject = new RealSubject();
                }

                _realSubject.Request();
            }
        }
    }
}
