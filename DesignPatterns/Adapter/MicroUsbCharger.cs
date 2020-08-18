using System;
using System.Reflection;

namespace DesignPatterns.Adapter
{
    /// <summary>

    /// The 'Adaptee' class

    /// </summary>

    class MicroUsbCharger

    {
        public void ChargeWithMicroUsb()
        {
            Console.WriteLine($"Use {MethodBase.GetCurrentMethod().Name}");
        }
    }
}
