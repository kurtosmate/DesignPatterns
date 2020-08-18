namespace DesignPatterns.State
{
    /// <summary>

    /// A 'ConcreteState' class

    /// </summary>

    class LowerCaseState : State

    {
        public override void Handle(Context context, string text)
        {
            System.Console.Write(text.ToLower()+" ");
            context.State = new UpperCaseState();
        }
    }
}
