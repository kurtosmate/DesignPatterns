using System;
using System.Reflection;

namespace DesignPatterns.Adapter
{
    /// <summary>

    /// The 'Adaptee' class

    /// </summary>

    class UsbCCharger

    {
        public void ChargeWithUsbC()
        {
            Console.WriteLine($"Use {MethodBase.GetCurrentMethod().Name}");
        }
    }
}
