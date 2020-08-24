using System;

namespace DesignPatterns.Servant
{
    public class EatableServant
    {
        /// <summary>
        /// New common functionality for ICookable
        /// </summary>
        /// <param name="food"></param>
        public void Eat(ICookable food)
        {
            food.Cook();
            Console.WriteLine("Wait 5 minutes and eat");
        }
    }
}
