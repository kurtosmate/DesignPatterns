using System;
using System.Collections.Generic;
using System.Linq;

namespace DesignPatterns.Interpreter
{
    public class ExpressionParser
    {
        public IExpression Parse(string tokenString)
        {
            var tokenList = tokenString.Split(' ').ToList();
            return ReadNextToken(tokenList);
        }

        private IExpression ReadNextToken(IList<string> tokenList)
        {
            decimal number;
            if (decimal.TryParse(tokenList.First(), out number))
            {
                tokenList.RemoveAt(0);
                return new NumberExpression(number);
            }
            return ReadNonTerminal(tokenList);
        }

        private IExpression ReadNonTerminal(IList<string> tokenList)
        {
            var token = tokenList.First();
            tokenList.RemoveAt(0);
            var left = ReadNextToken(tokenList);
            var right = ReadNextToken(tokenList);

            switch (token)
            {
                case "+": return new AddExpression(left, right);
                case "-": return new SubtractExpression(left, right);
                case "*": return new MultiplyExpression(left, right);
                case "/": return new DivideExpression(left, right);
                default:
                    throw new ArgumentOutOfRangeException(string.Format("token:{0} is invalid!", token));
            }
        }
    }
}
