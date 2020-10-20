using System;

namespace DesignPatterns.Adapter.Pattern
{
    public class Adaptee
    {
        public void MethodB()
        {
            Console.WriteLine("MethodB() is called");
        }
    }
}