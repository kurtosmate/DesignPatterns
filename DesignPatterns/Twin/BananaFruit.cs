using System;

namespace DesignPatterns.Twin
{
    public class BananaFruit : Fruit
    {
        public BananaFloweringPlant BananaFloweringPlant { get; set; }

        public BananaFruit()
        {
            
        }

        public BananaFruit(BananaFloweringPlant bananaFloweringPlant)
        {
            this.BananaFloweringPlant = bananaFloweringPlant;
        }

        public override void Ripe()
        {
            Console.WriteLine($"It has {this.NumberOfRipes} sweet bananas");
        }

        public void Flowering()
        {
            BananaFloweringPlant.Flowering();
        }
    }
}
