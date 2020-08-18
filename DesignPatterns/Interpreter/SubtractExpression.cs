namespace DesignPatterns.Interpreter
{
    public class SubtractExpression : Expression, IExpression
    {
        public SubtractExpression(IExpression left, IExpression right)
            : base(left, right) { }

        decimal IExpression.Interpret()
        {
            return LeftExpression.Interpret() - RightExpression.Interpret();
        }
    }
}
