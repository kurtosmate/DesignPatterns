using System;
using System.Linq;
/// <summary>
/// This is a demo program for the most common Design patterns.
/// Every folder contains a "Main.cs" file which is the client of the given pattern
/// </summary>
namespace DesignPatterns
{
    class Program
    {
        /// <summary>
        /// Runs all of the design pattern demo
        /// </summary>
        /// <param name="args"></param>
        public static void Main(string[] args)
        {
            Console.WriteLine("#\t#\tHello Design Patterns!\t#\t#");
            RunAllPattern();
            Console.ReadKey();
        }

        /// <summary>
        /// Runs objects which implements IPattern
        /// </summary>
        private static void RunAllPattern()
        {
            foreach (Type type in System.Reflection.Assembly.GetExecutingAssembly().GetTypes()
                                                            .Where(c => c.GetInterfaces().Contains(typeof(IPattern))))
            {
                WriteHeader(type);

                IPattern instance = (IPattern)Activator.CreateInstance(type);
                instance.Start();

            }
        }

        static int index = 1;
        private static void WriteHeader(Type type)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"{index}.\t{type.Namespace.Split('.').Last()}");
            Console.ResetColor();

            index++;
        }
    }
}
