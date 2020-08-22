using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Specification
{
    public class BasketTotalPriceSpecification : Specification
    {
        public override bool IsSatisfiedBy(Model candidate)
        {
            return candidate.BasketTotalPrice > 100;
        }
    }
}
