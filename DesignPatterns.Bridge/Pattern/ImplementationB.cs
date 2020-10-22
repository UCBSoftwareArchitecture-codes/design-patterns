using System;

namespace DesignPatterns.Bridge.Pattern
{
    public class ImplementationB : Bridge
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ImplementationB:OperationImplementation()");
        }
    }
}