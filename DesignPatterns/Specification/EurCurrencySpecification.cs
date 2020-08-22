using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Specification
{
    class EurCurrencySpecification : Specification
    {
        public override bool IsSatisfiedBy(Model candidate)
        {
            return candidate.Currency.ToString().ToLower() == "eur";
        }
    }
}
