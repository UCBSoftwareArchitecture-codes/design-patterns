namespace DesignPatterns.FactoryMethod.Pattern
{
    public abstract class Creator
    {
        public abstract IProduct FactoryMethod(string type);
        
    }
}