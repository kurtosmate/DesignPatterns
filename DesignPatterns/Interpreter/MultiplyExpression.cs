namespace DesignPatterns.Interpreter
{
    public class MultiplyExpression : Expression, IExpression
    {
        public MultiplyExpression(IExpression left, IExpression right)
            : base(left, right) { }

        decimal IExpression.Interpret()
        {
            return LeftExpression.Interpret() * RightExpression.Interpret();
        }
    }
}
