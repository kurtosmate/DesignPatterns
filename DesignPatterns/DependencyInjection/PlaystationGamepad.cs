using System;

namespace DesignPatterns.DependencyInjection
{
    public class PlaystationGamepad : IGamepad
    {
        public void MoveDownHelp()
        {
            Console.WriteLine("Push jostick down");
        }

        public void MoveLeftHelp()
        {
            Console.WriteLine("Push jostick left");
        }

        public void MoveRightHelp()
        {
            Console.WriteLine("Push jostick right");
        }

        public void MoveUpHelp()
        {
            Console.WriteLine("Push jostick up");
        }
    }
}
