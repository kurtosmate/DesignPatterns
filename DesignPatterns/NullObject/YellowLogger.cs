using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject
{
    class YellowLogger : Logger
    {
        public override void Log(string text)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            
        }
    }
}
