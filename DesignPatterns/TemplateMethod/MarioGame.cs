using System;
using System.Linq;

namespace DesignPatterns.TemplateMethod
{
    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>

    class MarioGame : AbstractGameClass

    {
        protected override void Exit()
        {
            Console.Write($"Exiting {GetName()}...");
        }

        protected override void Loading()
        {
           // Console.Write($"Loading {GetName()}...");
        }

        protected override void Play()
        {
            Console.Write($"Playing {GetName()}...");
        }

        private string GetName()
        {
            return this.GetType().Name.Split('.').Last();
        }
    }
}
