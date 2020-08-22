namespace DesignPatterns.Specification
{
    internal class NotSpecification : Specification
    {
        private ISpecification Current;

        public NotSpecification(ISpecification current)
        {
            Current = current;
        }

        public override bool IsSatisfiedBy(Model candidate)
        {
            return !Current.IsSatisfiedBy(candidate);
        }
    }
}