namespace DesignPatterns.State
{
    /// <summary>

    /// A 'ConcreteState' class

    /// </summary>

    class UpperCaseState : State

    {
        public override void Handle(Context context, string text)
        {
            System.Console.Write(text.ToUpper()+" ");
            context.State = new LowerCaseState();
        }
    }
}
