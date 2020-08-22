using System;

namespace DesignPatterns.NullObject
{
    public class RedLogger : Logger
    {
        public override void Log(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            
        }
    }
}
