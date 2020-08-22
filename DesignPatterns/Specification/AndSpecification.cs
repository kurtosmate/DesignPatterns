namespace DesignPatterns.Specification
{
    public class AndSpecification : Specification
    {
        private ISpecification leftCondition;
        private ISpecification rightCondition;

        public AndSpecification(ISpecification left, ISpecification right)
        {
            leftCondition = left;
            rightCondition = right;
        }

        public override bool IsSatisfiedBy(Model candidate)
        {
            return leftCondition.IsSatisfiedBy(candidate) && rightCondition.IsSatisfiedBy(candidate);
        }
    }
}