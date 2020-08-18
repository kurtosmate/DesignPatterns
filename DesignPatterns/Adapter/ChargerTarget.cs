using System;
using System.Reflection;

namespace DesignPatterns.Adapter
{
    /// <summary>

    /// The 'Target' class

    /// </summary>

    class ChargerTarget

    {
        public virtual void Charge()
        {
            MethodBase m = MethodBase.GetCurrentMethod();
            Console.WriteLine($"Called {m.ReflectedType.Name}.{m.Name}");
        }
    }
}
