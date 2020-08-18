using System.Collections.Generic;
/// <summary>
/// The chain-of-responsibility pattern is a design pattern consisting of a source of command objects and a series of processing objects.
/// Each processing object contains logic that defines the types of command objects that it can handle; the rest are passed to the next processing object in the chain. 
/// </summary>

namespace DesignPatterns.ChainOfResponsibility
{
    public class Main : IPattern
    {
        public void Start()
        {
            // Setup Chain of Responsibility

            OrderHandler step1 = new BunHandler();
            OrderHandler step2 = new MeatHandler();
            OrderHandler step3 = new SaladHandler();
            step1.SetSuccessor(step2);
            step2.SetSuccessor(step3);

            // Generate and process request

            List<List<string>> requests = new List<List<string>> { new List<string>{ "Brown Bun", "Chicken", "Tomato" },
                                                                   new List<string> { "Simple Bun", "", "Cucumber and Tomato" } };

            foreach (var request in requests)
            {
                step1.HandleRequest(request);
            }
            
        }
    }
}
