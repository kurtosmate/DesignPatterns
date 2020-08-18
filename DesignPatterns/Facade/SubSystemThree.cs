using System;
using System.Reflection;

namespace DesignPatterns.Facade
{
    /// <summary>

    /// The 'Subsystem ClassC' class

    /// </summary>

    class SubSystemThree

    {
        public void HandleTicket()
        {
            Console.Write(MethodBase.GetCurrentMethod().Name + ", ");
        }
    }
}
