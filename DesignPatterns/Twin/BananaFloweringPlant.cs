using System;

namespace DesignPatterns.Twin
{
    public class BananaFloweringPlant : FloweringPlant
    {
        public BananaFruit BananaFruit { get; set; }

        public BananaFloweringPlant()
        {
            
        }

        public BananaFloweringPlant(BananaFruit bananaFruit)
        {
            this.BananaFruit = bananaFruit;
        }

        public override void Flowering()
        {
            Console.WriteLine($"{this.NumberOfFlowers} fleshy, purple-skinned flower");
        }

        public void Ripe()
        {
            this.BananaFruit.Ripe();
        }
    }
}
