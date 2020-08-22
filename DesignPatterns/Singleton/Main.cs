using System;
/// <summary>
/// Singleton restricts the instantiation of a class to one "single" instance. This is useful when exactly one object is needed to coordinate actions across the system.
/// </summary>
namespace DesignPatterns.Singleton
{
    public class Main : IPattern
    {
        public void Start()
        {

            // Constructor is private -- cannot use new

            Singleton dispatcher1 = Singleton.Instance();

            // We can use singleton objects as parameter
            TaxiMessage(dispatcher1);

            Singleton dispatcher2 = Singleton.Instance();
            BusMessage(dispatcher2);

            // Test for same instance

            if (dispatcher1 == dispatcher2)
            {
                Console.WriteLine("Singleton dispatcer objects are the same instance");
            }

            Console.WriteLine($"Total dispatcher messages: {dispatcher1.NumberOfMessages}");
        }

        private  void TaxiMessage(Singleton singletonDispatcher)
        {
            singletonDispatcher.SendMessage("Taxi has been arrived to destination");
        }

        private void BusMessage(Singleton singletonDispatcher)
        {
            singletonDispatcher.SendMessage("Bus is in a traffic jam");
        }
    }
}
