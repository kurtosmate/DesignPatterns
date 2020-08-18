using System;
/// <summary>
/// The interpreter pattern is a design pattern that specifies how to evaluate sentences in a language. 
/// The basic idea is to have a class for each symbol (terminal or nonterminal) in a specialized computer language.
/// The syntax tree of a sentence in the language is an instance of the composite pattern and is used to evaluate (interpret) the sentence for a client.
/// </summary>

namespace DesignPatterns.Interpreter
{
    public class Main : IPattern
    {
        public void Start()
        {
            var expressionParser = new ExpressionParser();

            // (5-8)+6=3
            var exprString = "+ - 5 8 6"; 
            var expression = expressionParser.Parse(exprString);
            Console.WriteLine($"{exprString} interpret result: {expression.Interpret()}");

            // ((7 + 5) / (6 + 2 )) * (9 - 5) 
            exprString = "* / + 7 5 + 6 2 - 9 5"; 
            expression = expressionParser.Parse(exprString);
            Console.WriteLine($"{exprString} interpret result: {expression.Interpret()}");

        }
    }
}
