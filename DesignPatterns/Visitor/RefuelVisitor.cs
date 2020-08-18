using System;

namespace DesignPatterns.Visitor
{
    /// <summary>

    /// A 'ConcreteVisitor' class

    /// </summary>

    class RefuelVisitor : Visitor

    {
        public override void OperateCar(CarElement concreteElementA)
        {
            Console.WriteLine("Refuel the car at the gas station. ");
        }

        public override void OperateMotorCycle(MotorCycleElement concreteElementB)
        {
            Console.WriteLine("Refuel the motorcycle at the gas station. ");
        }
    }
}
