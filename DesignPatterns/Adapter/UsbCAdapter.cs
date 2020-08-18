namespace DesignPatterns.Adapter
{
    /// <summary>

    /// The 'Adapter' class

    /// </summary>

    class UsbCAdapter : ChargerTarget

    {
        private UsbCCharger microUsbCharger = new UsbCCharger();

        public override void Charge()
        {
            // Possibly do some other work

            //  and then call SpecificRequest

            microUsbCharger.ChargeWithUsbC();
        }
    }
}
