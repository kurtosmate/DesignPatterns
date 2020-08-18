namespace DesignPatterns.Command
{
    /// <summary>

    /// The 'Command' abstract class

    /// </summary>

    abstract class Command

    {
        protected Adder receiver;
        
        // Constructor

        public Command(Adder receiver)
        {
            this.receiver = receiver;
            
            
        }

        public abstract int Execute(int original);
        public abstract int Undo();
        
    }
}
