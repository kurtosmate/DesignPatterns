using System;
using System.Collections.Generic;

namespace DesignPatterns.Builder
{
    /// <summary>

    /// The 'Product' class

    /// </summary>

    class Car
    {
        private string _brandName;

        private List<string> _parts = new List<string>();

        public Car(string brandName)
        {
            this._brandName = brandName;
        }

        public void Add(string part)
        {
            _parts.Add(part);
        }

        public void Show()
        {
            Console.Write($"{_brandName} has ");
            foreach (string part in _parts)
                Console.Write($"{part}, ");
            Console.WriteLine();
        }
    }
}
