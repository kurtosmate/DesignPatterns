using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.NullObject
{
    public abstract class Logger : ILogger
    {
        public static readonly Logger Null = new NullLogger();
        public abstract void Log(string text);
        
    }
}
