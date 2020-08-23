using System;
using System.Linq;
using System.Reflection;
/// <summary>
/// The marker interface pattern is a design pattern in computer science, used with languages that provide run-time type information about objects. 
/// It provides a means to associate metadata with a class where the language does not have explicit support for such metadata.
/// </summary>
namespace DesignPatterns.Marker
{
    public class Main : IPattern
    {
        public void Start()
        {
            Console.Write("Fruit salad with ");

            // Interface marker
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes()
                                                            .Where(c => c.GetInterfaces().Contains(typeof(IFruit))))
            {
                IFruit fruit = (IFruit)Activator.CreateInstance(type); //Create new instance of specific fruit
                Console.Write(fruit.GetType().Name.Split('.').Last() + ", ");
            }
            Console.WriteLine();

            Console.Write("Salad with ");

            // Attribute marker
            foreach (Type type in Assembly.GetExecutingAssembly().GetTypes())
            {
                if (type.GetCustomAttributes(typeof(Vegetable), true).Length > 0)
                {
                    object vegetable = Activator.CreateInstance(type); //Create new instance of specific vegetable
                    Console.Write(vegetable.GetType().Name.Split('.').Last() + ", ");
                }

            }
            Console.WriteLine();
        }
    }
}