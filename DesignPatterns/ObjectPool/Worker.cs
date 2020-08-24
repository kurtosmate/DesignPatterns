using System;
using System.Linq;

namespace DesignPatterns.ObjectPool
{
    public class Worker
    {
        public string WorkData { get; set; }
        public string Id { get; private set; }
        
        public Worker()
        {
            Id = Guid.NewGuid().ToString().Split('-').Last(); //Dont want to be too long for demo
        }

        public void DoWork()
        {
            Console.WriteLine($"{Id}: I'm doing {WorkData} ");
        }
    }
}