namespace DesignPatterns.State
{
    /// <summary>

    /// The 'State' abstract class

    /// </summary>

    abstract class State

    {
        public abstract void Handle(Context context, string text);
    }
}
