using System;

namespace DesignPatterns.Bridge.Pattern
{
    public class RefinedAbstraction : Abstraction
    {
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction:Operation()");
            Implementer.OperationImplementation();
        }
    }
}