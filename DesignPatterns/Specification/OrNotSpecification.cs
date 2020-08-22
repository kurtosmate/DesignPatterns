namespace DesignPatterns.Specification
{
    internal class OrNotSpecification : Specification
    {
        private ISpecification leftCondition;
        private ISpecification rightCondition;

        public OrNotSpecification(ISpecification left, ISpecification right)
        {
            leftCondition = left;
            rightCondition = right;
        }

        public override bool IsSatisfiedBy(Model candidate)
        {
            return leftCondition.IsSatisfiedBy(candidate) || rightCondition.IsSatisfiedBy(candidate) != true;
        }
    }
}