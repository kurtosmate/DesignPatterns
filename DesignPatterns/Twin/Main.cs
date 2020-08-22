/// <summary>
/// Twin pattern is a software design pattern that allows developers to model multiple inheritance in programming languages 
/// that do not support multiple inheritance.
/// </summary>
namespace DesignPatterns.Twin
{
    public class Main : IPattern
    {
        public void Start()
        {
            var myBanana = PlantBanana(5, 3);
            myBanana.Flowering();
            myBanana.Ripe();
            System.Console.WriteLine("Check linked twins:");
            myBanana.BananaFloweringPlant.Ripe();
            myBanana.BananaFloweringPlant.BananaFruit.Ripe();
        }

        //Creator method for BananaFruit. We should set up twins.
        private static BananaFruit PlantBanana(int numberOfFlowers, int numberOfRipes)
        {
            var banana = new BananaFruit();
            banana.NumberOfRipes = numberOfRipes;
            
            banana.BananaFloweringPlant = new BananaFloweringPlant(banana); //Link twins together
            banana.BananaFloweringPlant.NumberOfFlowers = numberOfFlowers;
            
            return banana;
        }
    }
}
