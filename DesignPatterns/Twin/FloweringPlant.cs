namespace DesignPatterns.Twin
{
    /// <summary>
    ///https://en.wikipedia.org/wiki/Flowering_plant
    /// </summary>
    public abstract class FloweringPlant
    {
        public int NumberOfFlowers { get; set; }

        public abstract void Flowering();
    }
}
