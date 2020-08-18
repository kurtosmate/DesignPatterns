using System;
using System.Reflection;

namespace DesignPatterns.Facade
{
    /// <summary>

    /// The 'Subsystem ClassA' class

    /// </summary>

    class SubSystemOne

    {
        public void GetOnTheBus()
        {
            Console.Write(MethodBase.GetCurrentMethod().Name + ", ");
        }
    }
}
