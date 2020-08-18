using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility
{
    /// <summary>

    /// The 'ConcreteHandler1' class

    /// </summary>

    class BunHandler : OrderHandler

    {
        public override void HandleRequest(List<string> request)
        {
            if (!string.IsNullOrEmpty(request[0]))
            {
                Console.Write($"Cut {request[0]} in half, ");

            }

            if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
