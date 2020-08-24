using System;
/// <summary>
/// The object pool uses a set of initialized objects kept ready to use – a "pool" – rather than allocating and destroying them on demand. 
/// A client of the pool will request an object from the pool and perform operations on the returned object. 
/// When the client has finished, it returns the object to the pool rather than destroying it; this can be done manually or automatically.
/// </summary>
namespace DesignPatterns.ObjectPool
{
    public class Main : IPattern
    {
        public void Start()
        {

            // In real word scenario we can use a manager class for this 
            // and/or the Worker class could send an Event if the work is done and the Worker is ready to release
            Worker w1 = Pool.GetObject();
            w1.WorkData = "Wood cutting";
            
            Worker w2 = Pool.GetObject();
            w2.WorkData = "Measurement";
            
            Worker w3 = Pool.GetObject();
            w3.WorkData = "Building";

            w1.DoWork();
            w2.DoWork();

            Console.WriteLine($"{w2.Id} is done");
            Pool.ReleaseObject(w2); // Second worker is done, it is reuseable

            w3.DoWork();

            Worker w2_1 = Pool.GetObject(); // We need a worker. Instead of create a new one, we will get the free second worker back
            w2_1.WorkData = "Painting";
            w2_1.DoWork();
        }
    }
}
