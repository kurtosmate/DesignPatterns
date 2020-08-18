using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility
{
    /// <summary>

    /// The 'ConcreteHandler2' class

    /// </summary>

    class MeatHandler : OrderHandler

    {
        public override void HandleRequest(List<string> request)
        {
            if (!string.IsNullOrEmpty(request[1]))
            {
                Console.Write($"Roast {request[1]}, ");
            }
            if ( successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
