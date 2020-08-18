/// <summary>
///  The visitor design pattern is a way of separating an algorithm from an object structure on which it operates. 
///  A practical result of this separation is the ability to add new operations to existing object structures without modifying the structures. 
///  It is one way to follow the open/closed principle.
/// </summary>
namespace DesignPatterns.Visitor
{
    public class Main : IPattern
    {
        public void Start()
        {
            var car = new CarElement();
            var motor = new MotorCycleElement();

            ObjectStructure o = new ObjectStructure();
            o.Attach(car);
            o.Attach(motor);
            
            // Create visitor objects

            ServiceVisitor vService = new ServiceVisitor();
            RefuelVisitor vRefuel = new RefuelVisitor();

            // Structure accepting visitors

            o.Accept(vService);
            o.Accept(vRefuel);

            car.GoHome();
            motor.GoHome();
        }
    }
}
