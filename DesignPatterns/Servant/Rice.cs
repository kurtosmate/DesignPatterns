using System;

namespace DesignPatterns.Servant
{
    public class Rice : ICookable
    {
        public void Cook()
        {
            Console.WriteLine("Cook rice for 15 minutes");
        }
    }
}
