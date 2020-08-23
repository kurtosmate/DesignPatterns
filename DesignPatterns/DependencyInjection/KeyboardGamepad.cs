using System;

namespace DesignPatterns.DependencyInjection
{
    public class KeyboardGamepad : IGamepad
    {
        public void MoveDownHelp()
        {
            Console.WriteLine("Press down key");
        }

        public void MoveLeftHelp()
        {
            Console.WriteLine("Press left key");
        }

        public void MoveRightHelp()
        {
            Console.WriteLine("Press right key");
        }

        public void MoveUpHelp()
        {
            Console.WriteLine("Press up key");
        }
    }
}
