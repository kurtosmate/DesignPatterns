using System;

namespace DesignPatterns.TemplateMethod
{
    /// <summary>

    /// The 'AbstractClass' abstract class

    /// </summary>

    abstract class AbstractGameClass

    {
        protected abstract void Loading();
        protected abstract void Play();
        protected abstract void Exit();
        
        // The "Template method"

        public void Start()
        {
            PreConfiguration();
            Loading();
            Play();
            Exit();
        }

        private void PreConfiguration()
        {
            Console.WriteLine("Good luck!");
        }
    }
}
