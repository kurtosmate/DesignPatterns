namespace DesignPatterns.AbstractFactory
{
    abstract class AbstractFactory

    {

        public abstract AbstractEngineProduct CreateProductEngineProduct();
        public abstract AbstractChargerProduct CreateProductChargerProduct();
    }
}
