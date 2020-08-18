namespace DesignPatterns.Interpreter
{
    public class AddExpression : Expression, IExpression
    {
        public AddExpression(IExpression left, IExpression right)
            : base(left, right) { }

        decimal IExpression.Interpret()
        {
            return LeftExpression.Interpret() + RightExpression.Interpret();
        }
    }
}
