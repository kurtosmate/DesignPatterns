namespace DesignPatterns.Interpreter
{
    public abstract class Expression
    {
        public IExpression LeftExpression { get;  }
        public IExpression RightExpression { get; }
        protected Expression(IExpression left, IExpression right)
        {
            LeftExpression = left;
            RightExpression = right;
        }

    }
}
