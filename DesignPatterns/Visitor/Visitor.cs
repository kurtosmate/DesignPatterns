namespace DesignPatterns.Visitor
{
    /// <summary>

    /// The 'Visitor' abstract class

    /// </summary>

    abstract class Visitor

    {
        public abstract void OperateCar(CarElement concreteElementA);
        public abstract void OperateMotorCycle(MotorCycleElement concreteElementB);
    }
}
