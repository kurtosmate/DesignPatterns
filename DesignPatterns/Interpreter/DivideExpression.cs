namespace DesignPatterns.Interpreter
{
    public class DivideExpression : Expression, IExpression
    {
        public DivideExpression(IExpression left, IExpression right)
            : base(left, right) { }

        decimal IExpression.Interpret()
        {
            return LeftExpression.Interpret() / RightExpression.Interpret();
        }
    }
}
