using System;
using System.Collections.Generic;

namespace DesignPatterns.Multiton
{
    public class Multiton
    {
        public static uint MaxNumberOfInstances { get; private set; } = 3; //Could be calculated based on business logic or config file etc...
        
        private static object myLock = new object();
        
        private static readonly IDictionary<uint, Multiton> instances = new Dictionary<uint, Multiton>();
        
        public uint Id { get; private set; }

        // Constructor is 'protected' or 'private'
        private Multiton(uint id)
        {
            this.Id = id;
        }

        public static Multiton Instance(uint id)
        {
            if (id > MaxNumberOfInstances)
            {
                throw new ArgumentException($"Maximum {MaxNumberOfInstances} number of instances enabled");
            }

            if (!instances.ContainsKey(id)) // 1st check
            {
                lock (myLock)
                {
                    if (!instances.ContainsKey(id))
                    {
                        instances.Add(id, new Multiton(id));
                    }
                }
            }
            return instances[id];
        }

        //Some busines logic
        public int NumberOfMessages { get; private set; } = 0;
        public void SendMessage(string message)
        {
            System.Console.WriteLine($"#{Id} accepted new message: {message}");
            NumberOfMessages++;
        }
    }
}
