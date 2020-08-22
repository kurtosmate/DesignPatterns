namespace DesignPatterns.Specification
{
    public interface ISpecification
    {
        bool IsSatisfiedBy(Model candidate);
        ISpecification And(ISpecification other);
        ISpecification AndNot(ISpecification other);
        ISpecification Or(ISpecification other);
        ISpecification OrNot(ISpecification other);
        ISpecification Not();
    }
}
