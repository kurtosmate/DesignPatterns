using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Specification
{
    public class AgeSpecification : Specification
    {
        public override bool IsSatisfiedBy(Model candidate)
        {
            return candidate.Age > 18;
        }
    }
}
