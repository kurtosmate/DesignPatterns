namespace DesignPatterns.Visitor
{
    /// <summary>

    /// A 'ConcreteElement' class

    /// </summary>

    class CarElement : Element

    {
        public override void Accept(Visitor visitor)
        {
            visitor.OperateCar(this);
            
        }

        public void GoHome()
        {
            System.Console.WriteLine("Driving car home");
        }
    }
}
