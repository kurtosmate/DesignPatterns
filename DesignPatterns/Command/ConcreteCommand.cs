namespace DesignPatterns.Command
{
    /// <summary>

    /// The 'ConcreteCommand' class

    /// </summary>

    class ConcreteCommand : Command

    {
        // Constructor
        private int lastValue;
        private int add;
        public ConcreteCommand(Adder receiver, int add) :
          base(receiver)
        {
            this.add = add;
        }

        public override int Execute(int original)
        {
            lastValue = original;
            var newValue = receiver.Action(original, add);
            return newValue;
        }

        public override int Undo()
        {
            System.Console.WriteLine($"Undo last command: add {add}");
            return lastValue;
        }

    }
}
