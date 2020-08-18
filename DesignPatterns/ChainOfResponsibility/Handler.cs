using System.Collections.Generic;

namespace DesignPatterns.ChainOfResponsibility
{
    /// <summary>

    /// The 'Handler' abstract class

    /// </summary>

    abstract class OrderHandler

    {
        protected OrderHandler successor;

        public void SetSuccessor(OrderHandler successor)
        {
            this.successor = successor;
        }

        public abstract void HandleRequest(List<string> request);
    }
}
