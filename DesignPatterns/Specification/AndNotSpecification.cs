namespace DesignPatterns.Specification
{
    internal class AndNotSpecification : Specification
    {
        private ISpecification leftCondition;
        private ISpecification rightCondition;

        public AndNotSpecification(ISpecification left, ISpecification right)
        {
            leftCondition = left;
            rightCondition = right;
        }

        public override bool IsSatisfiedBy(Model candidate)
        {
            return leftCondition.IsSatisfiedBy(candidate) && rightCondition.IsSatisfiedBy(candidate) != true;
        }
    }
}