using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Twin
{
    public abstract class Fruit
    {
        public int NumberOfRipes { get; set; }

        public abstract void Ripe();   
    }
}
