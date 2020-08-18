using System;
using System.Linq;
using System.Reflection;

namespace DesignPatterns.Proxy
{
    public partial class Main
    {
        /// <summary>

        /// The 'RealSubject' class

        /// </summary>

        class RealSubject : Subject

        {
            public override void Request()
            {
                Console.Write($"Called {this.GetType().Name.Split('.').Last()}.{MethodBase.GetCurrentMethod().Name}");
            }
        }
    }
}