using System;

namespace DesignPatterns.DependencyInjection
{
    public class Game
    {
        IGamepad gamepad;
        /// <summary>
        /// Get depencency (IGamepad) from client instead of create in this class
        /// </summary>
        /// <param name="gamepad"></param>
        public Game(IGamepad gamepad)
        {
            this.gamepad = gamepad;
        }

        public void HowToMoveUp()
        {
            Console.Write("To move up: ");
            gamepad.MoveUpHelp();
        }
    }
}
