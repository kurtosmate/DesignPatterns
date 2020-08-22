namespace DesignPatterns.Specification
{
    public class DeniedSpecification : Specification
    {
        public override bool IsSatisfiedBy(Model candidate)
        {
            return candidate.Blocked || candidate.Age < 14;
        }
    }
}
