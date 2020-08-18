using System;

namespace DesignPatterns.Command
{
    /// <summary>

    /// The 'Receiver' class

    /// </summary>

    class Adder

    {
        public int Action(int a, int b)
        {
            var value = a + b;
            Console.WriteLine($"Calculating {a}+{b} = {value}");
            return value;
        }
    }
}
