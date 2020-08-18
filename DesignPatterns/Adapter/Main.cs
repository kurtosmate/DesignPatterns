/// <summary>
/// Adapter pattern is (also known as wrapper, an alternative naming shared with the decorator pattern) allows the interface of an existing class to be used as another interface.
/// It is often used to make existing classes work with others without modifying their source code.
/// </summary>
namespace DesignPatterns.Adapter
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Create adapter and place a request

            ChargerTarget microUsbCharger = new MicroUsbAdapter();
            microUsbCharger.Charge();

            ChargerTarget usbCCharger = new UsbCAdapter();
            usbCCharger.Charge();
        }
    }
}
