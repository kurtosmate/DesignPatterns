/// <summary>
///  Analogous to a facade in architecture, a facade is an object that serves as a front-facing interface masking more complex underlying or structural code.
/// </summary>

namespace DesignPatterns.Facade
{
    public class Main : IPattern
    {
        public void Start()
        {
            BusFacade bus = new BusFacade();

            bus.TravelWithTicket();

            bus.TravelWithPass();
            
        }
    }
}
