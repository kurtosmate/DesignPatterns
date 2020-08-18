/// <summary>
/// The mediator pattern defines an object that encapsulates how a set of objects interact. 
/// </summary>
namespace DesignPatterns.Mediator
{
    public class Main : IPattern
    {
        public void Start()
        {
            ConcreteMediator m = new ConcreteMediator();

            ConcreteColleague c1 = new ConcreteColleague(m, "Mike");
            ConcreteColleague c2 = new ConcreteColleague(m, "Jessica");
            ConcreteColleague c3 = new ConcreteColleague(m, "John");

            c1.Send("How are you?", c2);
            c2.Send("Fine, thanks", c1);
            c3.Send("Dinner tonight?", c2);
            c2.Send("Sounds great!", c3);
        }
    }
}
