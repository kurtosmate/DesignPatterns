namespace DesignPatterns.Builder
{
    /// <summary>

    /// The 'Director' class

    /// </summary>

    class Director

    {
        // Builder uses a complex series of steps

        public void Construct(Builder builder)
        {
            builder.BuildDoors();
            builder.BuildEngine();
        }
    }
}
