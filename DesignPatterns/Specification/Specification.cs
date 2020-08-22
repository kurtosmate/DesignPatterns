using System;

namespace DesignPatterns.Specification
{
    public abstract class Specification : ISpecification
    {
        public abstract bool IsSatisfiedBy(Model candidate);

        public ISpecification And(ISpecification other)
        {
            return new AndSpecification(this, other);
        }

        public ISpecification AndNot(ISpecification other)
        {
            return new AndNotSpecification(this, other);
        }

        public ISpecification Or(ISpecification other)
        {
            return new OrSpecification(this, other);
        }

        public ISpecification OrNot(ISpecification other)
        {
            return new OrNotSpecification(this, other);
        }

        public ISpecification Not()
        {
            return new NotSpecification(this);
        }
    }
}
