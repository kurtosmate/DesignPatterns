/// <summary>
///  The intent of the Builder design pattern is to separate the construction of a complex object from its representation.
/// </summary>

namespace DesignPatterns.Builder
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Create director and builders

            Director director = new Director();

            Builder b1 = new FerrariBuilder();
            Builder b2 = new ChevroletBuilder();

            // Construct two products

            director.Construct(b1);
            Car car1 = b1.GetResult();
            car1.Show();

            director.Construct(b2);
            Car car2 = b2.GetResult();
            car2.Show();
        }
    }
}
