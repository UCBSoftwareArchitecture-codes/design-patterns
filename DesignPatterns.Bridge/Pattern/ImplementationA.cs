using System;

namespace DesignPatterns.Bridge.Pattern
{
    public class ImplementationA : Bridge
    {
        public void OperationImplementation()
        {
            Console.WriteLine("ImplementationA:OperationImplementation()");
        }
    }
}