namespace DesignPatterns.Adapter
{
    /// <summary>

    /// The 'Adapter' class

    /// </summary>

    class MicroUsbAdapter : ChargerTarget

    {
        private MicroUsbCharger microUsbCharger = new MicroUsbCharger();

        public override void Charge()
        {
            // Possibly do some other work

            //  and then call SpecificRequest

            microUsbCharger.ChargeWithMicroUsb();
        }
    }
}
