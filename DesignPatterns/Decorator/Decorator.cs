namespace DesignPatterns.Decorator
{
    /// <summary>

    /// The 'Decorator' abstract class

    /// </summary>

    abstract class Decorator : ShapeComponent

    {
        protected ShapeComponent component;

        public void SetComponent(ShapeComponent component)
        {
            this.component = component;
        }

        public override void Operation()
        {
            if (component != null)
            {
                component.Operation();
            }
        }
    }
}
