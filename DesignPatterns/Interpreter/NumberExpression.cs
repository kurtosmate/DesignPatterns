namespace DesignPatterns.Interpreter
{
    public class NumberExpression : IExpression
    {
        private readonly decimal _number = decimal.Zero;

        public NumberExpression(decimal number)
        {
            _number = number;
        }
        public decimal Interpret() => _number;

        
    }
}
