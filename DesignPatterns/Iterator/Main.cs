using System;
/// <summary>
/// The iterator pattern is a design pattern in which an iterator is used to traverse a container and access the container's elements. 
/// The iterator pattern decouples algorithms from containers; in some cases, algorithms are necessarily container-specific and thus cannot be decoupled.
/// </summary>
namespace DesignPatterns.Iterator
{
    public class Main : IPattern
    {
        public void Start()
        {
            ConcreteAggregate aggr = new ConcreteAggregate();
            aggr[0] = "Hello ";
            aggr[1] = "Iterator ";
            aggr[2] = "Design ";
            aggr[3] = "Pattern";

            // Create Iterator and provide aggregate

            Iterator i = aggr.CreateIterator();

            object item = i.First();
            while (item != null)
            {
                Console.Write(item);
                item = i.Next();
            }
            Console.WriteLine();
        }
    }
}
