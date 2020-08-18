using System;
using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility
{
    /// <summary>

    /// The 'ConcreteHandler3' class

    /// </summary>

    class SaladHandler : OrderHandler

    {
        public override void HandleRequest(List<string> request)
        {
            if (!string.IsNullOrEmpty(request[2]))
            {
                Console.WriteLine($"Chop {request[2]}");
            }
            if (successor != null)
            {
                successor.HandleRequest(request);
            }
        }
    }
}
