using System;
/// <summary>
/// The multiton pattern is a design pattern which generalizes the singleton pattern. 
/// Whereas the singleton allows only one instance of a class to be created, the multiton pattern allows for the controlled creation of multiple instances,
/// which it manages through the use of a map.
/// </summary>
namespace DesignPatterns.Multiton
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Constructor is private -- cannot use new
            // We can use singleton objects as parameter
            TaxiMessage(Multiton.Instance(1));

            BusMessage(Multiton.Instance(2));

            TrainMessage(Multiton.Instance(2));

            var m1 = Multiton.Instance(1);
            var m2 = Multiton.Instance(2);

            Console.WriteLine($"Multition {m1.Id} has {m1.NumberOfMessages} message");
            Console.WriteLine($"Multition {m2.Id} has {m2.NumberOfMessages} messages");
        }

        private void TaxiMessage(Multiton selectedDispatcher)
        {
            selectedDispatcher.SendMessage("Taxi has been arrived to destination");
        }

        private void BusMessage(Multiton selectedDispatcher)
        {
            selectedDispatcher.SendMessage("Bus is in a traffic jam");
        }

        private void TrainMessage(Multiton selectedDispatcher)
        {
            selectedDispatcher.SendMessage("Train is waiting for connection");
        }
    }
}
