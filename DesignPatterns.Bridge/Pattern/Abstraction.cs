using System;

namespace DesignPatterns.Bridge.Pattern
{
    public abstract class Abstraction
    {
        public Bridge Implementer { get; set; }

        public virtual void Operation()
        {
            Console.WriteLine("ImplementationBase:Operation()");
            Implementer.OperationImplementation();
        }

    }
}