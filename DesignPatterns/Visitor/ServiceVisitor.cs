using System;

namespace DesignPatterns.Visitor
{
    /// <summary>

    /// A 'ConcreteVisitor' class

    /// </summary>

    class ServiceVisitor : Visitor

    {
        public override void OperateCar(CarElement car)
        {
            Console.WriteLine("Fixing the car in the Service. ");
        }

        public override void OperateMotorCycle(MotorCycleElement motor)
        {
            Console.WriteLine("Fixing the motorcycle in the Service. ");
        }
    }
}
