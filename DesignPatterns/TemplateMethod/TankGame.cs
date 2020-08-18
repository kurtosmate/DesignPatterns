using System;
using System.Linq;

namespace DesignPatterns.TemplateMethod
{
    /// <summary>

    /// A 'ConcreteClass' class

    /// </summary>

    class TankGame : AbstractGameClass

    {
        protected override void Exit()
        {
            Console.Write($"Exit {GetGameName()}...");
        }

        protected override void Loading()
        {
            Console.Write($"Load {GetGameName()}...");
        }

        protected override void Play()
        {
            Console.Write($"Play {GetGameName()}...");
        }

        private string GetGameName()
        {
            return this.GetType().Name.Split('.').Last();
        }
    }
}
