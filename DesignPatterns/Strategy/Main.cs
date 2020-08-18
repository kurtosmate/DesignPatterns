/// <summary>
///  The strategy pattern (also known as the policy pattern) is a behavioral software design pattern that enables selecting an algorithm at runtime. 
///  Instead of implementing a single algorithm directly, code receives run-time instructions as to which in a family of algorithms to use.
/// </summary>

namespace DesignPatterns.Strategy
{
    public class Main : IPattern
    {
        public void Start()
        {
            ProductContext product;

            // Three contexts following different strategies

            product = new ProductContext(new NormalPriceStrategy(), "Milk", originalPrice: 2);
            System.Console.WriteLine("With NormalPriceStrategy: "+product);

            product = new ProductContext(new OnSalePriceStrategy(), "Milk", originalPrice: 2); //Half price
            System.Console.WriteLine("With OnSalePriceStrategy: "+product);
        }
    }
}
