using System;

namespace DesignPatterns.Facade.Pattern
{
    public class Facade
    {
        private SubsystemA _a = new SubsystemA();
        private SubsystemB _b = new SubsystemB();
        private SubsystemC _c = new SubsystemC();
        public void Operation1()
        {
            Console.WriteLine("Operation 1\n" +
            _a.OperationA1() +
            _a.OperationA2() +
            _b.OperationB1());
        }
        public void Operation2()
        {
            Console.WriteLine("Operation 2\n" +
            _b.OperationB2() +
            _c.OperationC1() +
            _c.OperationC2());
        }
    }
}