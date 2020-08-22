using System;
/// <summary>
///  A null object is an object with no referenced value or with defined neutral ("null") behavior.
/// </summary>
namespace DesignPatterns.NullObject
{
    public class Main : IPattern
    {
        public void Start()
        {
            Logger RedLogger = new RedLogger();
            Console.Write("Red logger logs: ");
            RedLogger.Log("Log1");
            Console.ResetColor();

            Logger YellowLogger = new YellowLogger();
            Console.Write("Yellow logger logs: ");
            YellowLogger.Log("Log2");
            Console.ResetColor();

            //Turn off logging
            Logger NullLogger = Logger.Null;
            Console.Write("Null logger logs: ");
            NullLogger.Log("Log3");
            Console.ResetColor();

            Console.WriteLine();
        }
    }
}
