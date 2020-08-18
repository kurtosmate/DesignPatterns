namespace DesignPatterns.Visitor
{
    /// <summary>

    /// A 'ConcreteElement' class

    /// </summary>

    class MotorCycleElement : Element

    {
        public override void Accept(Visitor visitor)
        {
            visitor.OperateMotorCycle(this);
        }

        public void GoHome()
        {
            System.Console.WriteLine("Driving motorcycle home");
        }
    }
}
