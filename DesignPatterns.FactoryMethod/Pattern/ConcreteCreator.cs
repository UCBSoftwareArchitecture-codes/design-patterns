using System;

namespace DesignPatterns.FactoryMethod.Pattern
{
    public class ConcreteCreator : Creator
    {
        public override IProduct FactoryMethod(string type)
        {
            switch (type)
            {
                case "A": return new ProductA();
                case "B": return new ProductB();
                default: throw new Exception("Invalid type");
            }
        }
        
    }
}