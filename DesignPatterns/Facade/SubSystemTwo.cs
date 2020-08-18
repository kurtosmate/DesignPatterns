using System;
using System.Reflection;

namespace DesignPatterns.Facade
{
    /// <summary>

    /// The 'Subsystem ClassB' class

    /// </summary>

    class SubSystemTwo

    {
        public void BuyTicket()
        {
            Console.Write(MethodBase.GetCurrentMethod().Name + ", ");
        }
    }
}
