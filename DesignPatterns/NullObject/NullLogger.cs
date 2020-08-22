namespace DesignPatterns.NullObject
{
    public class NullLogger : Logger
    {
        public override void Log(string text)
        {
            //does nothing
        }
    }
}
