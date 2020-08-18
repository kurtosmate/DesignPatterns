using System.Collections;

namespace DesignPatterns.Flyweight
{
    /// <summary>

    /// The 'FlyweightFactory' class

    /// </summary>

    class FlyweightFactory

    {
        private Hashtable flyweightCarModels = new Hashtable();

        // Constructor

        public FlyweightFactory()
        {
            flyweightCarModels.Add("RedSedan", new CarModelFlyweight("Red", "Sedan"));
            flyweightCarModels.Add("BlueSedan", new CarModelFlyweight("Blue", "Sedan"));
        }

        public FlyweightModel GetFlyweight(string color, string type)
        {
            var key = $"{color}{type}";
            if (! flyweightCarModels.ContainsKey(key))
            {
                flyweightCarModels.Add(key, new CarModelFlyweight(color, type));
            }
            
            return ((FlyweightModel)flyweightCarModels[key]);
        }
    }
}
