using System;
using System.Reflection;

namespace DesignPatterns.Facade
{
    /// <summary>

    /// The 'Subsystem ClassD' class

    /// </summary>

    class SubSystemFour

    {
        public void ShowPass()
        {
            Console.Write(MethodBase.GetCurrentMethod().Name + ", ");
        }
    }
}
