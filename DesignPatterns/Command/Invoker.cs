using System.Collections.Generic;

namespace DesignPatterns.Command
{
    /// <summary>

    /// The 'Invoker' class

    /// </summary>

    class Invoker

    {
        public int Result { get; private set; }

        private List<Command> _commands = new List<Command>();


        public Invoker(int initValue)
        {
            Result = initValue;
        }
        public void AddCommand(Command command)
        {
            this._commands.Add(command);
        }

        public void ExecuteCommands()
        {

            foreach (var command in _commands)
            {
                Result = command.Execute(Result);
            }
        }

        public void UndoCommand()
        {
            var lastIndex = _commands.Count - 1;
            var lastCommand = _commands[lastIndex];
            Result = lastCommand.Undo();
            _commands.RemoveAt(lastIndex);
        }


    }
}
