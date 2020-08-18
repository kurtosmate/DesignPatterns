/// <summary>
/// A flyweight is an object that minimizes memory usage by sharing as much data as possible with other similar objects; 
/// it is a way to use objects in large numbers when a simple repeated representation would use an unacceptable amount of memory. 
/// Often some parts of the object state can be shared, and it is common practice to hold them in external data structures and pass them to the objects temporarily when they are used.
/// </summary>
namespace DesignPatterns.Flyweight
{
    public class Main : IPattern
    {
        public void Start()
        {

            FlyweightFactory factory = new FlyweightFactory();

            FlyweightModel car1 = factory.GetFlyweight("Red", "Sedan");
            car1.Draw();

            FlyweightModel car2 = factory.GetFlyweight("Green", "Coupe");
            car2.Draw();

            FlyweightModel car3 = factory.GetFlyweight("Green", "Coupe");
            car3.Draw();

            FlyweightModel car4 = factory.GetFlyweight("Blue", "Sedan");
            car4.Draw();
        }
    }
}
