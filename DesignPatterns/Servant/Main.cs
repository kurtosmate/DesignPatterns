/// <summary>
///  the servant pattern defines an object used to offer some functionality to a group of classes without defining that functionality in each of them.
///  A Servant is a class whose instance (or even just class) provides methods that take care of a desired service,
///  while objects for which (or with whom) the servant does something, are taken as parameters.
/// </summary>
namespace DesignPatterns.Servant
{
    public class Main : IPattern
    {
        public void Start()
        {
            Rice rice = new Rice();
            EatableServant eatable = new EatableServant();
            eatable.Eat(rice);
        }
    }
}
