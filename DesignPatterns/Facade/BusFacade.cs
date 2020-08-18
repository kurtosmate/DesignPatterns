using System;
using System.Reflection;

namespace DesignPatterns.Facade
{
    /// <summary>

    /// The 'Facade' class

    /// </summary>

    class BusFacade

    {
        private SubSystemOne _one;
        private SubSystemTwo _two;
        private SubSystemThree _three;
        private SubSystemFour _four;

        public BusFacade()
        {
            _one = new SubSystemOne();
            _two = new SubSystemTwo();
            _three = new SubSystemThree();
            _four = new SubSystemFour();
        }

        public void TravelWithTicket()
        {
            Console.Write(MethodBase.GetCurrentMethod().Name+": ");
            _one.GetOnTheBus();
            _two.BuyTicket();
            _three.HandleTicket();
            Console.WriteLine();
        }

        public void TravelWithPass()
        {
            Console.Write(MethodBase.GetCurrentMethod().Name+": ");
            _one.GetOnTheBus();
            _four.ShowPass();
            Console.WriteLine();
        }
    }
}
